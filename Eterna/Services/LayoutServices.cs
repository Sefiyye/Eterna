using Eterna.DAL;
using Eterna.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Contact>> GetDatas()
        {
            List<Contact> contacts = await _context.Contacts.ToListAsync();
            return contacts;
        }

    }
}
