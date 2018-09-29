using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using listBackend.Models;

namespace listBackend.Services
{
    public class DatabaseListService : IDatabaseListService
    {
        public IList<Item> FetchUserList()
        {
            var list = new List<Item> { new Item("Ball"), new Item("Toy Car") };
            return list;
        }

        public void UpdateUserList(IList<Item> UserList)
        {
            throw new NotImplementedException();
        }
    }
}
