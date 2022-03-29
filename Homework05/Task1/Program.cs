using Task1.Models;
using System;

namespace Task1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangleInfo = new Rectangle();

            rectangleInfo.Position = new int[] { 5, 100 };
            rectangleInfo.SideA = 3;
            rectangleInfo.SideB = 9;
            rectangleInfo.Name = "Rectangle";
            rectangleInfo.Color = "Red";

            rectangleInfo.Move();
            rectangleInfo.GetArea();
            rectangleInfo.GetPerimeter();

            Circle circleInfo = new Circle();

            circleInfo.Position = new int[] { 15, 20 };
            circleInfo.Radius = 6;
            circleInfo.Name = "Circle";
            circleInfo.Color = "Blue";

            circleInfo.Move();
            circleInfo.GetArea();
            circleInfo.GetPerimeter();
            
        }
    }
}
