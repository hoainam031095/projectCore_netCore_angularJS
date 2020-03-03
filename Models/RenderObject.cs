using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Models
{
    public class AccountLogin
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string captcha { get; set; }
        public string remember { get; set; }
    }

    public class AccountSession
    {
        public string UserName { get; set; }
        public int? Id { get; set; }
        public int? RoleGroupId { get; set; }
        public string FullName { get; set; }
    }

    public class DataTableMessage
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public object data { get; set; }
        public object extend { get; set; }
    }

    public class ResSubmit
    {
        public ResSubmit(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }

        public bool success { get; set; }
        public string message { get; set; }
        public object idNew { get; set; }
        public object extend { get; set; }
    }

    public class validateObject
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
