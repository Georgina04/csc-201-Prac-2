using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs2;

namespace Prac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DoubleVector man = new DoubleVector(100000);
            DoubleList man1 = new DoubleList();
            DoubleVector man2 = new DoubleVector(100000);
            DoubleList man3 = new DoubleList();
            DoubleVector result = new DoubleVector(100000);
            DoubleList result1 = new DoubleList();


            //PLEASE UNCOMMENT EACH STOPWATCH SEPERATELY WHEN MARKING


            //Stop watch timing how long it takes to add 100000 elements at end of vector
            //Stopwatch sw1 = Stopwatch.StartNew();
            //int count = 0;
            //while (count < 100000)
            //{
            //  man.Add(rnd.NextDouble());
            //count += 1;
            //}
            //Console.WriteLine(man.ToString());
            //sw1.Stop();
            //Console.WriteLine("Time taken for adding at end (DoubleVector): " + sw1.ElapsedMilliseconds + "ms.");

            
            //Stopwatch timing how long it takes to add 100000 elements to end of list
            //Stopwatch sw2 = Stopwatch.StartNew();
            //int count1 = 0;
            //while (count1 < 100000)
            //{
            //  man1.Add(rnd.NextDouble());
            //  count1 += 1;
            //}
            //Console.WriteLine(man1.ToString());
            //sw2.Stop();
            //Console.WriteLine("Time taken for adding at end (DoubleList): " + sw2.ElapsedMilliseconds + "ms.");


            //Stopwatch timing how long it takes to add 100000 elements to beginning of vector
            //Stopwatch sw3 = Stopwatch.StartNew();
            //int count2 = 0;
            //while (count2 < 100000)
            //{
            //  man2.Add(rnd.NextDouble(),0);
            //  count2 += 1;
            //}
            //Console.WriteLine(man2.ToString());
            //sw3.Stop();
            //Console.WriteLine("Time taken for adding at beginning (DoubleVector): " + sw3.ElapsedMilliseconds + "ms.");


            //stopwatch timing how long it takes to add 100000 elements to beginning of list
            //Stopwatch sw4 = Stopwatch.StartNew();
            //int count3 = 0;
            //while (count3 < 100000)
            //{
            //  man3.Add(rnd.NextDouble(),0);
            //  count3 += 1;
            //}
            //Console.WriteLine(man3.ToString());
            //sw4.Stop();
            //Console.WriteLine("Time taken for adding at beginning (DoubleList): " + sw4.ElapsedMilliseconds + "ms.");


            //Stopwatch timing how long it takes to add two vectors together using new_add
            //Stopwatch sw5 = Stopwatch.StartNew();
            //int count4 = 0;
            //while (count4 < 100000)
            //{
            //    man.Add(rnd.NextDouble());
            //    man2.Add(rnd.NextDouble());
            //    count4 += 1;
            //}
            //result = result.new_add(man, man2);
            ////Console.WriteLine(result);
            //sw5.Stop();
            //Console.WriteLine("Time taken for adding two vectors together using new_add: " + sw5.ElapsedMilliseconds + "ms.");


            //stopwatch timing how long it takes to add two lists together using new_add
            //Stopwatch sw6 = Stopwatch.StartNew();
            //int count5 = 0;
            //while (count5 < 100000)
            //{
            //    man1.Add(rnd.NextDouble());
            //    man3.Add(rnd.NextDouble());
            //    count5 += 1;
            //}
            //result1 = result1.new_add(man1, man3);
            ////Console.WriteLine(result1);
            //sw6.Stop();
            //Console.WriteLine("Time taken for adding two lists together using new_add: " + sw6.ElapsedMilliseconds + "ms.");


            //stopwatch timing how long it takes to add two vectors together using Get
            //Stopwatch sw7 = Stopwatch.StartNew();
            //int count6 = 0;
            //while (count6 < 100000)
            //{
            //    man.Add(rnd.NextDouble());
            //    man2.Add(rnd.NextDouble());

            //    result.Add(man.Get(count6) + man2.Get(count6));

            //    count6 += 1;
            //}
            ////Console.WriteLine(result);
            //sw7.Stop();
            //Console.WriteLine("Time taken for adding two vectors together using Get: " + sw7.ElapsedMilliseconds + "ms.");


            //stopwatch timing how long it takes to add two lists together using Get
            //Stopwatch sw8 = Stopwatch.StartNew();
            //int count7 = 0;
            //while (count7 < 100000)
            //{
            //    man1.Add(rnd.NextDouble());
            //    man3.Add(rnd.NextDouble());

            //    result.Add(man1.Get(count7) + man3.Get(count7));

            //    count7 += 1;
            //}
            ////Console.WriteLine(result);
            //sw8.Stop();
            //Console.WriteLine("Time taken for adding two lists together using Get: " + sw8.ElapsedMilliseconds + "ms.");


            Console.Read();
        }
    }
}
