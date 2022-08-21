using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21441104_HW_04.ViewModels
{
    public class CreateModelView : Details
    {
        private string _password;

        public CreateModelView(string id, string password, string firstName, string lastName) : base(id,firstName,lastName)
        {
            Password = password;
        }

        public string Password { get => _password; set => _password = value; }

        public override string hasDonated()
        {
            return null;
        }
    }
}