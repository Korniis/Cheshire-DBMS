using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mysql.DAL.Helper
{
    public  class MD5Helper
    {public static string GetMD5(string password)
        {
            byte[] result = Encoding.Default.GetBytes(password);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
          password = BitConverter.ToString(output).Replace("-", "");  //tbMd5pass为输出加密文本的文本框
            return password;
        }

    }
}
