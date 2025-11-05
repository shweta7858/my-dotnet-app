using Mera_yani_shweta_ka_app.Data;
using Mera_yani_shweta_ka_app.Interface;
using Mera_yani_shweta_ka_app.models.User;
using Microsoft.EntityFrameworkCore;

namespace Mera_yani_shweta_ka_app.ServiceImpl
{
    public class CustomerServiceImpl : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerServiceImpl(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddNewCustomer(Customer customer, bool isGoogleUser = false)
        {
            if (!isGoogleUser) // normal user signup  
            {
                customer.Password = BCrypt.Net.BCrypt.HashPassword(customer.Password);
            }
            else
            {
                customer.Password = null;
            }

            _context.CustomerDetails.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewUser(Customer customer, bool isGoogleUser = false)
        {
            await AddNewCustomer(customer, isGoogleUser);
        }




    }
}
