using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implicit Typing 
namespace LamdaExpressionDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            //var
            var s = "sachin";
            var i = 10;
            var d = 3.4;
            Console.WriteLine("{0},{1},{2}", s, 1, d);



           Func<int,int> square = x => x * x;

            Func<int, int, int> sum = (x, y) =>
             {
                 int z;
                 z = x + y;
                 return z;
             };

            //when no parameter or no return type then use Action
            Action greet1 = () => Console.WriteLine("Hello*World");

            Action <String> greet = x =>
            {
                if(x.Length >0)
                Console.WriteLine("Hello {0}", x);
                else
                    Console.WriteLine("Hello World");
            };
            Console.WriteLine(square(5));
            Console.WriteLine(sum(4, 5));
            greet("Sachin");
            greet("");
            greet1();


            SayHelloWithAddion(x =>
            {
                if (x.Length > 0)
                    Console.WriteLine("Hello {0}", x);
                else
                    Console.WriteLine("Hello World");
            });



        }

        private static void SayHelloWithAddion(Action<String> will)
        {
            will(" Rangoon");
            Console.ReadKey();
        }
    }
}
