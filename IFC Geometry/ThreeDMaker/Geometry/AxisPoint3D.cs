﻿using System;
using System.Numerics;

namespace ThreeDMaker.Geometry 
{ 
    public class AxisPoint3D
    {
        public Vector3 Position { get; set; }
        public Vector3 Front { get; set; }
        public Vector3 Right { get; set; }
        public Vector3 Up { get; set; }
        public AxisPoint3D()
        {
            Position = new Vector3();
            Front = new Vector3(1, 0, 0);
            Right = new Vector3(0, 1, 0);
            Up = new Vector3(0, 0, 1);
        }

        public AxisPoint3D(Vector3 position, Vector3 front)
        {
            Position = position;
            Front = front;
            Right = GeometryUtil.GetRight(front);
            Up = Vector3.Normalize(Vector3.Cross(Right,front));
        }

        public Vector3 GetWorld(Vector3 local)
        {
            return local.X * Right + local.Y * Up + local.Z * Front + Position;
        }
        public Vector3 GetWorld(Vector2 local)
        {
            return local.X * Right + local.Y * Up + Position;
        }
    }
}