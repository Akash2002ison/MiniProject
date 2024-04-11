using AutoMapper;
using Newtonsoft.Json;
using Quiz.BAL.IAgent;
using Quiz.DAL.DBModels;
using Quiz.DAL.IServices;
using QuizViewModel;
using System.Net.Http;
using System.Text;

namespace Quiz.BAL.Agent
{
    public class UserAgent : IUserAgent
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserAgent(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public bool AuthenticateUser(LoginViewModel loginViewModel)
        {
            using (var client = new HttpClient())
            {
                string apiUrl = "https://localhost:44314/UserAPI/CheckUser";
                string json = JsonConvert.SerializeObject(loginViewModel);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
            }
            return true;
        }

        public SignUpViewModel CreateUser(SignUpViewModel signUpViewModel)
        {
            var user = _mapper.Map<User_table>(signUpViewModel);
            _userService.AddUser(user);
            return _mapper.Map<SignUpViewModel>(user);
        }
    }
}
