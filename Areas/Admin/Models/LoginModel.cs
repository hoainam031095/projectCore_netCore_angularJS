using CongThongTin.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CongThongTin.Areas.Admin.Models
{
    public class LoginModel
    {
        private readonly congthongtinContext db;
        public LoginModel()
        {
            db = new congthongtinContext();
        }

        public TbUser CheckLogin(string username, string password)
        {
            TbUser user = db.TbUser.FirstOrDefault(us => us.UserName == username && us.PassWord == password && us.IsActive == true);
            return user;
        }
    }
}
