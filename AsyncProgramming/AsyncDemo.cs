// See https://aka.ms/new-console-template for more information
using System.IO;

Console.WriteLine("Hello, World!");

//demo starts here
void Method1()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Method1 i = {i}");
    }


}

void Method2()
{
    for(int i = 0; i< 100;++i)
    {
        Console.WriteLine($"method 2 i = {i}");
    }
}
void TraditionalThreading()
{
    Thread t1 = new Thread(new ThreadStart(Method1));
    t1.Start();
    Thread t2 = new Thread(new ThreadStart(Method2));
    t2.Start();
    Thread.Sleep(1000);
}
//TraditionalThreading();

async Task<int> Method3()
{
    int cnt = 0;
    for (int i = 0; i < 100; ++i)
    {
        Console.WriteLine($"method 3 i = {i}");
        cnt++;
    }
    return cnt;
    
}
async void Method4()
{
    for (int i = 0; i < 100; ++i)
    {
        Console.WriteLine($"method 4 i = {i}");
    }
}
//int count = 0;
//count = await Method3();
//Console.WriteLine($"Value of count is : {count}");


//Demo ends here  
async Task SimpleTask()
{
    Console.WriteLine("Starting task");
    await Task.Delay(1000);   //force delay
    Console.WriteLine("Ended task");
}
await SimpleTask();


async Task<string> ReadFile()
{
    using (StreamReader streamReader = new StreamReader(@"Somefile.txt")) 
    { return await streamReader.ReadToEndAsync(); }
}
File.WriteAllText(@"Somefile.txt", "heheeheheheh");
string contents = await ReadFile();
Console.WriteLine(contents);