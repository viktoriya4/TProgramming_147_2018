using System;

namespace CourseApp
{
    public class Airplane : Vehicle
    {
        public Airplane(int speed, string name)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public Airplane(int speed)
            : this(speed, "Noname")
        {
        }

        public string GetInfo()
        {
            return $"Имя: {this.Name}  Скорость: {this.Speed}";
        }
    }
}
