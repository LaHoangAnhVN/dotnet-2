﻿using System.Collections.Generic;

namespace Lab2.Model
{
    public class PhoneNumber
    {
        public List<byte> CountryCode { get; set; }
        public List<byte> LocalCode { get; set; }
        public List<byte> LastNumber { get; set; }
        public override string ToString() => $"+{string.Join("", CountryCode.ToArray())}-{string.Join("", LocalCode.ToArray())}-{string.Join("", LastNumber.ToArray())}";
    }
}
