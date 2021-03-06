﻿using System;
using System.Net;

namespace JScan.Utilities
{
    public static class IpFunctions
    {
        public static uint ToUint(this IPAddress input)
        {
            Array.Reverse(input.GetAddressBytes());
            return BitConverter.ToUInt32(input.GetAddressBytes(), 0);
        }
    }
}