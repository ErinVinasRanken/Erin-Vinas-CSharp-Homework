using System;

namespace Homework18_02
{
    public class Employee
    {
        // Indstance variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocSecNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // Override the ToString() method
        public override string ToString()
        {
            return
                "First Name: " + FirstName +
                "Last Name:  " + LastName +
                "Soc Sec #:  " + SocSecNumber +
                "Address:    " + Address +
                "City:      " + City +
                "State:      " + State +
                "Zip Code:   " + ZipCode;
        }
    }
}
