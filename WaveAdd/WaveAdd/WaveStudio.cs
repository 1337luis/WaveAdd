using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            buffer = context.Allocate( resultCanvas.CreateGraphics(), this.DisplayRectangle );
            buffer.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void acercaDeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            About about = new About();
            about.ShowDialog();
        }

        private void valueBar_Scroll( object sender, EventArgs e )
        {
            valueNum.Value = valueBar.Value;
        }

        private void valueNum_ValueChanged( object sender, EventArgs e )
        {
            valueBar.Value = ( int )valueNum.Value;
        }

        private void valueDuration_CheckedChanged( object sender, EventArgs e )
        {
            durationNum.Enabled = valueDuration.Checked;
        }

        private void delayValue_CheckedChanged( object sender, EventArgs e )
        {
            delayNum.Enabled = delayValue.Checked;
        }

        private void addWaveButton_Click( object sender, EventArgs e )
        {
            Wave.WaveOperation wvo = subOperation.Checked ? Wave.WaveOperation.sub : Wave.WaveOperation.sum;
            Wave.WaveType wvt;
            double value = ( double )valueNum.Value;
            int delay = ( int )delayNum.Value;
            int duration = ( int )durationNum.Value;

            if( sinType.Checked )
            {
                wvt = Wave.WaveType.sin;
            }
            else if( cosType.Checked )
            {
                wvt = Wave.WaveType.cos;
            }
            else if( asinType.Checked )
            {
                wvt = Wave.WaveType.asin;
            }
            else if( acosType.Checked )
            {
                wvt = Wave.WaveType.acos;
            }
            else if( tanType.Checked )
            {
                wvt = Wave.WaveType.tan;
            }
            else if( atanType.Checked )
            {
                wvt = Wave.WaveType.atan;
            }
            else
            {
                wvt = Wave.WaveType.abs;
            }

            if( infiniteDuration.Checked && delayNo.Checked )
            {
                waves.Add( new Wave( wvo, wvt, value ) );
            }
            else if( infiniteDuration.Checked && !delayNo.Checked )
            {
                waves.Add( new Wave( wvo, wvt, value, int.MaxValue, delay ) );
            }
            else
            {
                waves.Add( new Wave( wvo, wvt, value, duration, delay ) );
            }

            wavesContainer.Controls.Add( new WaveDisplay( waves.Last<Wave>(), waves, 640, properties ) );
            redrawAll();
        }

        private void eliminarTodoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            waves.Clear();
            wavesContainer.Controls.Clear();
        }

        private void redrawAll()
        {
            var controls = wavesContainer.Controls;
            foreach( var c in controls )
            {
                ( ( WaveDisplay )c ).renderWave();
            }

            buffer.Graphics.Clear( Color.FromArgb( 49, 49, 55 ) );
            buffer.Graphics.DrawLine( new Pen( Color.Gold, 2 ), 0, resultCanvas.Height / 2, resultCanvas.Width, resultCanvas.Height / 2 );

            if( waves.ToArray().Length > 0 )
            {
                List<PointF> points = new List<PointF>();
                for( float x = 0; x < ( float )resultCanvas.Width; x += 0.1f )
                {
                    float pX = 0;
                    foreach( Wave w in waves )
                    {
                        pX += ( w.GetWaveOperation() == Wave.WaveOperation.sum ? ( float )w.GetY( x ) : -1.0f * ( float )w.GetY( x ) );
                    }
                    points.Add( new PointF( x, pX ) );
                }

                if( points.ToArray().Length > 1 )
                    buffer.Graphics.DrawLines( new Pen( Color.Aquamarine, 2 ), points.ToArray() );

                buffer.Render();
            }
        }

        private void redrawToolStripMenuItem_Click( object sender, EventArgs e )
        {
            redrawAll();
        }

        private void WaveStudio_ResizeEnd( object sender, EventArgs e )
        {
            redrawAll();
        }

        private void wavesContainer_SizeChanged( object sender, EventArgs e )
        {
            redrawAll();
        }

        private void wavesContainer_Scroll( object sender, ScrollEventArgs e )
        {
            redrawAll();
        }

        private void wavesContainer_Paint( object sender, PaintEventArgs e )
        {
            redrawAll();
        }

        private void properties_PropertyValueChanged( object s, PropertyValueChangedEventArgs e )
        {
            redrawAll();
        }
    }
}
