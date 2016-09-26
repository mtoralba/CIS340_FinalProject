// Miguel Toralba CIS-340 9:00AM Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelToralbaFinalProject
{
    class Customer
    {
        //Instance variable go here
        private string customerInitials;
        private string customerFirstName;
        private string customerLastName;
        private string customerCollegeName;
        private string customerState;
        private double customerGPA;
        private string customerCode;
        private int customerCredits;
        private double customerBalance;
        private int honorsCredit = 0;

        //Default constructor method go here
        public Customer(string newInitials, string newFirstName, string newLastName, string newCollegeName, string newState, double newGPA, string newCode, int newCredits, double newBalance)
        {
            customerInitials = newInitials;
            customerFirstName = newFirstName;
            customerLastName = newLastName;
            customerCollegeName = newCollegeName;
            customerState = newState;
            customerGPA = newGPA;
            customerCode = newCode;
            customerCredits = newCredits;
            customerBalance = newBalance;
        }

        //Instance methods go here

        //Retrieve Customer Initials
        public string GetCustomerInitials()
        {
            return customerInitials;
        }

        //Retrieve Customer First Name
        public string GetCustomerFirstName()
        {
            return customerFirstName;
        }

        //Retrieve Customer Last Name
        public string GetCustomerLastName()
        {
            return customerLastName;
        }

        //Retrieve Customer College Name
        public string GetCustomerCollegeName()
        {
            return customerCollegeName;
        }

        //Retrieve Customer State
        public string GetCustomerState()
        {
            return customerState;
        }

        //Retrieve Customer GPA
        public double GetCustomerGPA()
        {
            return customerGPA;
        }

        //Retrieve Customer Code
        public string GetCustomerCode()
        {
            return customerCode;
        }

        //Retrieve Customer Credits
        public int GetCustomerCredits()
        {
            return customerCredits;
        }
        //Set Customer Credits
        public void SetCustomerCredits(int newCredits)
        {
            customerCredits = newCredits;
        }

        //Retrieve Customer Balance
        public double GetCustomerBalance()
        {
            return customerBalance;
        }
        //Set Customer Balance
        public void SetCustomerBalance(double newBalance)
        {
            customerBalance = newBalance;
        }

        //Retrieve Honors Credit
        public int GetHonorsCredit()
        {
            return honorsCredit;
        }
        //Set Honors Credit
        public void SetHonorsCredit(int newHonorsCredit)
        {
            honorsCredit = newHonorsCredit;
        }
    }
}