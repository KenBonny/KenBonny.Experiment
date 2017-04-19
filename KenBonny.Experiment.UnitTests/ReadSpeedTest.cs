using System;
using System.Diagnostics;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace KenBonny.Experiment.UnitTests
{
    public class ReadSpeedTest : IClassFixture<ListInitialisationFixture>, IDisposable
    {
        private readonly ListInitialisationFixture _fixture;
        private readonly ITestOutputHelper _output;
        private readonly Stopwatch _stopwatch;

        public ReadSpeedTest(ListInitialisationFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            _output = output;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            _output.WriteLine("Total execution time: {0:c}", _stopwatch.Elapsed);
        }

        [Fact]
        public void Read_from_CustomerList()
        {
            var customer = _fixture.CustomerList.First(c => c.Name == _fixture.RandomCustomer.Name);
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_CustomerCollection()
        {
            var customer = _fixture.CustomerCollection.First(c => c.Name == _fixture.RandomCustomer.Name);
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_CustomerDictionary()
        {
            var customer = _fixture.CustomerDictionary[_fixture.RandomCustomer.Name];
            Assert.NotNull(customer);
        }

        [Fact]
        public void Read_from_CustomerKeyedCollection()
        {
            var customer = _fixture.CustomerKeyedCollection[_fixture.RandomCustomer.Name];
            Assert.NotNull(customer);
        }
    }
}