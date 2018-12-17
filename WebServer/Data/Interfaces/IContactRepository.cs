using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Data.Models;

namespace WebServer.Data.Interfaces
{
    public interface IContactRepository
    {
         Task<Contact> Contact(string id);
        List<Contact> Contacts { get; }
        Task<bool> UpdateAsync(Contact contact);
        Task<bool> DeleteAsync(string id);
        Task<int> SaveChage();
    }
}
