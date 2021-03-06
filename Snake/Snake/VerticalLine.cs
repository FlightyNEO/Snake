﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            plist = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }

        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
