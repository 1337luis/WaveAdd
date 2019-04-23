using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveAdd
{
    /*public string Code {
   get {
      return code;
   }
   set {
      code = value;
   }
}
*/
    public class Wave
    {
        
        public WaveOperation op;
        WaveType tp;
        double value;
        int duration;
        int delay;

        public WaveOperation Operation { get { return op; } set { op = value; } }
        public WaveType Type { get { return tp; } set { tp = value; } }
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

        public double GetValue()
        {
            return value;
        }

        public WaveOperation GetWaveOperation()
        {
            return op;
        }

        public WaveType GetWaveType()
        {
            return tp;
        }

        public int GetDelay()
        {
            return delay;
        }

        public int GetDuration()
        {
            return duration;
        }

        public void SetWaveType( WaveType tp ) 
        {
            this.tp = tp;
        }

        public void SetWaveOperaton( WaveOperation op )
        {
            this.op = op;
        }

        public void SetValue( double value )
        {
            this.value = value;
        }

        public void SetDuration( int duration ) 
        {
            this.duration = duration;
        }

        public void SetDelay( int delay ) 
        {
            this.delay = delay;
        }

        public double GetY( int x )
        {
            double result = 0;

            switch( tp )
            {
                case WaveType.sin:
                    result = GetValue() * Math.Sin( x );
                    break;
                case WaveType.cos:
                    result = GetValue() * Math.Cos( x );
                    break;
                case WaveType.asin:
                    result = GetValue() * Math.Asin( x );
                    break;
                case WaveType.acos:
                    result = GetValue() * Math.Acos( x );
                    break;
                case WaveType.tan:
                    result = GetValue() * Math.Tan( x );
                    break;
                case WaveType.atan:
                    result = GetValue() * Math.Atan( x );
                    break;
                case WaveType.abs:
                    result = GetValue() * Math.Abs( x );
                    break;
            }

            return result;
        }
    }
}
