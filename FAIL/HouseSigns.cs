﻿using ScriptSDK;
using ScriptSDK.Attributes;
using ScriptSDK.Data;
using ScriptSDK.Items;

namespace FAIL
{
    [QuerySearch(new ushort[] {
       0x0B96, 0x0BA4, 0x0BA6, 0x0BA8, 0x0BAA,
        0x0BAC, 0x0BAE, 0x0BB0, 0x0BB2, 0x0BB4,
        0x0BB6, 0x0BB8, 0x0BBA, 0x0BBC, 0x0BBE,
        0x0BC0, 0x0BC2, 0x0BC4, 0x0BC6, 0x0BC8,
        0x0BCA, 0x0BCC, 0x0BCE, 0x0BD0, 0x0BD2,
        0x0BD4, 0x0BD6, 0x0BD8, 0x0BDA, 0x0BDC,
        0x0BDE, 0x0BE0, 0x0BE2, 0x0BE4, 0x0BE6,
        0x0BE8, 0x0BEA, 0x0BEC, 0x0BEE, 0x0BF0,
        0x0BF2, 0x0BF4, 0x0BF6, 0x0BF8, 0x0BFA,
        0x0BFC, 0x0BFE, 0x0C00, 0x0C02, 0x0C04,
        0x0C06, 0x0C08, 0x0C0A, 0x0C0C, 0x0C0E,
        0x0C44 })]
    public class HouseSigns : Item
    {
        public HouseSigns(Serial serial)
            : base(serial)
        {
        }
    }
}