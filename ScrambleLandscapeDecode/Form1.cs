using System.Diagnostics.CodeAnalysis;
using ScrambleLandscapeDecode.Landscapes;

namespace ScrambleLandscapeDecode
{
    public partial class Form1 : Form
    {
        private const int CEILING_SUBTRAHEND = 5;
        private const int FLOOR_MINUEND = 29;

        private const int ROCKET = 1;
        private const int FUEL_TANK = 2;
        private const int MYSTERY = 4;
        private const int BASE = 8;

        private LandscapeDecoder _decoder;


        public Form1()
        {
            InitializeComponent();

            // For you TODO: Replace Landscape1 with Landscape2, 3, 4, 5..
            _decoder = new LandscapeDecoder(new Landscape1());
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int offset = 0;
            int plotAtX = 0;

            var graphics = e.Graphics;

            var info = _decoder.Decode(offset);
            while (info != null)
            {
               
                int groundY1 = info.LANDSCAPE_GROUND_FIRST_CHAR_PTR * 8;
                graphics.FillRectangle(Brushes.White, plotAtX, groundY1, 8, 8);

                int groundY2 = info.LANDSCAPE_GROUND_SECOND_CHAR_PTR * 8;
                graphics.FillRectangle(Brushes.White, plotAtX + 8, groundY2, 8, 8);

                if (info.NEXT_GROUND_OBJECT_ID != 0)
                {
                    Brush objectBrush = Brushes.Black;
                    var widthInPixels = 8;
                    switch (info.NEXT_GROUND_OBJECT_ID)
                    {
                        case ROCKET:
                            objectBrush = Brushes.Red;
                            break;
                        case FUEL_TANK:
                            objectBrush = Brushes.Blue;
                            widthInPixels = 16;
                            break;
                        case MYSTERY:
                            objectBrush = Brushes.Green;
                            widthInPixels = 16;
                            break;
                        case BASE:
                            objectBrush = Brushes.Yellow;
                            widthInPixels = 16;
                            break;
                    }
                    graphics.FillRectangle(objectBrush, plotAtX, groundY1-16, widthInPixels, 16);
                }

                if (info.HasCeiling)
                {
                    int ceilingY1 = info.LANDSCAPE_CEILING_FIRST_CHAR_PTR * 8;
                    graphics.FillRectangle(Brushes.White, plotAtX, ceilingY1, 8, 8);

                    int ceilingY2 = info.LANDSCAPE_CEILING_SECOND_CHAR_PTR * 8;
                    graphics.FillRectangle(Brushes.White, plotAtX + 8, ceilingY2, 8, 8);
                }

                offset += info.SizeOf;
                info = _decoder.Decode(offset);
                plotAtX += 16;
            }


        }
    }
}