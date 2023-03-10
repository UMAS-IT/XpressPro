using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Helper.Misc
{
    public static class GV
    {
        public enum ItemType
        {
            A1,
            A2,
            A3,
            A4,
            B1,
            B2,
            B3,
            B4,
            B5,
            C1,
            C2,
            C3,
            C4,
            D1,
            D2,
            E1,
            E2,
            E3,
            E4,
            E5, 
            E6,
            E7,
            F1,
            G1,
            G2,
            G3,
            G4,
            G5, 
            G6,
            H1,
            H2,
            H3,
            H4,
            H5,
        }

        public static int RandomProjectNumber()
        {
            Random random = new Random();
            return random.Next(0, 99999);
        }
        public static DateTime GetPacificStandardTime()
        {
            var utc = DateTime.UtcNow;
            TimeZoneInfo pacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utc, pacificZone);
            return pacificTime;
        }

        public static string RandomName()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(10, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(10, false));
            return builder.ToString();
        }

        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }


    }
}
