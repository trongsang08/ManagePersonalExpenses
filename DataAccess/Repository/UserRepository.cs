﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public void InsertUser(User user)
        {
            ManagePersonalExpensesContext.Instance.Add(user);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            ManagePersonalExpensesContext.Instance.Update(user);
            ManagePersonalExpensesContext.Instance.SaveChanges();
        }
    }
}
