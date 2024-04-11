using Quiz.DAL.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Quiz.DAL.IServices
{
    public interface IUserService
    {
        bool GetUserByEmailAndPassword(User_table user_Table);
        void AddUser(User_table user);
    }
}
