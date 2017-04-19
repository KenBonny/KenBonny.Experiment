using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using KenBonny.Experiment.ExperimentalLibrary;
using Xunit;

namespace KenBonny.Experiment.UnitTests
{
    public class InsertMillionCustomersSpeedTest
    {

        [Fact]
        public void Speedtest_when_adding_a_million_customers_to_List()
        {
            var collection = new List<Customer>();

            for (int i = 0; i < 1_000_000; i++)
            {
                var customer = new Customer(Guid.NewGuid().ToString());
                collection.Add(customer);
            }
        }

        [Fact]
        public void Speedtest_when_adding_a_million_customers_to_Collection()
        {
            var collection = new Collection<Customer>();

            for (int i = 0; i < 1_000_000; i++)
            {
                var customer = new Customer(Guid.NewGuid().ToString());
                collection.Add(customer);
            }
        }

        [Fact]
        public void Speedtest_when_adding_a_million_customers_to_Dictionary()
        {
            var collection = new Dictionary<string, Customer>();

            for (int i = 0; i < 1_000_000; i++)
            {
                var customer = new Customer(Guid.NewGuid().ToString());
                collection.Add(customer.Name, customer);
            }
        }

        [Fact]
        public void Speedtest_when_adding_a_million_customers_to_CustomerKeyedCollection()
        {
            var collection = new CustomerKeyedCollection();

            for (int i = 0; i < 1_000_000; i++)
            {
                var customer = new Customer(Guid.NewGuid().ToString());
                collection.Add(customer);
            }
        }
    }
}