using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Helper.Misc
{
    public static class GV
    {

        public enum CatalogType
        {
            CatalogA1,
            CatalogA2,
            CatalogA3,
            CatalogA4,
            CatalogB1,
            CatalogB2,
            CatalogB3,
            CatalogB4,
            CatalogB5,
            CatalogC1,
            CatalogC2,
            CatalogC3,
            CatalogC4,
            CatalogD1,
            CatalogD2,
            CatalogE1,
            CatalogE2,
            CatalogE3,
            CatalogE4,
            CatalogE5,
            CatalogE6,
            CatalogE7,
            CatalogF1,
            CatalogG1,
            CatalogG2,
            CatalogG3,
            CatalogG4,
            CatalogG5,
            CatalogG6,
            CatalogH1,
            CatalogH2,
            CatalogH3,
            CatalogH4,
            CatalogH5,
        }

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
