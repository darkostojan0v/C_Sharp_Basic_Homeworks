

using System;

namespace Task1.Models
{
    public class Shape
    {
        public string name;
        public string color;

        public int[] Position { get; set; }
        

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public virtual void GetPerimeter() 
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public Shape()
        {
        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(value == "Rectangle" || value == "Circle")
                {
                    name = value;
                    Console.WriteLine($"Creating a {Name}");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if(value == "Red" || value == "Blue" || value == "Green")
                {
                    color = value;
                    Console.WriteLine($"With {Color} color");
                }
                else
                {
                    color = null;
                }
            }
        }

        public virtual void Move()
        {
            int[] updatedPositions = new int[0];
            int index = 0;

            foreach (int coordinates in Position)
            {
                Array.Resize(ref updatedPositions, updatedPositions.Length + 1);
                updatedPositions[index] = coordinates + 5;
                index++;
            }

            for (int i = 0; i < updatedPositions.Length; i++)
            {
                Console.WriteLine($"At position: {updatedPositions[0]}, {updatedPositions[1]}");
                break;
            }
        }

    }
}
