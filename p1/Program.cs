using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathOp f = Add;
            //Console.WriteLine(f(12,14));
            // CalculateAndPrint(10, 10, Add);
            //-->
            /* CalculateAndPrint(10,20, delegate(int x, int y)
             {
                 return x + y;
             });*/
            //--->
            // CalculateAndPrint(10, 10, (int x,int  y) => x + y);
            //--->
            // CalculateAndPrint(10, 10, (x, y) => x + y);

            // CalculateAndPrint("x","y",(a,b)=>a+b);
            //CalculateAndPrint(false,true,(x,y)=>x&&y);
            //CalculateAndPrint(10.5,10.5,(a,b)=>a-b);
            //CalculateAndPrint(11,10,(a,b)=>a-b);


            /* var Persons = new List<Person>
             {
                 new Person("Hello","Hi","bye"),
                 new Person("Hello1","Hi1","bye1"),
                 new Person("Hello2","Hi2","bye2"),
                 new Person("Hello3","Hi3","bye3"),
                 new Person("Hello4","Hi4","bye4"),
                 new Person("Hello5","Hi5","bye5"),
             };
             foreach (var p in Persons)
             {
                 Console.WriteLine(p.Name);
             }*/



            var Heros = new List<Hero>
            {

                new Hero("F1", "L1", "H1", true),
                new Hero("F2", "L2", "H2", false),
                new Hero("F3", "L3", "H3", true),
                new Hero(string.Empty, "L4", "H4", false),
                new Hero("F5", "L5","H4", true),
                new Hero(string.Empty, "L6", "H6", false)
            };

           var x= filter(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, a => a % 2 == 0);
           Console.WriteLine(x);

            var HerosCanflyHeros = filter(Heros, h => h.canFly);
            var varEmptyFirstNameHeros = filter(Heros, h => string.IsNullOrEmpty(h.firstName));
            Console.WriteLine(HerosCanflyHeros.Count());
            /* replace with yeild
            IEnumerable<Hero> filterHeros(IEnumerable<Hero> Heros, filter f)
            {
                var result=new List<Hero>();
                foreach (var hero in Heros)
                {
                    if (f(hero))
                    {
                        result.Add(hero);
                    }
                }

                return result;
            }*/

            /* replace it with filter generics Type
            IEnumerable<Hero> filterHeros(IEnumerable<Hero> Heros, filter f)
            {
               
                foreach (var hero in Heros)
                {
                    if (f(hero))
                    {
                        yield return hero;
                    }
                }

            }*/

            //also use as linq : Where
            IEnumerable<T> filter<T>(IEnumerable<T> items, Func<T,bool> f)
            {

                foreach (var item in items)
                {
                    if (f(item))
                    {
                        yield return item;
                    }
                }

            }

        }
        //we use func<T ,bool> f
        //delegate bool filter<T>(T h);


        // delegate int MathOp(int x, int y);

        delegate T Combine<T>(T a, T b);

        static void CalculateAndPrint<T>(T x, T y, Combine<T> f)
        {
            Console.WriteLine(f(x,y));
        }

       /* static void CalculateAndPrint(int x,int y, MathOp f)
        {
            var result = f(x, y);
            Console.WriteLine(result);
        }*/

        static int Add(int x,int y)
        {
            return x + y;
        }

        static int Sub(int a,int b)
        {
            return a - b;
        }

    }
}