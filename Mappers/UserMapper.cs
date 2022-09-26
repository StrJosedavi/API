namespace CursoAPI.Controllers
{
    internal class UserMapper
    {
        public UserMapper()
        {

        }
        public UserRequest Map(UserRequest userRequest)
        {

            return new UserRequest
            {
                UserId = userRequest.UserId,
                Name = userRequest.Name
            };

        }
    }
}