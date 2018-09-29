using listBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listBackend.Services
{
    public interface IDatabaseListService
    {
        IList<Item> FetchUserList();
        void UpdateUserList(IList<Item> UserList);
    }
}
