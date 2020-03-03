using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Areas.Admin.Models
{
    public class mRole
    {
        public int id { get; set; }
        public string groupName { get; set; }
        public string description { get; set; }
        public DateTime? createDate { get; set; }
        public bool? isActive { get; set; }
    }
}
