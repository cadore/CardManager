using CardManagerRepo;
using ModelsCardManager.Utils;
using System;

namespace ModelsCardManager.Utils
{
    public class CardUtils
    {
        public static string GenerateCardCode(customer c)
        {
            string NC = c.name.Substring(0, 1).ToUpper();
            string Number = String.Format("{0:D8}", c.id);
            return String.Format("{0}{1}{2}", GetVersionCard(), NC, Number);
        }

        public static string Alphabet()
        {
            return " ABCDEFGHIJKLMNOPQRSTUVXYWZ";
        }

        public static string GetVersionCard()
        {
            int versionnumber = Convert.ToInt32(INI.ReadValue("SYSTEM", "VersionCard"));
            string s = Alphabet().Substring(versionnumber, 1);
            return s;
        }
    }
}
