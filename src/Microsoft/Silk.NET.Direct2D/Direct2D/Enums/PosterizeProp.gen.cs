// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_POSTERIZE_PROP")]
    public enum PosterizeProp : int
    {
        [NativeName("Name", "D2D1_POSTERIZE_PROP_RED_VALUE_COUNT")]
        RedValueCount = 0x0,
        [NativeName("Name", "D2D1_POSTERIZE_PROP_GREEN_VALUE_COUNT")]
        GreenValueCount = 0x1,
        [NativeName("Name", "D2D1_POSTERIZE_PROP_BLUE_VALUE_COUNT")]
        BlueValueCount = 0x2,
        [NativeName("Name", "D2D1_POSTERIZE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
