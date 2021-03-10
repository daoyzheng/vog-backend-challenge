using System;
namespace VogCodeChallenge.API.Modals
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string MailingAddress { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
