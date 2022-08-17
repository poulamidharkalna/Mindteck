using System;
namespace Delegate
{
    class poulami
    {
        public delegate void poulamidelegate(string name);
        public delegate void Multidelegate(int x, int y);
        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);

        }
        public void name(string name)
        {
            Console.WriteLine("my name is" + " " + name);

        }
        static void Main(string[] args)
        {
            poulami d = new poulami();
            poulamidelegate obj1 = new poulamidelegate(d.name);
            Multidelegate obj2 = new Multidelegate(d.Multi);
            obj1("Poulami");
            obj2(20, 20);

        }

    }

}