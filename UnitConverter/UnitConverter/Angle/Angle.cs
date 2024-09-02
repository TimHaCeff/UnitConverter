using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Angle
    {
        public enum AngleTypeEnum 
        {
            RAD,
            DEG
        }
        protected double _angle { get; set; }

        public AngleTypeEnum? Type { get; set; } = null;

        public Angle(double angle, AngleTypeEnum angleType)
        {
            _angle = angle;
            this.Type = angleType;
        }

        public double ToDeg()
        {
            if(this.Type == AngleTypeEnum.DEG || this.Type == null) 
            {
                throw new Exception();
            }
            return _angle * Math.PI/180;
        }

        public double ToRad() 
        {
            if (this.Type == AngleTypeEnum.RAD || this.Type == null)
            {
                throw new Exception();
            }

            return _angle * 180 / Math.PI;
        }
    }
}
