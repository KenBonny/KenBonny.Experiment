using System;

namespace KenBonny.Experiment.ExperimentalLibrary
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
            BecameCustomerOn = DateTimeOffset.Now;
            PriorityLevel = 2;
        }

        public string Name { get; set; }

        public DateTimeOffset BecameCustomerOn { get; set; }

        public int PriorityLevel { get; set; }
    }
}