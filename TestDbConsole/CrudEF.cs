using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTDAL;
namespace TestDbConsole
{
    public class CrudEF<T> where T :Parent
    {
        static TestDBContext dBContext = new TestDBContext();
        public static void Add(string pName,bool active) {
            dBContext.Parents.Add(new Parent() { name = pName, isActive = active });
            dBContext.SaveChanges();
        }
        public static void Update(string pname, string tbupdated) {
         var toBeUpdated = dBContext.Parents.ToList()
    .Where(parent => parent.name == pname)
    .FirstOrDefault();
toBeUpdated.name = tbupdated;
dBContext.SaveChanges();
        }

        public static void Delete(string pname, string tbdelted) {
            var toBedeletedd = dBContext.Parents.ToList()
        .Where(parent => parent.name == pname)
        .FirstOrDefault();
            dBContext.Parents.Remove(toBedeletedd);
            dBContext.SaveChanges();

        }
        public static List<T> ? Get() {

            return dBContext.Parents.ToList()  as List<T>;
        }
        public static T ? SearchOne(string pname) { 
        
        
        var result = dBContext.Parents
                .ToList()
                .Where(p => p.name == pname)
                .FirstOrDefault();

            return result as T;
        }



    }
}
