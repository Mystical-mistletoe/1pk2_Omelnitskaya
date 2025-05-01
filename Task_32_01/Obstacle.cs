using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Obstacle
    {
        public string Name { get; }
        public int Slowdown { get; }

        public Obstacle(string name, int slowdown)
        {
            Name = name;
            Slowdown = slowdown;
        }
    }
}
