// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Explicit task creation
Task t = new Task(Print);
t.Start();

//Task Without start option
Task.Factory.StartNew(() => Print());

Task.Factory.StartNew(() => Console.Write(Count(2)));

static void Print() => Console.WriteLine("Task Created");

static int Count(int num)
{
    return num + 1;
}

