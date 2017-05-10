using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
//            var person = new Person();
//            person.SetBirthdate(new DateTime(1997, 2, 4));
//            Console.WriteLine(person.GetBirthDate());

            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
