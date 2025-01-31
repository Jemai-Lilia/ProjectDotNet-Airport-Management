﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public string TelNumber { get; set; }
        public virtual void PassengerType()
        {
            Console.WriteLine("Iam Passenger");
        }

        public override string ToString()
        {
            return "BirthDate :" +BirthDate + "EmailAddress :" +EmailAddress + 
                "FirstNamr :" +FirstName + "LastName :" +LastName+ 
                "PassportNumber : " +PassportNumber+ "TelNumber :" +TelNumber; 
        }
        public bool CheckProfile(string FirstName, string LastName)
        {
            if (this.FirstName == FirstName && this.LastName == LastName)
            {
                return true;
            }
            return false;
        }

        public bool CheckProfile(string FirstName, string LastName, string EmailAddress)
        {
            if (EmailAddress != null)
                return this.FirstName == FirstName && this.LastName == LastName && this.EmailAddress == EmailAddress;
            else
               return this.FirstName == FirstName && this.LastName == LastName;

        }

        
    }
}
