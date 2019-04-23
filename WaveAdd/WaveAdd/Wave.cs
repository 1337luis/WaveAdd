using System;

namespace WaveAdd
{
    public class Wave
    {
        public WaveOperation Operation { get; set; }
        public WaveType Type { get; set; }
        public double Value { get; set; }
        public int Duration { get; set; }
        public int Delay { get; set; }
        public int periodo { get; set; }

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

        public Wave( WaveOperation op, WaveType tp, double value, int duration = int.MaxValue, int delay = 0 )
        {
            this.Operation = op;
            this.Type = tp;
            this.Value = value;
            this.Duration = duration;
            this.Delay = delay;
            this.periodo = 2;
        }

        public double GetValue()
        {
            return Value;
        }

        public WaveOperation GetWaveOperation()
        {
            return Operation;
        }

        public WaveType GetWaveType()
        {
            return Type;
        }

        public int GetDelay()
        {
            return Delay;
        }

        public int GetDuration()
        {
            return Duration;
        }

        public void SetWaveType( WaveType tp )
        {
            this.Type = tp;
        }

        public void SetWaveOperaton( WaveOperation op )
        {
            this.Operation = op;
        }

        public void SetValue( double value )
        {
            this.Value = value;
        }

        public void SetDuration( int duration )
        {
            this.Duration = duration;
        }

        public void SetDelay( int delay )
        {
            this.Delay = delay;
        }

        public double GetY( float x )
        {
            double result = 0;

            switch( Type )
            {
                case WaveType.sin:
                    result = GetValue() * Math.Sin( x / periodo );
                    break;
                case WaveType.cos:
                    result = GetValue() * Math.Cos( x / periodo );
                    break;
                case WaveType.asin:
                    result = periodo * Math.Asin( x / GetValue() );
                    break;
                case WaveType.acos:
                    result = periodo * Math.Acos( x / GetValue() );
                    break;
                case WaveType.tan:
                    result = GetValue() * Math.Tan( x / periodo );
                    break;
                case WaveType.atan:
                    result = GetValue() * Math.Atan( x / periodo );
                    break;
                case WaveType.abs:
                    result = periodo * Math.Abs( x / GetValue() );
                    break;
            }

            return result;
        }
    }
}
