using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleLandscapeDecode
{
    public class LandscapeDecoder
    {
        private readonly byte[] _landScape;

        public LandscapeDecoder(ILandscape landscape)
        {
            if (landscape == null) throw new ArgumentNullException(nameof(landscape));

            _landScape = landscape.GetLandScape();
        }

        public LandScapeInfo? Decode(int index)
        {
            if (index+6 >= _landScape.Length)
                return null;

            int IY = index;

            var landScapeInfo = new LandScapeInfo();

            // Code roughly corresponds to DECODE_LANDSCAPE_FLOOR
            byte A;


            A = (byte)(_landScape[IY + 2] &0xF8);
            A = (byte)(A / 8);
            landScapeInfo.LANDSCAPE_GROUND_SECOND_CHAR_PTR = A;

            A = (_landScape[IY + 3]);
            landScapeInfo.LANDSCAPE_GROUND_SECOND_CHAR = A;

            A = (byte)(_landScape[IY + 0] & 0xF8);
            A = (byte)(A / 8);
            landScapeInfo.LANDSCAPE_GROUND_FIRST_CHAR_PTR = A;
            
            A = (_landScape[IY + 1]);
            landScapeInfo.LANDSCAPE_GROUND_FIRST_CHAR = A;

            A = (_landScape[IY + 4]);
            landScapeInfo.HasCeiling = A != 0;

            if (!landScapeInfo.HasCeiling)
            {
                landScapeInfo.SizeOf = 6;
            }
            else
            {
                landScapeInfo.SizeOf = 9;
            }

            if (landScapeInfo.HasCeiling)
            {
                landScapeInfo.NEXT_GROUND_OBJECT_ID = _landScape[IY + 8];
            }
            else
            {
                landScapeInfo.NEXT_GROUND_OBJECT_ID = _landScape[IY + 5];
            }
            

            if (!landScapeInfo.HasCeiling)
            {
                return landScapeInfo;
            }

            // Now do the ceiling
            A = (byte)(_landScape[IY + 6] & 0xF8);
            A = (byte)(A / 8);
            landScapeInfo.LANDSCAPE_CEILING_SECOND_CHAR_PTR = A;

            A = (_landScape[IY + 7]);
            landScapeInfo.LANDSCAPE_CEILING_SECOND_CHAR = A;

            A = (byte)(_landScape[IY + 4] & 0xF8);
            A = (byte)(A / 8);
            landScapeInfo.LANDSCAPE_CEILING_FIRST_CHAR_PTR = A;

            A = (_landScape[IY + 5]);
            landScapeInfo.LANDSCAPE_CEILING_FIRST_CHAR = A;

            return landScapeInfo;
        }





    }


}
