using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxTriangle.Models
{
    public class Triangle
    {
        public Triangle()
        {
        }

        public Triangle(int? a, int? b, int? c)
        {
            mSideA = a;
            mSideB = b;
            mSideC = c;
        }

        private int? mSideA = null;
        private int? mSideB = null;
        private int? mSideC = null;
        public int? SideA { get { return mSideA; } }
        public int? SideB { get { return mSideB; } }
        public int? SideC { get { return mSideC; } }

        private int getInt(int? x)
        {
            return (x == null) ? 0 : x.Value;

        }

        public int Perimeter
        {
            get
            {
                return getInt(SideA) + getInt(SideB) + getInt(SideC);
            }
        }

        public double Area
        {
            get
            {
                double h = (getInt(SideA) + getInt(SideB) + getInt(SideC)) / 2.0;
                double t = (h - getInt(SideA)) * (h - getInt(SideB)) * (h - getInt(SideC)) * h;
                if (t < 0)
                    return -1;
                return Math.Sqrt(t);
            }
        }
    }
}