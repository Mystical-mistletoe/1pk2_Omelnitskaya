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
            for (int i = 1; i < height+1; i++)
            {
                for (int j = 1; j < width+1; j++)
                {
                    if (j <= (int)(((double)i / height) * width))
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
