using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Program
    {
        static void Main()
        {
            List<Employee> school = new List<Employee>
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Smith" },
                new Employee() { Id = 2, firstName = "Sarah", lastName = "Stone" },
                new Employee() { Id = 3, firstName = "Janis", lastName = "Long" },
                new Employee() { Id = 4, firstName = "Ken", lastName = "Bob" },
                new Employee() { Id = 5, firstName = "Sam", lastName = "Land" },
                new Employee() { Id = 6, firstName = "Joe", lastName = "Fruit" },
                new Employee() { Id = 7, firstName = "Linda", lastName = "Song" },
                new Employee() { Id = 8, firstName = "John", lastName = "Fang" },
                new Employee() { Id = 9, firstName = "Len", lastName = "Still" },
                new Employee() { Id = 10, firstName = "Laura", lastName = "Pond" }
            };



            List<Employee> joes = new List<Employee>(); 
            foreach (Employee employee in school) //creates loop for name joe 
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            Console.WriteLine("Employees with the first name joe: "); //prints names that are joe
            foreach (Employee joe in joes)
            {
                Console.WriteLine("Id:" + joe.Id, "Name: " + (joe.firstName + joe.lastName));
            }
            Console.WriteLine();

            List<Employee> joes2 = school.Where(x => x.firstName == "Joe").ToList(); //using lambda to find names bigger than 5
            foreach (Employee joe in joes2)
            {
                Console.WriteLine("Id: " + joe.Id, "Name: " + joe.firstName + joe.lastName);
            }
            Console.WriteLine("");
         
            List<Employee> bigId = school.Where(x => x.Id > 5).ToList(); //finds employees with names bigger than 5 letters
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (Employee emp in bigId)
            {
                Console.WriteLine("Id: " + emp.Id, "Name: " + emp.firstName + emp.lastName);
            }
            Console.ReadLine();
        }
    }
}
