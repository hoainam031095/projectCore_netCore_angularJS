using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbExceptionLog
    {
        public int Id { get; set; }
        public string NameEx { get; set; }
        public string FullNameEx { get; set; }
        public string StackTrace { get; set; }
        public string Message { get; set; }
        public DateTime? TimeLog { get; set; }
    }
}
