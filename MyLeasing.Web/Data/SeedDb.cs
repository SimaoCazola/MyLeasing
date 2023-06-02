using Microsoft.AspNetCore.Identity;
using MyLeasing.Common;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Helpers;
using System;
using System.Linq;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        private Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;

            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("cazolasimao@gmail.com");

            if (user == null)
            {
                user = new User
                {
                    FirstName = "Simao",
                    LastName = "Cazola",
                    Email = "cazolasimao@gmail.com",
                    UserName = "cazolasimao@gmail.com",
                    PhoneNumber = "934000000",
                    Document = "123456"
                };
                var result = await _userHelper.AddUserAsync(user, "12345678");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Database was not created!");
                }
            }

            if (!_context.Owners.Any())
            {
                AddOwner("Simao", "Cazola", "Rua M", user);
                AddOwner("Julia", "Andre", "Rua L", user);
                AddOwner("Luis", "Quitenda", "Rua K", user);
                AddOwner("Sofia", "Costa", "Rua J", user);
                AddOwner("Maria", "Jose", "Rua F", user);
                AddOwner("Alice", "Peixe", "Rua E", user);
                AddOwner("Inocencio", "Jose", "Rua D", user);
                AddOwner("Carlos", "Jose", "Rua C", user);
                AddOwner("Rafael", "Santos", "Rua B", user);
                AddOwner("Joao", "Oliveira", "Rua A", user);

                await _context.SaveChangesAsync();
            }
        }

        private void AddOwner(string firstName, string lastName, string address, User user)
        {
            _context.Owners.Add(new Owner
            {
               
                FirstName = firstName,
                LastName = lastName,
                Document = _random.Next(100000).ToString(),
                FixedPhone = _random.Next(100000000).ToString(),
                Cellphone = _random.Next(100000000).ToString(),
                Address = address,
                User = user
                
            });
        }
    }
}

