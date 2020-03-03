using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbAction
    {
        public TbAction()
        {
            TbRoleGroupAction = new HashSet<TbRoleGroupAction>();
        }

        public int Id { get; set; }
        public string Action { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public string Url { get; set; }
        public string Namespace { get; set; }
        public int? ControllerId { get; set; }
        public string ControllerName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public string Description { get; set; }

        public virtual TbController Controller { get; set; }
        public virtual ICollection<TbRoleGroupAction> TbRoleGroupAction { get; set; }
    }
}
