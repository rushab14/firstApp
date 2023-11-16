using System.ComponentModel.DataAnnotations;

namespace SampleWebApp.Models
{
    public class Person
    {
        [Required]
        public string Aadhar { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(18,100)]
        public int Age { get; set; }

    }
    public class PersonOperations
    {
        private static List<Person> _people = new List<Person>();

        public static List<Person> GetPeople()
        {
            if (_people.Count == 0)
            {
                _people.Add(new Person() { Aadhar = "1213456", Age = 19, Email = "abc@gmail.com", Name = "Ankitt" });
                _people.Add(new Person() { Aadhar = "1213457", Age = 19, Email = "abc1@gmail.com", Name = "Ankur" });
                _people.Add(new Person() { Aadhar = "1213458", Age = 19, Email = "abc2@gmail.com", Name = "Aninket" });
            }
            return _people;
        }

        public static Person SearchOne(string paadh)
        {
           var person = GetPeople().Where(p => p.Aadhar == paadh).FirstOrDefault();
            return person;
        }

        public static List<Person> SearchInAge(int startAge, int endAge)
        {
            var res = GetPeople().Where(p => p.Age >= startAge && p.Age <= endAge).ToList();
            return res;
        }

        public static void CreateNew(Person p)
        {
            GetPeople();
            _people.Add(p);
        }
    }
}
