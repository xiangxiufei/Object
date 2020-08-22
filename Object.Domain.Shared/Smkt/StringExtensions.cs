using System;

namespace Object.Domain.Shared.Smkt
{
    public static class StringExtensions
    {
        public static string ToSmktEncrypt(this string pwdtxt)
        {
            string pass = "";

            int ii;
            int li_asc = 0;

            for (ii = pwdtxt.Length; ii > 0; ii--)
            {
                li_asc = (int)Convert.ToChar((pwdtxt.Substring((ii - 1), 1).ToString().ToUpper()));

                string a = pwdtxt.Substring((ii - 1), 1).ToString();
                li_asc = (li_asc + ((li_asc % 10) + ii) * ii) + ii;

                if (li_asc > 255)
                {
                    li_asc = li_asc - 100;
                }
                pass = pass + ((char)(Convert.ToInt32(li_asc))).ToString();
            }
            return pass;
        }
    }
}