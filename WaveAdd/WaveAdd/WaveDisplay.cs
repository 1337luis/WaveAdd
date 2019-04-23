using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public WaveDisplay()
        {
            InitializeComponent();
        }

        public WaveDisplay( Wave wv, List<Wave> list, int width = 750, PropertyGrid prop = null )
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate( waveCanvas.CreateGraphics(), new Rectangle( 0, 0, waveCanvas.Width * 2, waveCanvas.Height * 2 ) );
            waves = list;
            this.wv = wv;
            this.Width = width;
            this.prop = prop;
        }

        public BufferedGraphics getCanvas()
        {
            return buffer;
        }

        public void renderWave()
        {
            buffer.Graphics.Clear(Color.FromArgb(49, 49, 55));
            buffer.Graphics.DrawLine(new Pen(Color.Gold, 2), 0, this.Height / 2, this.Width, this.Height / 2);

            buffer.Render();
        }

        private void deleteWave_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            waves.Remove(wv);
        }

        private void editWave_Click(object sender, EventArgs e)
        {
            prop.SelectedObject = wv;
        }
    }
}
