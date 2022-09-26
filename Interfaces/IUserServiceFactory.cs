namespace CursoAPI.Controllers
{
    public interface IUserServiceFactory
    {
        void save(long UserId, string name);
    }
}