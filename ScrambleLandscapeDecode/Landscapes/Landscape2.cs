﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleLandscapeDecode.Landscapes
{
    public class Landscape2: ILandscape
    {
        public byte[] GetLandScape()
        {
            return new byte[]
            {
                0xC8, 0x2E, 0xD0, 0x36, 0x28, 0x63, 0x28, 0x5E, 0x00, 0xD0, 0x36, 0xD0, 0x2D, 0x28, 0x5E, 0x30,
                0x63, 0x00, 0xD8, 0x36, 0xD8, 0x36, 0x30, 0x5E, 0x30, 0x5E, 0x02, 0xD8, 0x2F, 0xE0, 0x36, 0x38,
                0x63, 0x38, 0x5E, 0x00, 0xE0, 0x36, 0xD8, 0x31, 0x38, 0x5E, 0x40, 0x63, 0x00, 0xD0, 0x30, 0xC8,
                0x30, 0x48, 0x62, 0x48, 0x62, 0x00, 0xC0, 0x30, 0xB8, 0x31, 0x48, 0x5D, 0x50, 0x62, 0x00, 0xB8,
                0x36, 0xB8, 0x35, 0x50, 0x5E, 0x5F, 0x62, 0x00, 0xB0, 0x34, 0xB8, 0x2C, 0x5F, 0x5D, 0x5F, 0x60,
                0x00, 0xC0, 0x35, 0xB8, 0x34, 0x50, 0x60, 0x48, 0x60, 0x00, 0xC0, 0x2D, 0xC8, 0x2C, 0x48, 0x62,
                0x50, 0x62, 0x00, 0xD0, 0x36, 0xD0, 0x2C, 0x50, 0x60, 0x50, 0x62, 0x00, 0xD8, 0x2D, 0xD8, 0x31,
                0x5F, 0x62, 0x5F, 0x60, 0x00, 0xD0, 0x32, 0xC8, 0x31, 0x5F, 0x62, 0x5F, 0x60, 0x00, 0xC0, 0x32,
                0xC0, 0x2F, 0x50, 0x60, 0x48, 0x60, 0x00, 0xC8, 0x2F, 0xC8, 0x33, 0x48, 0x62, 0x48, 0x60, 0x00,
                0xC8, 0x2C, 0xD0, 0x2C, 0x40, 0x60, 0x38, 0x60, 0x00, 0xD0, 0x30, 0xD0, 0x2D, 0x38, 0x62, 0x40,
                0x62, 0x00, 0xD0, 0x31, 0xC8, 0x34, 0x48, 0x62, 0x48, 0x60, 0x00, 0xC8, 0x30, 0xC0, 0x30, 0x40,
                0x60, 0x38, 0x61, 0x00, 0xB8, 0x30, 0xB0, 0x30, 0x38, 0x62, 0x40, 0x63, 0x00, 0xB0, 0x2C, 0xB0,
                0x30, 0x40, 0x60, 0x38, 0x61, 0x00, 0xB0, 0x36, 0xB0, 0x2C, 0x30, 0x60, 0x30, 0x62, 0x00, 0xB8,
                0x2C, 0xB8, 0x30, 0x38, 0x62, 0x38, 0x60, 0x00, 0xB8, 0x2C, 0xC0, 0x2C, 0x30, 0x60, 0x30, 0x62,
                0x00, 0xC8, 0x36, 0xC0, 0x30, 0x38, 0x62, 0x40, 0x5C, 0x00, 0xC0, 0x2C, 0xC8, 0x35, 0x38, 0x60,
                0x30, 0x61, 0x00, 0xC0, 0x30, 0xC0, 0x2C, 0x28, 0x5E, 0x28, 0x60, 0x00, 0xC0, 0x31, 0xB8, 0x30,
                0x28, 0x62, 0x30, 0x62, 0x00, 0xB0, 0x32, 0xB0, 0x36, 0x38, 0x62, 0x40, 0x62, 0x00, 0xB0, 0x2E,
                0xB8, 0x2D, 0x48, 0x62, 0x50, 0x62, 0x00, 0xC0, 0x2E, 0xC8, 0x2D, 0x5F, 0x62, 0x5F, 0x3A, 0x00,
                0xD0, 0x36, 0xD0, 0x36, 0x5F, 0x3A, 0x5F, 0x60, 0x01, 0xD0, 0x36, 0xD0, 0x36, 0x50, 0x3A, 0x50,
                0x3A, 0x02, 0xD0, 0x36, 0xD0, 0x36, 0x5F, 0x62, 0x5F, 0x3A, 0x01, 0xD0, 0x36, 0xD0, 0x36, 0x5F,
                0x3A, 0x5F, 0x3A, 0x02, 0xD0, 0x36, 0xD0, 0x2E, 0x5F, 0x3A, 0x5F, 0x3A, 0x00, 0xD8, 0x36, 0xD8,
                0x36, 0x5F, 0x3A, 0x5F, 0x60, 0x04, 0xD8, 0x36, 0xD8, 0x36, 0x50, 0x60, 0x48, 0x60, 0x04, 0xD0,
                0x32, 0xD0, 0x36, 0x40, 0x60, 0x38, 0x60, 0x00, 0xD0, 0x36, 0xD0, 0x36, 0x30, 0x3A, 0x30, 0x3A,
                0x01, 0xC8, 0x31, 0xC0, 0x32, 0x30, 0x3A, 0x30, 0x3A, 0x00, 0xC0, 0x36, 0xC0, 0x36, 0x30, 0x3A,
                0x30, 0x3A, 0x01, 0xB8, 0x31, 0xB0, 0x32, 0x30, 0x3A, 0x30, 0x60, 0x00, 0xB0, 0x36, 0xB0, 0x36,
                0x28, 0x3A, 0x28, 0x3A, 0x00, 0xB0, 0x36, 0xB0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xB0, 0x2E,
                0xB8, 0x2D, 0x30, 0x62, 0x30, 0x3A, 0x00, 0xC0, 0x36, 0xC0, 0x2E, 0x30, 0x3A, 0x30, 0x3A, 0x00,
                0xC8, 0x36, 0xC8, 0x36, 0x38, 0x62, 0x40, 0x62, 0x04, 0xC8, 0x36, 0xC8, 0x36, 0x48, 0x62, 0x48,
                0x3A, 0x01, 0xC8, 0x2E, 0xD0, 0x36, 0x48, 0x3A, 0x50, 0x62, 0x00, 0xD0, 0x36, 0xD0, 0x36, 0x5F,
                0x62, 0x5F, 0x3A, 0x04, 0xD0, 0x36, 0xD0, 0x2D, 0x5F, 0x3A, 0x5F, 0x60, 0x00, 0xD8, 0x36, 0xD8,
                0x36, 0x50, 0x60, 0x48, 0x60, 0x01, 0xD8, 0x36, 0xD8, 0x36, 0x40, 0x60, 0x38, 0x60, 0x02, 0xD0,
                0x31, 0xC8, 0x32, 0x30, 0x60, 0x28, 0x60, 0x00, 0xC0, 0x31, 0xB8, 0x30, 0x28, 0x62, 0x30, 0x62,
                0x00, 0xB0, 0x32, 0xB0, 0x36, 0x38, 0x62, 0x40, 0x62, 0x00, 0xB0, 0x2E, 0xB8, 0x2D, 0x48, 0x62,
                0x50, 0x62, 0x00, 0xC0, 0x2E, 0xC8, 0x2D, 0x5F, 0x62, 0x5F, 0x3A, 0x00, 0xD0, 0x36, 0xD0, 0x36,
                0x5F, 0x3A, 0x5F, 0x60, 0x01, 0xD0, 0x36, 0xD0, 0x36, 0x50, 0x3A, 0x50, 0x3A, 0x01, 0xD0, 0x36,
                0xD0, 0x36, 0x5F, 0x62, 0x5F, 0x3A, 0x02, 0xD0, 0x36, 0xD0, 0x36, 0x5F, 0x3A, 0x5F, 0x3A, 0x02,
                0xD0, 0x36, 0xD0, 0x2E, 0x5F, 0x3A, 0x5F, 0x3A, 0x00, 0xD8, 0x36, 0xD8, 0x36, 0x5F, 0x3A, 0x5F,
                0x60, 0x01, 0xD8, 0x36, 0xD8, 0x36, 0x50, 0x60, 0x48, 0x60, 0x01, 0xD0, 0x32, 0xD0, 0x36, 0x40,
                0x60, 0x38, 0x60, 0x00, 0xD0, 0x36, 0xD0, 0x36, 0x30, 0x3A, 0x30, 0x3A, 0x04, 0xC8, 0x31, 0xC0,
                0x32, 0x30, 0x3A, 0x30, 0x3A, 0x00, 0xC0, 0x36, 0xC0, 0x36, 0x30, 0x3A, 0x30, 0x3A, 0x01, 0xB8,
                0x31, 0xB0, 0x32, 0x30, 0x3A, 0x30, 0x60, 0x00, 0xB0, 0x36, 0xB0, 0x36, 0x28, 0x3A, 0x28, 0x3A,
                0x00, 0xB0, 0x36, 0xB0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xB0, 0x2E, 0xB8, 0x2D, 0x30, 0x62,
                0x30, 0x3A, 0x00, 0xC0, 0x36, 0xC0, 0x2E, 0x30, 0x3A, 0x30, 0x3A, 0x00, 0xC8, 0x36, 0xC8, 0x36,
                0x38, 0x62, 0x40, 0x62, 0x04, 0xC8, 0x36, 0xC8, 0x36, 0x48, 0x62, 0x48, 0x3A, 0x04, 0xC8, 0x2E,
                0xD0, 0x36, 0x48, 0x3A, 0x50, 0x62, 0x00, 0xD0, 0x36, 0xD0, 0x36, 0x5F, 0x62, 0x5F, 0x3A, 0x01,
                0xD0, 0x36, 0xD0, 0x2D, 0x5F, 0x3A, 0x5F, 0x60, 0x00, 0xD8, 0x36, 0xD8, 0x36, 0x50, 0x60, 0x48,
                0x60, 0x04, 0xD8, 0x36, 0xD8, 0x36, 0x40, 0x60, 0x38, 0x60, 0x04, 0xD0, 0x31, 0xC8, 0x32, 0x30,
                0x60, 0x28, 0x60, 0x00, 0xC8, 0x2C, 0xD0, 0x2C, 0x28, 0x62, 0x30, 0x62, 0x00, 0xD8, 0x2C, 0xE0,
                0x36, 0x38, 0x62, 0x40, 0x62, 0x00, 0xE0, 0x36, 0xE0, 0x36, 0x48, 0x62, 0x50, 0x62, 0x01, 0xE0,
                0x36, 0xD8, 0x34, 0x5F, 0x5C, 0x50, 0x60, 0x00, 0xE0, 0x36, 0xE0, 0x36, 0x48, 0x60, 0x40, 0x60,
                0x02, 0xE0, 0x36, 0xE0, 0x36, 0x38, 0x60, 0x30, 0x60, 0x01, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x5E,
                0x30, 0x62, 0x01, 0xD8, 0x34, 0xE0, 0x36, 0x36, 0x5C, 0x30, 0x60, 0x00, 0xE0, 0x36, 0xE0, 0x36,
                0x28, 0x5E, 0x30, 0x5C, 0x04, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x5E, 0x30, 0x62, 0x01, 0xE0, 0x36,
                0xE0, 0x36, 0x38, 0x62, 0x40, 0x62, 0x04, 0xD8, 0x30, 0xD0, 0x30, 0x48, 0x62, 0x57, 0x5C, 0x00,
                0xC8, 0x30, 0xC0, 0x30, 0x48, 0x60, 0x40, 0x60, 0x00, 0xB8, 0x30, 0xB0, 0x34, 0x38, 0x60, 0x30,
                0x60, 0x00, 0xB8, 0x2C, 0xC0, 0x2C, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xC8, 0x2C, 0xD0, 0x2C, 0x28,
                0x3A, 0x28, 0x3A, 0x00, 0xD8, 0x2C, 0xD8, 0x34, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xE0, 0x36, 0xE0,
                0x36, 0x28, 0x3A, 0x30, 0x5C, 0x01, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x02, 0xD8,
                0x30, 0xD0, 0x34, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xD8, 0x2C, 0xE0, 0x36, 0x28, 0x3A, 0x28, 0x3A,
                0x00, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x01, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x3A,
                0x28, 0x3A, 0x01, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x01, 0xE0, 0x36, 0xD8, 0x34,
                0x28, 0x3A, 0x28, 0x3A, 0x00, 0xE0, 0x36, 0xE0, 0x36, 0x28, 0x3A, 0x28, 0x3A, 0x04, 0xE0, 0x36,
                0xD8, 0x30, 0x28, 0x3A, 0x28, 0x3A, 0x00, 0xD0, 0x30, 0xC8, 0x30, 0x28, 0x3A, 0x28, 0x60, 0x00,
                0xFF
            };
        }
    }
}
