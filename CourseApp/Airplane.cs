using System;

    namespace Samolet
{
    public class Airplane

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
        set => speed = value;
        }
   
    public Airplane(int speed, string name)
        { 
        this.name = name;
        this.speed = speed;
        }

        public void GetInfo()
        {
        Console.WriteLine($"Имя: {name}  Скорость: {speed}");
        }
        static void Main(string[] args)
        {
        Airplane airplane = new Airplane(870, "samoletik");
        airplane.GetInfo();
        Console.ReadKey();
        }
    }

}