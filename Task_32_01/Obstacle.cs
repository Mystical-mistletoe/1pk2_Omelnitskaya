using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public interface Obstacle
    {
        string Name { get; }
        int SlowGO { get; }
    }

    public class Ravine : Obstacle
    {
        public string Name
        {
            get { return "Овраг"; }
        }

        public int SlowGO
        {
            get { return 5; }
        }
    }

    public class Grass : Obstacle
    {
        public string Name
        {
            get { return "Высокая трава"; }
        }

        public int SlowGO
        {
            get { return 3; }
        }
    }
}
