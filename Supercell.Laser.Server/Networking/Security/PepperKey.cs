﻿using Supercell.Laser.Titan.Library;

namespace Supercell.Laser.Server.Networking.Security
{
    public static class PepperKey
    {
        public const int VERSION = 14;
        
        public static readonly byte[] CLIENT_SK = { 0x84, 0x82, 0x46, 0x93, 0xAB, 0x9A, 0xA7, 0xAA, 0xC9, 0x53, 0x16, 0x1D, 0x34, 0x26, 0xE8, 0x72, 0xE2, 0xD4, 0xF6, 0xB3, 0x28, 0xCD, 0x27, 0xCA, 0xE3, 0x77, 0x33, 0x1B, 0xA1, 0xBC, 0x23, 0x5C };
        public static readonly byte[] CLIENT_PK = TweetNaCl.CryptoScalarmultBase(CLIENT_SK);

        //public static readonly byte[] SERVER_SK = { 0xC4, 0x1C, 0x48, 0x2E, 0xA2, 0xBB, 0xB5, 0x12, 0x19, 0xDD, 0x1A, 0x26, 0x70, 0x96, 0x0F, 0x47, 0x09, 0x46, 0x2E, 0xC4, 0xFD, 0xB6, 0xE7, 0xB6, 0x65, 0x21, 0xDD, 0x55, 0xF3, 0x37, 0xE6, 0x39 };
        //public static readonky 
        //public static readonly byte[] SERVER_PK = new byte[32];
        public static readonly byte[] SERVER_SK = { 158, 217, 110, 5, 87, 249, 222, 234, 204, 121, 177, 228, 59, 79, 93, 217, 25, 33, 113, 185, 119, 171, 205, 246, 11, 185, 185, 22, 140, 152, 107, 20};
        public static readonly byte[] SERVER_PK = TweetNaCl.CryptoScalarmultBase(SERVER_SK);

    }
}
