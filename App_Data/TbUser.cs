using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbUser
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
    }
}
