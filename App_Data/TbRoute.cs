using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbRoute
    {
        public int Id { get; set; }
        public string Namespace { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
