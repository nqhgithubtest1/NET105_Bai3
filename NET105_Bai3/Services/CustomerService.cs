namespace NET105_Bai3.Services
{
    public class CustomerService : ICustomerService
    {
        public string GetCustumerInfo(int customerId)
        {
            return $"Customer: {customerId}";
        }
    }

    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public SomeService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
