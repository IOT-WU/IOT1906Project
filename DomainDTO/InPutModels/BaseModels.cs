using System.ComponentModel.DataAnnotations.Schema;

namespace bpmdemoapi.models
{
    [NotMapped]
    public class BaseModels
    {
        public string Action { get; set; }
        public string BPMUser { get; set; }
        public string BPMUserPass { get; set; }
        public string FullName { get; set; }
        public string ProcessName { get; set; }
    }
}
