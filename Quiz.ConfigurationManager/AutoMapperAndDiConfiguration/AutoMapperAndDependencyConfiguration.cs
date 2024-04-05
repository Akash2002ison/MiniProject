using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Quiz.ConfigurationManager
{
    internal class AutoMapperAndDependencyConfiguration
    {
        public static void InitializeAutoMapper()
        {
            UnityContainer container = new UnityContainer();
            //container.RegisterType<IUserAccountServices, UserAccountServices>();
            //container.RegisterType<IUserAccountAgents, UserAccountAgents>();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<SignUp, AccountDetails>().ReverseMap();
                //cfg.CreateMap<LogIn, AccountDetails>().ReverseMap();
                //cfg.CreateMap<AccountDetails, AccountDetailsTable>().ReverseMap();
            });

            container.RegisterInstance(config.CreateMapper());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
