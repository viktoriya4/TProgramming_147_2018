using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Vehicle
    {
        private string name;
        private int speed;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Speed
        {
            get => speed;
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
        }
    }
}
