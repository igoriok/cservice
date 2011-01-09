using System;
using System.Collections.Generic;

using Domain.Models;

namespace Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetById(int id);
        IList<Client> GetUserClients(User user);
        IList<Task> GetUserTasks(User user);
    }
}
