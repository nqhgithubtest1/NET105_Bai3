namespace NET105_Bai3.Services
{
    public class CustomerServiceUpdated : ICustomerService
    {
        public string GetCustumerInfo(int customerId)
        {
            return $"Customer: {customerId} - updated";
        }
    }
}
