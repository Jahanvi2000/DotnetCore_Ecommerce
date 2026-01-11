using DemoApp.Database;
using DemoApp.Model;
using DemoApp.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.service
{
    public class Customerservice : ICustomer
    {
        private readonly AppDbContext _context;

        public Customerservice(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto dto)
        {
            var customer = new Customer
            {
                Name = dto.Name,
                Email = dto.Email,
                Address = dto.Address,
                City = dto.City,
                Number = dto.Number
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            dto.Id = customer.Id;
            return dto;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return false;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            return await _context.Customers
                .Select(c => new CustomerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Address = c.Address,
                    City = c.City,
                    Number = c.Number
                })
                .ToListAsync();
        }

        public async Task<CustomerDto?> GetByIdAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return null;

            return new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Address = customer.Address,
                City = customer.City,
                Number = customer.Number
            };
        }

        public async Task<bool> UpdateAsync(int id, CustomerDto dto)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return false;

            customer.Name = dto.Name;
            customer.Email = dto.Email;
            customer.Address = dto.Address;
            customer.City = dto.City;
            customer.Number = dto.Number;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
