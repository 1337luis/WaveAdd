using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveAdd
{
    public partial class WaveStudio : Form
    {
        public List<Wave> waves = new List<Wave>();
        BufferedGraphicsContext context;
        BufferedGraphics buffer;
        public WaveStudio()
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate(resultCanvas.CreateGraphics(), this.DisplayRectangle);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void valueBar_Scroll(object sender, EventArgs e)
        {
            valueNum.Value = valueBar.Value;
        }

        private void valueNum_ValueChanged(object sender, EventArgs e)
        {
            valueBar.Value = ( int )valueNum.Value;
        }

        private void valueDuration_CheckedChanged(object sender, EventArgs e)
        {
            durationNum.Enabled = valueDuration.Checked;
        }

        private void delayValue_CheckedChanged(object sender, EventArgs e)
        {
            delayNum.Enabled = delayValue.Checked;
        }

        private void addWaveButton_Click(object sender, EventArgs e)
        {
            Wave.WaveOperation wvo = subOperation.Checked ? Wave.WaveOperation.sub : Wave.WaveOperation.sum;
            Wave.WaveType wvt;
            double value = ( double )valueNum.Value;
            int delay = ( int )delayNum.Value;
            int duration = ( int )durationNum.Value;

            if ( sinType.Checked )
            {
                wvt = Wave.WaveType.sin;
            } else if( cosType.Checked )
            {
                wvt = Wave.WaveType.cos;
            }
            else if (asinType.Checked)
            {
                wvt = Wave.WaveType.asin;
            }
            else if (acosType.Checked)
            {
                wvt = Wave.WaveType.acos;
            }
            else if (tanType.Checked)
            {
                wvt = Wave.WaveType.tan;
            }
            else if (atanType.Checked)
            {
                wvt = Wave.WaveType.atan;
            } else {
                wvt = Wave.WaveType.abs;
            }

            if( infiniteDuration.Checked && delayNo.Checked )
            {
                waves.Add(new Wave(wvo, wvt, value, duration, delay));
            } else if( infiniteDuration.Checked && !delayNo.Checked )
            {
                waves.Add(new Wave(wvo, wvt, value, duration));
            } else
            {
                waves.Add(new Wave( wvo, wvt, value ));
            }

                wavesContainer.Controls.Add(new WaveDisplay(waves.Last<Wave>(), waves, 640, properties));
            
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waves.Clear();
            wavesContainer.Controls.Clear();
        }

        private void redrawAll()
        {
            var controls = wavesContainer.Controls;
            foreach( var c in controls )
            {
                ((WaveDisplay)c).renderWave();
            }
        }

        private void redrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redrawAll();
        }
    }
}
