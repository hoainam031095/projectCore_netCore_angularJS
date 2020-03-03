using CongThongTin.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CongThongTin.Models
{
    public class Utils
    {
        //antiAttack
        static List<string> stringAttack = new List<string>() {
            "/web.xml", "win.ini", "etc/passwd", "%c0%ae/", "Injection", "master.dbo", "declare @",
            "select.*?from", "<[^>]*script", "{applicationScope}", "<script.*?", "&lt;script.*", "window.location"
        };
        public static bool antiAttack(string data)
        {
            foreach (var item in stringAttack)
            {
                if (Regex.IsMatch(data, item)) //Kiểm tra Regex(item) có tồn tại trong data không
                {
                    return true;
                }
            }
            return false;
        }

        //Write Log Excpetion
        public static void writeLog(Exception ex)
        {
            congthongtinContext db = new congthongtinContext();
            if (ex != null)
            {
                TbExceptionLog exlog = new TbExceptionLog();
                exlog.NameEx = ex.GetType().Name;
                exlog.FullNameEx = ex.GetType().FullName;
                exlog.StackTrace = ex.StackTrace;
                exlog.Message = ex.Message; /*+ " - CODE: " + ex.HResult + " / " +ex.GetType().GUID;*/
                exlog.TimeLog = DateTime.Now;
                db.TbExceptionLog.Add(exlog);
                db.SaveChanges();
            }
        }

        //Encrypt
        public static string Encrypt(string toEncrypt, string key)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        //Decrypt
        public static string Decrypt(string toDecrypt, string key)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

    }
}
