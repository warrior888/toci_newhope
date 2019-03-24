using Halkidiki.Dal.Interfaces;

namespace Halkidiki.Bll.Interfaces
{
    public interface IUser
    {
        appuser Register(appuser user);

        appuser Login(string login, string password);
    }
}