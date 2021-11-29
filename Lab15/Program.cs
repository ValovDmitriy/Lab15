using System;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression one = new ArithProgression(5);
            one.setStart(5);
            one.getNext();
            one.reset();
            GeomProgression two = new GeomProgression(5);
            two.setStart(5);
            two.getNext();
            two.reset();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int x;

        public ArithProgression(int x)
        {
            this.x = x;
        }

        public int getNext()
        {
                int y;
                y =x +1;
            Console.WriteLine("Следующее число ряда: {0}",y);
            return y;
        }
        public void reset()
        {
            Console.WriteLine("Сброс к начальному значению {0}",x);
        }

        public void setStart(int x)
        {
            Console.WriteLine("Начальное значение арифмитической прогресии:{0}",x);
            return;
        }
    }
    class GeomProgression : ISeries
    {
        int x;

        public GeomProgression(int x)
        {
            this.x = x;
        }
        public int getNext()
        {
            int y;
            y = x *2;
            Console.WriteLine("Следующее число ряда: {0}", y);
            return y;
        }

        public void reset()
        {
            Console.WriteLine("Сброс к начальному значению {0}", x);
        }

        public void setStart(int x)
        {
            Console.WriteLine("Начальное значение геометрической прогресии:{0}", x);
            return;
        }
    }
}
