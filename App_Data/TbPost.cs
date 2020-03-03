using System;
using System.Collections.Generic;

namespace CongThongTin.App_Data
{
    public partial class TbPost
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Introduction { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Avatar { get; set; }
        public string Tag { get; set; }
        public string Link { get; set; }
        public int? TypePostId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserCreateId { get; set; }
        public DateTime? EditDate { get; set; }
        public int? UserEditId { get; set; }
        public DateTime? SubmitDate { get; set; }
    }
}
