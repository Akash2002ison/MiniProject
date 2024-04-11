using System.Web.Http;
using System.Web.Mvc;
using WebAPI.InterfaceMapping;
using QuizWebAPIModel.UserAPIModel;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebAPI.Controllers
{

    public class UserAPIController : ApiController
    {
        readonly IAPIMapping _apiMapping;
        UserAPIController()
        {
            _apiMapping = DependencyResolver.Current.GetService<IAPIMapping>();
        }


        [HttpPost]
        [Route("UserAPI/CheckUser")]
        public bool CheckUser([FromBody] LoginAPIModel loginAPIModel)
        {
            return _apiMapping.AuthenticateUser(loginAPIModel);
        }

    }
}
