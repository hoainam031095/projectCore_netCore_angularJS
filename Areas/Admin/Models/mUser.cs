using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Models
{
    public class mUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? Type { get; set; }
        public bool? IsActive { get; set; }
        public string Avatar { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? RoleGroupId { get; set; }
        public string RoleGroupName { get; set; }
    }
}
