using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbController
    {
        public TbController()
        {
            TbAction = new HashSet<TbAction>();
        }

        public int Id { get; set; }
        public string Controller { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public string Description { get; set; }
        public string Namespace { get; set; }
        public string Url { get; set; }
        public int? Level { get; set; }
        public int? ParentId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? SortValue { get; set; }
        public int? Type { get; set; }

        public virtual ICollection<TbAction> TbAction { get; set; }
    }
}
