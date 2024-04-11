using AutoMapper;
using Quiz.BAL.Agent;
using Quiz.BAL.IAgent;
using Quiz.DAL.DBModels;
using Quiz.DAL.IServices;
using Quiz.DAL.Services;
using QuizViewModel;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Quiz.ConfigurationManager.App_Start
{
    public class AutoMapperAndDependencyResolver
    {
        public static void Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserAgent, UserAgent>();
            container.RegisterType<IUserService, UserService>();



            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LoginViewModel, User_table>().ReverseMap();
                cfg.CreateMap<SignUpViewModel, User_table>().ReverseMap();

            });

            // Register IMapper instance
            container.RegisterInstance(mapperConfiguration.CreateMapper());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
