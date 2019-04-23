using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WaveAdd
{
    public partial class WaveDisplay : UserControl
    {
        public BufferedGraphics buffer;
        BufferedGraphicsContext context;
        PropertyGrid prop;
        List<Wave> waves;
        Wave wv;
        private Color[] colors = { Color.DarkViolet, Color.DodgerBlue, Color.OrangeRed, Color.DarkKhaki, Color.Red, Color.DarkSeaGreen };
        private Color color { get; set; }
        public WaveDisplay()
        {
            InitializeComponent();
        }

        public WaveDisplay( Wave wv, List<Wave> list, int width = 750, PropertyGrid prop = null )
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate( waveCanvas.CreateGraphics(), new Rectangle( 0, 0, waveCanvas.Width * 2, waveCanvas.Height * 2 ) );
            buffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            waves = list;
            this.wv = wv;
            this.Width = width;
            this.prop = prop;
            color = colors[ new Random().Next( colors.Length ) ];
        }

        public BufferedGraphics getCanvas()
        {
            return buffer;
        }

        public void renderWave()
        {
            buffer.Graphics.Clear( Color.FromArgb( 49, 49, 55 ) );
            buffer.Graphics.DrawLine( new Pen( Color.Gold, 2 ), 0, this.Height / 2, this.Width, this.Height / 2 );
            List<PointF> points = new List<PointF>();
            for( float x = wv.Delay; x < this.Width; x+=0.1f )
            {
                points.Add( new PointF( x, (float)wv.GetY( x ) ) );
            }
            buffer.Graphics.DrawLines( new Pen( color, 2 ), points.ToArray() );
            buffer.Render();
        }

        private void deleteWave_Click( object sender, EventArgs e )
        {
            this.Parent.Controls.Remove( this );
            waves.Remove( wv );
        }

        private void editWave_Click( object sender, EventArgs e )
        {
            prop.SelectedObject = wv;
        }

        private void waveCanvas_Click( object sender, EventArgs e )
        {
            new Viewer( wv ).ShowDialog();
        }
    }
}
