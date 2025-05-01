using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_01
{
    internal class Rectangle : IDrawable
    {
        //самостоятельно прописатьтреугольник и его логику рисования в консоли
        //для упрощения  - прямугольный треугольник
        private int width;
        private int height;
        public int Width
        {
            get => width;
            set
            {
                if (value > 1)
                    width = value;
                else
                    throw new ArgumentException("ширина не должна быть меньше или равна 1");
            }
        }
        public int Height
        {
            get => height;
            set
            {
                if (value > 1)
                    height = value;
                else
                    throw new ArgumentException("высота не должна быть меньше или равна 1");
            }
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            
            Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j * height < width * (i + 1))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
