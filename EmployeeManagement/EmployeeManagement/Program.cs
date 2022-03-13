using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=============================================================================");

            Developer dev = new Developer
            {
                EmpCode = "TonyStark",
                FirstName = "Tony",
                LastName = "Stark",
                DevSkills = new List<string> { "HTML", "CSS", "C#", "JS" }
            };

            dev.GetFullName();
            dev.GetTasks();
            dev.GetEmployeeSkilss();
            dev.SendRegularMail("Tony Stark", "HR Department", "Leave request mail", "Leave template", string.Empty);
            dev.SendRegularMail("Tony Stark", "HR Department", "Project manager" ,"Leave request mail", "Leave template", string.Empty);
            dev.ExportPdfReport();
            dev.ExportExcelReport();

            Console.WriteLine("=============================================================================");

            Tester tester = new Tester
            {
                EmpCode = "PeterParker",
                FirstName = "Peter",
                LastName = "Parker",
                TesterSkills = new List<string> { "Automation Testing", "Performance Testing" }
            };

            tester.GetFullName();
            tester.GetTasks();
            tester.GetEmployeeSkilss();
            tester.SendRegularMail("Peter Parker", "HR Department", "Leave request mail", "Leave template", string.Empty);
            tester.SendRegularMail("Peter Parker", "HR Department", "Project manager", "Leave request mail", "Leave template", string.Empty);
            tester.ExportExcelReport();
        }
    }
}