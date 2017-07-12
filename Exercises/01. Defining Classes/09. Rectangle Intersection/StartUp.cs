﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    class StartUp
    {
        static void Main()
        {
            var rectangles = new Dictionary<string, Rectangle>();

            var inputInfo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputInfo[1]; i++)
            {
                var rectangleInfo = Console.ReadLine().Split(' ');
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var topLeftHoriz = double.Parse(rectangleInfo[3]);
                var topLeftVert = double.Parse(rectangleInfo[4]);

                var rectangle = new Rectangle(id, width, height, topLeftHoriz, topLeftVert);
                rectangles[id] = rectangle;
            }

            for (int i = 0; i < inputInfo[1]; i++)
            {
                var checkIDs = Console.ReadLine().Split(' ');
                var result = rectangles[checkIDs[0]].InteresectWith(rectangles[checkIDs[1]]);
                Console.WriteLine(result.ToString().ToLower());
            }
        }
    }
}
