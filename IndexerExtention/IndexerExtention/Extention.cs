using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    public static class Extention
    {
        public static bool IsEmail(this string mail)
        {
            try
            {
                MailAddress email = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static double CustomPow(this double num,double pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
