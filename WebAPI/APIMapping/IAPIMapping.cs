using QuizWebAPIModel.UserAPIModel;

namespace WebAPI.InterfaceMapping
{
    public interface IAPIMapping
    {
        bool AuthenticateUser(LoginAPIModel loginAPIModel);
    }
}