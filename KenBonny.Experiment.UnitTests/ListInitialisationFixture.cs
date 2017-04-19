using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using KenBonny.Experiment.ExperimentalLibrary;

namespace KenBonny.Experiment.UnitTests
{
    public class ListInitialisationFixture
    {
        private const int MaxCustomers = 1_000_000;

        public ListInitialisationFixture()
        {
            RandomCustomer = new Customer("Random");
            var randomPosition = new Random(DateTime.Now.Millisecond).Next(MaxCustomers);

            InitCustomerList(randomPosition);
            InitCustomerCollection(randomPosition);
            InitCustomerDictionary(randomPosition);
            InitCustomerKeyedCollection(randomPosition);
        }

        private void InitCustomerList(int randomPosition)
        {
            CustomerList = new List<Customer>();

            for (var i = 0; i < MaxCustomers; i++)
            {
                if (i == randomPosition)
                {
                    CustomerList.Add(RandomCustomer);
                }
                else
                {
                    var customer = new Customer(Guid.NewGuid().ToString());
                    CustomerList.Add(customer);
                }
            }
        }

        private void InitCustomerCollection(int randomPosition)
        {
            CustomerCollection = new Collection<Customer>();

            for (var i = 0; i < MaxCustomers; i++)
            {
                if (i == randomPosition)
                {
                    CustomerCollection.Add(RandomCustomer);
                }
                else
                {
                    var customer = new Customer(Guid.NewGuid().ToString());
                    CustomerCollection.Add(customer);
                }
            }
        }

        private void InitCustomerDictionary(int randomPosition)
        {
            CustomerDictionary = new Dictionary<string, Customer>();

            for (var i = 0; i < MaxCustomers; i++)
            {
                if (i == randomPosition)
                {
                    CustomerDictionary.Add(RandomCustomer.Name, RandomCustomer);
                }
                else
                {
                    var customer = new Customer(Guid.NewGuid().ToString());
                    CustomerDictionary.Add(customer.Name, customer);
                }
            }
        }

        private void InitCustomerKeyedCollection(int randomPosition)
        {
            CustomerKeyedCollection = new CustomerKeyedCollection();

            for (var i = 0; i < MaxCustomers; i++)
            {
                if (i == randomPosition)
                {
                    CustomerKeyedCollection.Add(RandomCustomer);
                }
                else
                {
                    var customer = new Customer(Guid.NewGuid().ToString());
                    CustomerKeyedCollection.Add(customer);
                }
            }
        }

        public List<Customer> CustomerList { get; private set; }

        public Collection<Customer> CustomerCollection { get; private set; }

        public Dictionary<string, Customer> CustomerDictionary { get; private set; }

        public CustomerKeyedCollection CustomerKeyedCollection { get; private set; }

        public Customer RandomCustomer { get; private set; }
    }
}