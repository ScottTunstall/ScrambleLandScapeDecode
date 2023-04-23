﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleLandscapeDecode.Landscapes
{
    public class Landscape5: ILandscape
    {
        public byte[] GetLandScape()
        {
            return new byte[]
            {
                0x60, 0xD1, 0x60, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x02, 0x60, 0xD1, 0x60, 0xD1, 0x47, 0xD1, 0x47,
                0xD1, 0x02, 0x60, 0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x37,
                0xD1, 0x37, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x50, 0xD1, 0x50,
                0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x02, 0x50, 0xD1, 0x50, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x60,
                0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1,
                0x00, 0x60, 0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x47, 0xD1,
                0x47, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1,
                0x47, 0xD1, 0x47, 0xD1, 0x02, 0x60, 0xD1, 0x60, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x02, 0x60, 0xD1,
                0x60, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x02, 0x60, 0xD1, 0x60, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x02,
                0x60, 0xD1, 0x60, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x2F, 0xD1, 0x2F,
                0xD1, 0x00, 0x40, 0xD1, 0x40, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0x40, 0xD1, 0x40, 0xD1, 0x2F,
                0xD1, 0x2F, 0xD1, 0x00, 0x40, 0xD1, 0x40, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0x40, 0xD1, 0x40,
                0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0x40, 0xD1, 0x40, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0xA0,
                0xD1, 0xA0, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1,
                0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x2F, 0xD1,
                0x2F, 0xD1, 0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x2F, 0xD1, 0x2F, 0xD1, 0x02, 0xA0, 0xD1, 0xA0, 0xD1,
                0x2F, 0xD1, 0x2F, 0xD1, 0x02, 0xA0, 0xD1, 0xA0, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x02, 0xA0, 0xD1,
                0xA0, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x02, 0xA0, 0xD1, 0xA0, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x02,
                0xA0, 0xD1, 0xA0, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x02, 0xA0, 0xD1, 0xA0, 0xD1, 0x8F, 0xD1, 0x8F,
                0xD1, 0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x00, 0xA0, 0xD1, 0xA0, 0xD1, 0x8F,
                0xD1, 0x8F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8,
                0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x8F, 0xD1, 0x8F, 0xD1, 0x00, 0xD8,
                0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1,
                0x02, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x02, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1,
                0xC7, 0xD1, 0x02, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x02, 0xD8, 0xD1, 0xD8, 0xD1,
                0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1,
                0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00,
                0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F,
                0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x50, 0xD1, 0x50, 0xD1, 0x3F,
                0xD1, 0x3F, 0xD1, 0x00, 0x50, 0xD1, 0x50, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x50, 0xD1, 0x50,
                0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x50, 0xD1, 0x50, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x50,
                0xD1, 0x50, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1,
                0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1,
                0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1,
                0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1,
                0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00,
                0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7,
                0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7,
                0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8,
                0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0xD8,
                0xD1, 0xD8, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1,
                0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x4F, 0xD1,
                0x4F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1,
                0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x4F, 0xD1, 0x4F, 0xD1, 0x00, 0x60, 0xD1,
                0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00,
                0x48, 0xD1, 0x48, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x48, 0xD1, 0x48, 0xD1, 0x37, 0xD1, 0x37,
                0xD1, 0x00, 0x48, 0xD1, 0x48, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x58, 0xD1, 0x58, 0xD1, 0x37,
                0xD1, 0x37, 0xD1, 0x00, 0x58, 0xD1, 0x58, 0xD1, 0x37, 0xD1, 0x37, 0xD1, 0x00, 0x58, 0xD1, 0x58,
                0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0x58, 0xD1, 0x58, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0x58,
                0xD1, 0x58, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0x58, 0xD1, 0x58, 0xD1, 0x47, 0xD1, 0x47, 0xD1,
                0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x47, 0xD1,
                0x47, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1,
                0x47, 0xD1, 0x47, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x47, 0xD1, 0x47, 0xD1, 0x00, 0xD8, 0xD1,
                0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00,
                0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7,
                0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7,
                0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8,
                0xD1, 0xC7, 0xD1, 0xC7, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8,
                0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1,
                0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1,
                0x3F, 0xD1, 0x00, 0xD8, 0xD1, 0xD8, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x50, 0xD1, 0x50, 0xD1,
                0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x60, 0xD1,
                0x60, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00, 0x60, 0xD1, 0x60, 0xD1, 0x3F, 0xD1, 0x3F, 0xD1, 0x00,
                0xFF
            };
        }
    }
}
