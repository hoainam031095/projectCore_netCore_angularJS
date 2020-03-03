using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbRoleGroupAction
    {
        public int Id { get; set; }
        public int? RoleGroupId { get; set; }
        public int? ActionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual TbAction Action { get; set; }
        public virtual TbRoleGroup RoleGroup { get; set; }
    }
}
