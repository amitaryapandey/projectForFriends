using System;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Amit123
    {
        public bool Sumit()
        {
            var response = "123";
            return response.Contains("123");
        }
    }

    public class Add
    {
        public int Addition(int a, int b)
        {
            var add = a + b;

            return add;
        }
    }
    public class Amit
    {
        static void Main(string[] args)
        {
            var obj = new Amit123();
            var qwe = new Add();
            var ewq = qwe.Addition(2, 4);
            var ab = obj.Sumit();
            Console.WriteLine(ab);
            Console.WriteLine(ewq);
            Console.ReadKey();
        }
    }
}
