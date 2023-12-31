﻿using System;
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
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Naveen", LastName = "Kumar" },
                new MangerModel { FirstName = "Karthik", LastName = "Vijay"},
                new ExecutiveModel { FirstName = "Selva", LastName = "Nathan" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
