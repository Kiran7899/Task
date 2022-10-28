using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProj
{
    internal class TaskCancellation
    {
        public static void Main() {
            Console.WriteLine("Hi");
        }

        public void TaskCancelDemo()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            var token = cts.Token; 
            
            //Task started executing in a seperate thread
            Task t = new Task(() =>
            {
                int i = 0;
                while(true)
                {
                    if (token.IsCancellationRequested)
                       throw new TaskCanceledException();

                    Console.WriteLine(i++);
                }
            },token);

            t.Start();
            Console.ReadLine();
            cts.Cancel();
        }
    }
}
