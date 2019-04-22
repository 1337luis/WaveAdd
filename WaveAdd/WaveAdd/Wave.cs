using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveAdd
{
    class Wave
    {
        WaveOperation op;
        WaveType tp;
        double value;
        int duration;
        int delay;

        public enum WaveOperation
        {
            sum = 0,
            sub
        }

        public enum WaveType
        {
            sin = 0,
            cos,
            asin,
            acos,
            tan,
            atan,
            abs
        }

        public Wave( WaveOperation op, WaveType tp, double value, int duration = int.MaxValue, int delay = 0  )
        {
            this.op = op;
            this.tp = tp;
            this.value = value;
            this.duration = duration;
            this.delay = delay;
        }

        public double getValue()
        {
            return value;
        }

        public WaveOperation getWaveOperation()
        {
            return op;
        }

        public WaveType getWaveType()
        {
            return tp;
        }

        public int getDelay()
        {
            return delay;
        }

        public int getDuration()
        {
            return duration;
        }

        public void setWaveType( WaveType tp ) 
        {
            this.tp = tp;
        }

        public void setWaveOperaton( WaveOperation op )
        {
            this.op = op;
        }

        public void setValue( double value )
        {
            this.value = value;
        }

        public void setDuration( int duration ) 
        {
            this.duration = duration;
        }

        public void setDelay( int delay ) 
        {
            this.delay = delay;
        }

        public double getY( int x )
        {
            double result = 0;

            switch( tp )
            {
                case WaveType.sin:
                    result = getValue() * Math.Sin( x );
                    break;
                case WaveType.cos:
                    result = getValue() * Math.Cos( x );
                    break;
                case WaveType.asin:
                    result = getValue() * Math.Asin( x );
                    break;
                case WaveType.acos:
                    result = getValue() * Math.Acos( x );
                    break;
                case WaveType.tan:
                    result = getValue() * Math.Tan( x );
                    break;
                case WaveType.atan:
                    result = getValue() * Math.Atan( x );
                    break;
                case WaveType.abs:
                    result = getValue() * Math.Abs( x );
                    break;
            }

            return result;
        }
    }
}
