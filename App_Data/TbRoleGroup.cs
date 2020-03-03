using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbRoleGroup
    {
        public TbRoleGroup()
        {
            TbRoleGroupAction = new HashSet<TbRoleGroupAction>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<TbRoleGroupAction> TbRoleGroupAction { get; set; }
    }
}
