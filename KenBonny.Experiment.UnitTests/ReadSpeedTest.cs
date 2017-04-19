using System.Linq;
using Xunit;

namespace KenBonny.Experiment.UnitTests
{
    public class ReadSpeedTest : IClassFixture<ListInitialisationFixture>
    {
        private readonly ListInitialisationFixture _fixture;

        public ReadSpeedTest(ListInitialisationFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Read_from_customers_list()
        {
            var customer = _fixture.CustomerList.First(c => c.Name == _fixture.RandomCustomer.Name);
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_customers_collection()
        {
            var customer = _fixture.CustomerCollection.First(c => c.Name == _fixture.RandomCustomer.Name);
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_customers_dictionary()
        {
            var customer = _fixture.CustomerDictionary[_fixture.RandomCustomer.Name];
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_customers_keyed_collection()
        {
            var customer = _fixture.CustomerKeyedCollection[_fixture.RandomCustomer.Name];
            Assert.NotNull(customer);
        }
    }
}