using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21441104_HW_04.ViewModels
{
    public class LoadModelView : Details
    {
        private string _password;

        public LoadModelView()
        {
            _password = "null";
        }

        public LoadModelView(string id, string firstName, string lastName, string password) : base(id, firstName, lastName)
        {
            _password = password;
            
        }

        public string Password { get => _password; set => _password = value; }

        public override string hasDonated()
        {
            return null;
        }

        public override string Welcome()
        {
            return base.Welcome() + " " + FName + " " + LName;
        }
    }
}