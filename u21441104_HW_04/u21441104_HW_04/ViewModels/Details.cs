using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21441104_HW_04.ViewModels
{
    public abstract class Details
    {
        private string numID;
        private string fName;
        private string lName;

        public Details()
        {
            numID = "null";
            fName = "null";
            lName = "null";
        }

        public Details(string id, string firstName, string lastName)
        {
            NumID = id;
            FName = firstName;
            LName = lastName;
        }

        public string NumID { get => numID; set => numID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }

        public abstract string hasDonated();

        public virtual string Welcome()
        {
            return "Welcome to the donation page!";
        }
    }
}