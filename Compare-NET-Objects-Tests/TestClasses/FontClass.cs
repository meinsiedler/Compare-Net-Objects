﻿#if !NETSTANDARD && !NET8_0

using System.Drawing;

namespace KellermanSoftware.CompareNetObjectsTests.TestClasses
{
    public class FontClass
    {
        public Font FieldObject;
        public Font PropertyObject { get; set; }
        public static Font StaticObject { get; set; }
    }
}

#endif
