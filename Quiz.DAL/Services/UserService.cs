using Quiz.DAL.DBModels;
using Quiz.DAL.IServices;
using System.Linq;

namespace Quiz.DAL.Services
{
    public class UserService : IUserService
    {
        private readonly QuizGameEntities _context;

        public UserService(QuizGameEntities context)
        {
            _context = context;
        }

        public bool GetUserByEmailAndPassword(User_table user_Table)
        {
            return _context.User_table.Any(x => x.EmailAddress == user_Table.EmailAddress && x.Password == user_Table.Password);
        }

        public void AddUser(User_table user)
        {
            _context.User_table.Add(user);
            _context.SaveChanges();
        }
    }
}
