using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Angle
{
    public class Angle
    {
        public enum AngleTypeEnum 
        {
            RAD,
            DEG
        }
        protected double _angle { get; set; }

        public AngleTypeEnum Type { get; set; }

        public Angle(double angle, AngleTypeEnum angleType)
        {
            _angle = angle;
            this.Type = angleType;
        }

        public double 
    }
}
