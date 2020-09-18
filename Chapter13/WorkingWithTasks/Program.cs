using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace WorkingWithTasks
{
    class Program
    {
        static void MethodA()
        {
            WriteLine("Starting MethodA ...");
            Thread.Sleep(3000);   // simulate 3 seconds of work
            WriteLine("Finished MethodA.");
        }
        static void MethodB()
        {
            WriteLine("Starting MethodB ...");
            Thread.Sleep(2000);   // simulate 2 seconds of work
            WriteLine("Finished MethodB.");
        }
        static void MethodC()
        {
            WriteLine("Starting MethodC ...");
            Thread.Sleep(1000);   // simulate 1 second of work
            WriteLine("Finished MethodC.");
        }

        static decimal CallWebService()
        {
            WriteLine("Staring call to web service...");
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to web service.");
            return 89.99M;
        }

        static string CallStoredProcedure(decimal amount)
        {
            WriteLine("Staring call to storde procedure ...");
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to stored procedure.");
            return$"12 products cost more than {amount:C}.";
        }

        static void Main(string[] args)
        {
            // Running multiple actions synchronously
            var timer = Stopwatch.StartNew();

/*
            WriteLine("Running methods synchronously...");
            MethodA();
            MethodB();
            MethodC();

            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed");
*/
 /*
            // Running methdods asynchronously via Tasks
            WriteLine("Running methods asynchronously on multiple threads.");
            Task taskA = new Task(MethodA);
            taskA.Start();
            Task taskB = Task.Factory.StartNew(MethodB);
            Task taskC = Task.Run(new Action(MethodC));

            // Make sure we wait for them all to finish before outputting total elapsed time
            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);
*/
            WriteLine("Passing the result of one task as an input into another.");

            var taskCallWebServiceAndThenStoredProcedure = Task.Factory.StartNew(CallWebService)
                    .ContinueWith(previousTask => CallStoredProcedure(previousTask.Result));
            WriteLine($"Result: {taskCallWebServiceAndThenStoredProcedure.Result}");

            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed");            
        }
    }
}
