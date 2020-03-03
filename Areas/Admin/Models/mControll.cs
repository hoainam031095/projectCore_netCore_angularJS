using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Areas.Admin.Models
{
    public class mControll
    {
        public int id { get; set; }
        public string controller { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string display { get; set; }
        public string description { get; set; }
        public string namespaces { get; set; }
        public string url { get; set; }
        public int? level { get; set; }
        public int? parentId { get; set; }
        public bool? isActive { get; set; }
        public bool? isDelete { get; set; }
        public int? sortValue { get; set; }
        public int? type { get; set; }
    }
}
