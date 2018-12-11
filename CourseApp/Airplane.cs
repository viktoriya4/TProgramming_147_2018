using System;

namespace Samolet
{
    public class Airplane
    {
        private string name;
        private int speed;

        public Airplane(int speed, string name)
        {
            this.name = name;
            this.speed = speed;
        }

        public Airplane(int speed)
        {
            this.name = "Noname";
            this.speed = speed;
        }

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

        public string GetInfo()
        {
            return $"Имя: {name}  Скорость: {speed}";
        }

        public void GetInfo2()
        {
            Console.WriteLine($"Скорость: {speed}");
        }
    }
}
