using System.Collections.Generic;
using System.Linq;
using Tamagotchi.API.Dto;

namespace Core
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUser(string id);
    }
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users;
        public UserRepository()
        {
            users = new List<User>();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUser(string id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }
    }

    public class UserService
    {
        private IUserRepository _userRepository { get; }
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Register(RegisterUserDto user)
        {
           var newUser = new User("1", user.Name, user.Password);
            _userRepository.AddUser(newUser);
        }
        public UserDto GetUser(string id)
        {
            var user = _userRepository.GetUser(id);
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name
            };
        }
    }
}
