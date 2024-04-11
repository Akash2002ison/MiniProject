using Quiz.BAL.Agent;
using Quiz.BAL.IAgent;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace QuizGame
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUserAgent, UserAgent>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}