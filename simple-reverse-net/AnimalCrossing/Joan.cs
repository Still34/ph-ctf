﻿using System;
using System.Linq;
using System.Reflection;

namespace AnimalCrossing
{
    internal class Joan
    {
        private readonly byte[] _codeThree =
        {
            0x74, 0x00, 0x4d, 0x45, 0x35, 0x00, 0x6b, 0x58, 0x00, 0x7a, 0x00, 0x46, 0x00, 0x4f, 0x58, 0x7a, 0x00, 0x52,
            0x66, 0x00, 0x54, 0x00, 0x54, 0x00, 0x51, 0x78, 0x52, 0x00, 0x46, 0x00, 0x39, 0x00, 0x6a, 0x4d, 0x00, 0x44,
            0x00, 0x55, 0x00, 0x33, 0x00, 0x64, 0x57, 0x00, 0x30, 0x7a, 0x00, 0x50, 0x00, 0x7a, 0x38, 0x2f, 0x66, 0x51,
            0x00, 0x3d, 0x00, 0x3d, 0x00
        };

        private readonly Random _random;

        public Joan()
        {
            _random = new Random();
        }

        public int GetTurnipPrice()
        {
            return _random.Next(100, 2000);
        }

        [Alien("NTMzbl9SNHl")]
        private string GetNookMilesTicketRedeemCode()
        {
            var codeOne = typeof(Redd).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).First().Name;
            var codeTwo = " the alien got my tongue ";
            return $"{codeOne}{codeTwo}{_codeThree}";
        }
    }
}