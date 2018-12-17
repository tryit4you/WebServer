using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Data.Interfaces;
using WebServer.Data.Models;

namespace WebServer.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public readonly ContactDbContext _dbContext;
        public ContactRepository(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Contact> Contacts =>  _dbContext.Contacts.ToList();

        public async Task<Contact> Contact(string id)
        {
            return await _dbContext.Contacts.FindAsync(id);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var contact = await Contact(id);
            if (contact!=null)
            {
                _dbContext.Contacts.Remove(contact);
                int rs = await SaveChage();
                if (rs == 1)
                    return true;
                else
                    return false;
            
            }
            return false;
        }

        public async Task<int> SaveChage()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<bool> UpdateAsync(Contact contact)
        {
            var target = await Contact(contact.Id);

            if (target!=null)
            {
                target.Email = contact.Email;
                target.Phone = contact.Phone;
                target.Facebook = contact.Facebook;
                int rs= await SaveChage();
                if (rs == 1)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
