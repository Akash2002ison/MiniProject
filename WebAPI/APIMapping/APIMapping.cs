using AutoMapper;
using Quiz.DAL.DBModels;
using Quiz.DAL.IServices;
using QuizWebAPIModel.UserAPIModel;
using QuizWebAPIModel.UserAPIModel;
using WebAPI.InterfaceMapping;
namespace WebAPI.NormalMapping
{
    public class APIMapping : IAPIMapping
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public APIMapping(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public bool AuthenticateUser(LoginAPIModel loginAPIModel)
        {
            return _userService.GetUserByEmailAndPassword(_mapper.Map<User_table>(loginAPIModel));
        }
    }
}