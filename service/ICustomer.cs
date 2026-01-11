using DemoApp.ViewModel;

namespace DemoApp.service
{
    public interface ICustomer
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync();
        Task<CustomerDto?> GetByIdAsync(int id);
        Task<CustomerDto> CreateAsync(CustomerDto dto);
        Task<bool> UpdateAsync(int id, CustomerDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
