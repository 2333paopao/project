using Project.CodeSection;


namespace Project.Logic.ILogic
{
    public interface IUserLogic
    {
        LoginUserInformationForCodeSection ValidateAuthenticationToken(string token);

    }
}
