using AutoMapper;
using Quiz.DAL.DBModels;
using Quiz.DAL.IServices;
using Quiz.DAL.Services;
using QuizWebAPIModel.UserAPIModel;
using System.Net.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebAPI.InterfaceMapping;
using WebAPI.NormalMapping;

namespace WebAPI.AutomappingConfigurations
{
    public class AutomapperAndDI
    {
        public static void Initialize()
        {
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IAPIMapping, APIMapping>();
            container.RegisterInstance(new HttpClient());

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LoginAPIModel, User_table>().ReverseMap();
                cfg.CreateMap<SignUpAPIModel, User_table>().ReverseMap();

            });

            // Register IMapper instance
            container.RegisterInstance(mapperConfiguration.CreateMapper());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}