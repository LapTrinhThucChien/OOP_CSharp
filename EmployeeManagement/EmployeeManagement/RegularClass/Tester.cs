using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    public class Tester : Employee, ISendMail, IExportExcelReport
    {
        public List<string> TesterSkills { get; set; }

        public override void GetTasks()
        {
            Console.WriteLine("Tester tasks");
        }

        public override void GetEmployeeSkilss()
        {
            Console.WriteLine($"Tester skils: {String.Join("; ", TesterSkills)}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template)
        {
            Console.WriteLine($"Tester mail: Send regular mail from {mailFrom} to {mailTo}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template)
        {
            Console.WriteLine($"Tester mail: Send regular mail from {mailFrom} to {mailTo}, cc {mailCC}");
        }

        public void ExportExcelReport()
        {
            Console.WriteLine("Tester export excel report");
        }
    }
}