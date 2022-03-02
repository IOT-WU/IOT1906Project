using DomainDTO.AutoMapper;
using IRepository;
using IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MyDB;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //�������ݿ�
            services.AddDbContext<MyDBContext>(x => x.UseSqlServer(Configuration.GetConnectionString("con")));
            //����
            services.AddCors(x => x.AddPolicy("MyCors", s => s.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            //ע��ӳ��
            //services.AddAutoMapper(typeof(AutoMapperConfigs));
            //ע��ִ�
            services.AddScoped(typeof(IRepositoryDB<>), typeof(RepositorySqlDB<>));//��ɾ�Ĳ鷴

            #region ע�������
            //����дע�������
            services.AddScoped<IUserServices, UserServices>();  //�û�����
            services.AddScoped<ILeaveServices, LeaveServices>();  //��ٷ���
            services.AddScoped<IProcurementServices, ProcurementServices>();  //��ٷ���
            services.AddScoped<IMeetingRoomServices, MeetingRoomServices>();  //��ٷ���
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement { {
                    new OpenApiSecurityScheme{
                     Reference=new OpenApiReference{
                      Id="Bearer", Type= ReferenceType.SecurityScheme
                     }
                    },
                    new string[]{ }
                    }
                });
            });
            ///��֤�������
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                //��һ����Ǿ���payload
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    // �Ƿ���ǩ����֤
                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("secretKey").Value)),
                    // ��������֤������Ҫ��token����Claim���͵ķ����˱���һ��
                    ValidateIssuer = true,
                    ValidIssuer = "API",//������
                    // ��������֤
                    ValidateAudience = true,
                    ValidAudience = "User",//������
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project v1"));
            }
            //����
            app.UseCors("MyCors");
            //·��
            app.UseRouting();
            //��Ȩ
            app.UseAuthentication();
            //��֤
            app.UseAuthorization();
            //���þ�̬�ļ�
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
