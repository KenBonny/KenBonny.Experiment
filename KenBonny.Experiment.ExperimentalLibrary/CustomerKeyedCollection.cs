using System.Collections.ObjectModel;

namespace KenBonny.Experiment.ExperimentalLibrary
{
    public class CustomerKeyedCollection : KeyedCollection<string, Customer>
    {
        protected override string GetKeyForItem(Customer customer) => customer.Name;
    }
}
