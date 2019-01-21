﻿using OpenCvSharp;

namespace BarrierX_NagiBot
{
    class GameObject
    {
        enum ObjectType : byte { unknown = 1, wall, player, enemy, timer,  };

        public Mat contour;
        public double area;
        public Mat points_approx; // точки контура
        public Point center;
        public double ratio; // width / height to skip lines
        ObjectType type = ObjectType.unknown;

        public GameObject() { }

        public GameObject(Mat contour1, double area1, Mat points_approx1, Point center1, double ratio1) {
            contour = contour1;
            area = area1;
            points_approx = points_approx1;
            center = center1;
            ratio = ratio1;
        }
    }
}
