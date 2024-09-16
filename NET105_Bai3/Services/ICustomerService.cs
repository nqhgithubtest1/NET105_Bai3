namespace NET105_Bai3.Services
{
    public interface ICustomerService
    {
        string GetCustumerInfo(int customerId);
    }
    public interface ITransientService
    {
        Guid GetID();
    }

    public interface IScopedService
    {
        Guid GetID();
    }

    public interface ISingletonService
    {
        Guid GetID();
    }
}
