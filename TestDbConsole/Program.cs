// See https://aka.ms/new-console-template for more information

using TESTDAL;
using TestDbConsole;

//TestDBContext dBContext = new TestDBContext();
//if (false)
//{
//    dBContext.Parents.Add(new Parent() { name = "Imposter", isActive = false });
//    dBContext.SaveChanges();
//}

//Console.WriteLine(CrudEF<Parent>.Get());
//Console.WriteLine(CrudEF<Child>.Get());
//var toBeUpdated = dBContext.Parents.ToList()
//    .Where(parent => parent.name == "Ankit")
//    .FirstOrDefault();
//toBeUpdated.name = "Syed";
//dBContext.SaveChanges();

//CrudEF<Parent>.Delete("Imposter","toBeDeletedd");
//CrudEF<Parent>.Add("Shivam", true);
//CrudEF<Parent>.Add("Ankit", false);
//CrudEF<Parent>.Update("Imposter", "Ismail");
Console.WriteLine(CrudEF<Parent>.SearchOne("Ankit"));



CrudEF<Parent>.Get().ForEach(p =>
{
    if (p.isActive)
        Console.WriteLine(p.name + " : is a parent");
    else
    Console.WriteLine(p.name + ": is a child ");
});

