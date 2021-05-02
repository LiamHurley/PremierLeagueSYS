using System;

namespace PremierLeagueSYS
{
    class Utility
    {
        //method for removing the extra 0's from "000" formatted Team/Fixture IDs.
        public static String deformatId(String idStr)
        {
            if (idStr.Substring(0, 2).Equals("00"))
            {
                idStr = idStr.Remove(0, 2);
            }
            else if (idStr[0] == '0' && idStr[1] != '0')
            {
                idStr = idStr.Remove(0, 1);
            }

            return idStr;
        }
    }
}
