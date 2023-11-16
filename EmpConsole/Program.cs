using emplib;

employee.Add("hello ", "1234567890");

employee.Get().ForEach(x =>
{

    if (x.Isactive == true)

        Console.WriteLine("active employee");
    else Console.WriteLine("inactive employee");
});