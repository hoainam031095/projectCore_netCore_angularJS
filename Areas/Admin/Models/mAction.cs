using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Areas.Admin.Models
{
    public class mAction
    {
        public int id { get; set; }
        public string action { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string display { get; set; }
        public string url { get; set; }
        public string namespaces { get; set; }
        public int? controllerId { get; set; }
        public string controllerName { get; set; }
        public bool? isActive { get; set; }
        public bool? isDelete { get; set; }
        public string description { get; set; }
        public bool checkeds{ get; set; }
    }
}
