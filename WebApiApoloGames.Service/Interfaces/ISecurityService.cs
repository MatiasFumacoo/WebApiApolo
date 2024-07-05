namespace WebApiApoloGames.Service.Interfaces
{
    public interface ISecurityService
    {
        string GetAccessToken(string userName, string password);
    }
}
