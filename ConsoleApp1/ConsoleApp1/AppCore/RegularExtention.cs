using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.AppCore
{
    
    public static partial class Extention
    {
        public const string Email_Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public const string Phone_Pattern = @"^(?<olkekodu>\+994|0)(?<operator>50|51||55|60|70|77|99)-(\d{3}-\d{2}-\d{2})$";
        public static bool isEmail(this string email)
        {
            string emailPattern = @"";
            Match emailResult= Regex.Match(email, emailPattern);
            if (emailResult.Success)
                return true;
            return false;
        }
        public static bool isPhone(this string phone)
        {
            string phonePattern = @"";
            Match phoneResult = Regex.Match(phone, phonePattern);
            if (Regex.IsMatch(phone, phonePattern))
                return true;                
            return false;
        }
    }
}
