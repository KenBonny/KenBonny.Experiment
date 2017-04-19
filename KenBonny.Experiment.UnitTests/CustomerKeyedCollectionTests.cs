using System;
using KenBonny.Experiment.ExperimentalLibrary;
using Xunit;

namespace KenBonny.Experiment.UnitTests
{
    public class CustomerKeyedCollectionTests
    {
        [Fact]
        public void Add_customer_to_collection()
        {
            var ken = new Customer("Ken");

            var collection = new CustomerKeyedCollection();
            collection.Add(ken);

            Assert.Contains(ken, collection);
        }
    }
}
