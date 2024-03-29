﻿using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Orion.Helper.Misc
{
    public static class GV
    {
        // [new]
        //public enum CatalogType
        //{
        //    CatalogA1,
        //    CatalogA2,
        //    CatalogA3,
        //    CatalogA4,
            
        //    CatalogB1,
        //    CatalogB2,
        //    CatalogB3,
        //    CatalogB4,
        //    CatalogB5,
            
        //    CatalogC1,
        //    CatalogC2,
        //    CatalogC3,
        //    CatalogC4,
        //    CatalogC5,
        //    CatalogC6,
        //    CatalogC7,
            
        //    CatalogD1,
        //    CatalogD2,
            
        //    CatalogE1,
        //    CatalogE2,
        //    CatalogE3,
        //    CatalogE4,
        //    CatalogE5,
        //    CatalogE6,
        //    CatalogE7,
            
        //    CatalogF1,
            
        //    CatalogG1,
        //    CatalogG2,
        //    CatalogG3,
        //    CatalogG4,
        //    CatalogG5,
        //    CatalogG6,
            
        //    CatalogH1,
        //    CatalogH2,
        //    CatalogH3,
        //    CatalogH4,
        //    CatalogH5,
            
        //    CatalogI1,
        //    CatalogI2,
            
        //    CatalogJ1,
            
        //    CatalogK1,
        //    CatalogK2,
        //    CatalogK3,
            
        //    CatalogL1,

        //    CatalogM1,
        //}
        // [new]
        public enum ItemType
        {
            ItemA1,
            ItemA2,
            ItemA3,
            ItemA4,

            ItemB1,
            ItemB2,
            ItemB3,
            ItemB4,
            ItemB5,

            ItemC1,
            ItemC2,
            ItemC3,
            ItemC4,
            ItemC5,
            ItemC6,
            ItemC7,

            ItemD1,
            ItemD2,

            ItemE1,
            ItemE2,
            ItemE3,
            ItemE4,
            ItemE5,
            ItemE6,
            ItemE7,

            ItemF1,

            ItemG1,
            ItemG2,
            ItemG3,
            ItemG4,
            ItemG5,
            ItemG6,

            ItemH1,
            ItemH2,
            ItemH3,
            ItemH4,
            ItemH5,

            ItemI1,
            ItemI2,

            ItemJ1,

            ItemK1,
            ItemK2,
            ItemK3,

            ItemL1,

            ItemM1,

            ItemN1,

            ItemO1,
            ItemO2,

            ItemP1,

            ItemQ1,
            ItemQ2,
            ItemQ3,
            ItemQ4,

            ItemR1,
            ItemR2,
            ItemR3,
            ItemR4,

            ItemS1,

            ItemT1,
            ItemT2,
            ItemT3,

            ItemU1,

            ItemV1,

            ItemW1,

            ItemX1,
            ItemX2,
            ItemX3,
            ItemX4,
            ItemX5,

            ItemY1,

            ItemZ1,

            ItemAA1,
        }
        // [new]
        public enum Subfix
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J,
            K,
            L,
            M,
            N,
            O,
            P,
            Q,
            R,
            S,
            T,
            U,
            V,
            W,
            X,
            Y,
            Z,
            AA,
        }

        public static string Version { get { return "XpressPro 1.1"; } }

        public static bool Extended { get; set; }

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
