﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;
        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;


        }
        public MyCircle() : this(Color.Blue, 50)
        {

        }
        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }
        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X - 2, Y - 2, Radius + 4);
        }
        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInCircle(pt, SplashKit.CircleAt(X, Y, Radius));

        }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
    }
}

