using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleLandscapeDecode
{
    public class LandScapeInfo
    {

        public byte SizeOf { get; set; }
        public byte LANDSCAPE_GROUND_SECOND_CHAR_PTR { get; set; }
        public byte LANDSCAPE_GROUND_SECOND_CHAR { get; set; }
        public byte LANDSCAPE_GROUND_FIRST_CHAR_PTR { get; set; }
        public byte LANDSCAPE_GROUND_FIRST_CHAR { get; set; }
        public byte NEXT_GROUND_OBJECT_ID { get; set; }

        public bool HasCeiling { get; set; }

        public byte LANDSCAPE_CEILING_SECOND_CHAR_PTR { get; set; }
        public byte LANDSCAPE_CEILING_SECOND_CHAR { get; set; }
        public byte LANDSCAPE_CEILING_FIRST_CHAR_PTR { get; set; }
        public byte LANDSCAPE_CEILING_FIRST_CHAR { get; set; }

    }
}
