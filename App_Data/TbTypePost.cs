using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbTypePost
    {
        public int Id { get; set; }
        public string TypePostName { get; set; }
        public string Link { get; set; }
        public int? ParentId { get; set; }
        public int? Status { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Controller { get; set; }
        public string Route { get; set; }
    }
}
