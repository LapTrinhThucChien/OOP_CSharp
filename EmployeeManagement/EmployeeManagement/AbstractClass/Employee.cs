using System;

namespace EmployeeManagement
{
    public abstract class Employee
    {
        private string empCode; // field

        private string firstName;

        private string lastName;

        public string EmpCode   // property
        {
            get { return empCode; }   // get method
            set { empCode = value; }  // set method
        }

        public string FirstName   // property
        {
            get { return firstName; }   // get method
            set { firstName = value; }  // set method
        }

        public string LastName   // property
        {
            get { return lastName; }   // get method
            set { lastName = value; }  // set method
        }

        /*ShortHand
         Public string LastName { get; set;}
         */

        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public abstract void GetTasks();

        public abstract void GetEmployeeSkilss();
    }
}