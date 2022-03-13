using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    public class Developer : Employee, ISendMail, IExportPdfReport, IExportExcelReport
    {
        public List<string> DevSkills { get; set; }

        public override void GetTasks()
        {
            Console.WriteLine("Developer tasks");
        }

        public override void GetEmployeeSkilss()
        {
            Console.WriteLine($"Developer skils: {String.Join("; ", DevSkills)}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string title, string content, string template)
        {
            Console.WriteLine($"Developer mail: Send regular mail from {mailFrom} to {mailTo}");
        }

        public void SendRegularMail(string mailFrom, string mailTo, string mailCC, string title, string content, string template)
        {
            Console.WriteLine($"Developer mail: Send regular mail from {mailFrom} to {mailTo}, cc {mailCC}");
        }

        public void ExportPdfReport()
        {
            Console.WriteLine("Developer export pdf report");
        }

        public void ExportExcelReport()
        {
            Console.WriteLine("Developer export excel report");
        }
    }
}