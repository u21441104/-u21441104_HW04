using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21441104_HW_04.ViewModels
{
    public class WaterViewModel : Details
    {
        private string _quantity;
        private string _recurrance;

        public WaterViewModel(string id, string quant, string firstName, string lastName ,string recurrance) : base(id,firstName,lastName)
        {
            _quantity = quant;
            _recurrance = recurrance;
        }

        public string Quantity { get => _quantity; set => _quantity = value; }
        public string Recurrance { get => _recurrance; set => _recurrance = value; }

        public override string hasDonated()
        {
            return _quantity + " liters";
        }
    }
}