using System.ComponentModel.DataAnnotations;
using System.IO;

namespace EmpMVC.Models
{
    public class Emp
    {
        [Key]
        public int EmpID { get; set; }
        public string Designation { get; set; }
        public double salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool Isactive { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Aadhaar { get; set; }
        public string Email { get; set; }
        [Range(18,50)]
        public int Age { get; set; }
    }
    public class EmpOperations
    {
        private static List<Emp> _emps = new List<Emp>();
        public static List<Emp> GetAllEmployees()
        {
            if (_emps.Count == 0) {
                _emps.Add(new Emp() { Name = "Ismal", Aadhaar = "1223", Age = 28, Email = "a@c.com" });
                _emps.Add(new Emp() { Name = "Vidya", Aadhaar = "5667798", Age = 22, Email = "agc@c.com" });
                _emps.Add(new Emp() { Name = "Rohit", Aadhaar = "78", Age = 35, Email = "afgiy@c.com" });

            }

            return _emps;
        }

        public static Emp Search(string aadh)
        {
            var emp = GetAllEmployees().Where(e => e.Aadhaar == aadh).FirstOrDefault();
            return emp;
        }
        public static void CreateEmp(Emp e)
        {
            GetAllEmployees();
            _emps.Add(e);
        }

    }
}
