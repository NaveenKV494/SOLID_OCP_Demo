using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Naveen", LastName = "Kumar" },
                new PersonModel { FirstName = "Karthik", LastName = "Vijay" },
                new PersonModel { FirstName = "Selva", LastName = "Nathan" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
