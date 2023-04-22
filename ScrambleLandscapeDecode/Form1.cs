using System.Diagnostics.CodeAnalysis;

namespace ScrambleLandscapeDecode
{
    public partial class Form1 : Form
    {
        private LandscapeDecoder _decoder;


        public Form1()
        {
            InitializeComponent();
            _decoder = new LandscapeDecoder();
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