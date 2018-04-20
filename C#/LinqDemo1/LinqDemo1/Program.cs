using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] developers = new Employee[]
                {
                    new Employee{Id=1, Name= "Sachin" },
                    new Employee{ Id=2, Name= "Sachi"}
                };

            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id=3, Name="Drushil"},
                    new Employee {Id=4, Name="Rachana"}
            };

            //Method Query

            var q1 = developers.Where(e => e.Name.Length == 5).OrderBy(e => e.Id);
            

            //Syntax QUery

            var fildev =
                            from developer in developers
                            where developer.Name.StartsWith("S") && developer.Name.Length < 6
                            orderby developer.Id
                            select developer;

         
            foreach(var dev in fildev)
            {
                Console.WriteLine("Developer:{0}", dev.Name);
            }


            //================================Movie LINQ query======

            List<Movie> movies = new List<Movie>
            {
                new Movie{Title = "Hum Apake hai kaun",year=1998,rating=7.8 },
                new Movie{ Title = "Hum",year=1999,rating=8.0 },
                new Movie{ Title = "Roja",year=2002,rating=7.8 }
            };

            var query = movies.Where(m => m.year < 2000);

            foreach (var m in query)
            {
                Console.WriteLine(m.Title);
            }



            Console.ReadKey();
        }
    }
}
