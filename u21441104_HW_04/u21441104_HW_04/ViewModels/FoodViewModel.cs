using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21441104_HW_04.ViewModels
{
    public class FoodViewModel : Details
    {
        private string _quantity;
        private string _type;

        public FoodViewModel()
        {
            _quantity = "null";
            _type = "null";
        }

        public FoodViewModel(string id, string quant, string firstName, string lastName, string type) : base(id, firstName, lastName)
        {
            Quantity = quant;
            Type = type;
        }

        public string Quantity { get => _quantity; set => _quantity = value; }
        public string Type { get => _type; set => _type = value; }

        public override string hasDonated()
        {
            return _quantity + " liters";
        }
    }
}