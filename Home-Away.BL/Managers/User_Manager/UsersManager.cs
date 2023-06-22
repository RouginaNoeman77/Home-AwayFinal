using Home_Away.BL.Dtos;
using Home_Away.BL.Dtos.Login;
using Home_Away.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Home_Away.BL.Managers
{
    public class UsersManager : IUsersManagers
    {
        private readonly IUserRepo _userRepo;
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersManager(IUserRepo userRepo, IConfiguration configuration, UserManager<IdentityUser> userManager)
        {
            _userRepo = userRepo;
            _configuration = configuration;
            _userManager = userManager;
        }

        public IEnumerable<UserReadDto> GetAllUsers()
        {
            var usersFromDB = _userRepo.GetAllUsers();
            return usersFromDB.Select(r => new UserReadDto
            {
                UserId = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Gender = r.Gender,
                DateOfBirth = r.DateOfBirth,
                Owner = r.Owner,
                EntryDate = r.EntryDate,
                TotalMoneySpent = r.TotalMoneySpent,
                ProfileImage = r.ProfileImage,
                AcountState = r.AcountState
            });
        }

        public UserReadDto? GetUserById(string id)
        {
            User? userFromDB = _userRepo.GetUserById(id);
            if (userFromDB == null) { return null; }
            return new UserReadDto
            {
                UserId = userFromDB.Id,
                FirstName = userFromDB.FirstName,
                LastName = userFromDB.LastName,
                Gender = userFromDB.Gender,
                DateOfBirth = userFromDB.DateOfBirth,
                Owner = userFromDB.Owner,
                EntryDate = userFromDB.EntryDate,
                TotalMoneySpent = userFromDB.TotalMoneySpent,
                ProfileImage = userFromDB.ProfileImage,
                AcountState = userFromDB.AcountState
            };
        }

        public IEnumerable<UserReadDto> GetUsersByRole(string role)
        {
            var usersFromDB = _userRepo.GetUsersByRole(role);
            return usersFromDB.Select(r => new UserReadDto
            {
                UserId = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Gender = r.Gender,
                DateOfBirth = r.DateOfBirth,
                Owner = r.Owner,
                EntryDate = r.EntryDate,
                TotalMoneySpent = r.TotalMoneySpent,
                ProfileImage = r.ProfileImage,
                AcountState = r.AcountState
            });
        }

        public IEnumerable<UserReadDto> GetAllOwners()
        {
            var usersFromDB = _userRepo.GetAllOwners();
            return usersFromDB.Select(r => new UserReadDto
            {
                UserId = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Gender = r.Gender,
                DateOfBirth = r.DateOfBirth,
                Owner = r.Owner,
                EntryDate = r.EntryDate,
                TotalMoneySpent = r.TotalMoneySpent,
                ProfileImage = r.ProfileImage,
                AcountState = r.AcountState
            });
        }

        public IEnumerable<UserReadDto> GetAllRenters()
        {
            var usersFromDB = _userRepo.GetAllRenters();
            return usersFromDB.Select(r => new UserReadDto
            {
                UserId = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Gender = r.Gender,
                DateOfBirth = r.DateOfBirth,
                Owner = r.Owner,
                EntryDate = r.EntryDate,
                TotalMoneySpent = r.TotalMoneySpent,
                ProfileImage = r.ProfileImage,
                AcountState = r.AcountState
            });
        }

        public UserReadDto? GetUserWithAllOwnedProperties(string id)
        {
            var userFromDB = _userRepo.GetUserWithAllOwnedProperties(id);
            return new UserReadDto
            {
                UserId = userFromDB.Id,
                FirstName = userFromDB.FirstName,
                LastName = userFromDB.LastName,
                Gender = userFromDB.Gender,
                DateOfBirth = userFromDB.DateOfBirth,
                Owner = userFromDB.Owner,
                EntryDate = userFromDB.EntryDate,
                TotalMoneySpent = userFromDB.TotalMoneySpent,
                ProfileImage = userFromDB.ProfileImage,
                AcountState = userFromDB.AcountState,
                OwnedProperties = userFromDB.OwnedProperties
            };
        }

        public UserReadDto? GetUserWithAllReservations(string id)
        {
            var userFromDB = _userRepo.GetUserWithAllReservations(id);
            return new UserReadDto
            {
                UserId = userFromDB.Id,
                FirstName = userFromDB.FirstName,
                LastName = userFromDB.LastName,
                Gender = userFromDB.Gender,
                DateOfBirth = userFromDB.DateOfBirth,
                Owner = userFromDB.Owner,
                EntryDate = userFromDB.EntryDate,
                TotalMoneySpent = userFromDB.TotalMoneySpent,
                ProfileImage = userFromDB.ProfileImage,
                AcountState = userFromDB.AcountState,
                Reservations = userFromDB.Reservations
            };
        }

        public UserReadDto? GetUserWithAllReviews(string id)
        {
            var userFromDB = _userRepo.GetUserWithAllReviews(id);
            return new UserReadDto
            {
                UserId = userFromDB.Id,
                FirstName = userFromDB.FirstName,
                LastName = userFromDB.LastName,
                Gender = userFromDB.Gender,
                DateOfBirth = userFromDB.DateOfBirth,
                Owner = userFromDB.Owner,
                EntryDate = userFromDB.EntryDate,
                TotalMoneySpent = userFromDB.TotalMoneySpent,
                ProfileImage = userFromDB.ProfileImage,
                AcountState = userFromDB.AcountState,
                Reviews = userFromDB.Reviews
            };
        }

        public UserReadDto? GetUserWithAllQuestionsAnswers(string id)
        {
            var userFromDB = _userRepo.GetUserWithAllQuestionsAnswers(id);
            return new UserReadDto
            {
                UserId = userFromDB.Id,
                FirstName = userFromDB.FirstName,
                LastName = userFromDB.LastName,
                Gender = userFromDB.Gender,
                DateOfBirth = userFromDB.DateOfBirth,
                Owner = userFromDB.Owner,
                EntryDate = userFromDB.EntryDate,
                TotalMoneySpent = userFromDB.TotalMoneySpent,
                ProfileImage = userFromDB.ProfileImage,
                AcountState = userFromDB.AcountState,
                Answers = userFromDB.UsersAnswer
            };
        }

        public string Add(UserAddDto entity)
        {
            User r = new User
            {
                UserName= entity.UserName,
                Email= entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Gender = entity.Gender,
               // DateOfBirth = entity.DateOfBirth,
              //  Owner = entity.Owner,
               // EntryDate = entity.EntryDate,
                //TotalMoneySpent = entity.TotalMoneySpent,
                //ProfileImage = entity.ProfileImage,
               // AcountState = entity.AcountState
                DateOfBirth = entity.DateOfBirth,
                ProfileImage = entity.ProfileImage
                
            };

            _userRepo.AddUser(r);
            _userRepo.SaveChanges();

            return r.Id;
        }

        public bool Update(UserUpdateDto entity)
        {
            User? user = _userRepo.GetUserById(entity.UserId);
            if (user == null) { return false; }

            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Gender = entity.Gender;
            user.DateOfBirth = entity.DateOfBirth;
            user.TotalMoneySpent = entity.TotalMoneySpent;
            user.ProfileImage = entity.ProfileImage;
            

            _userRepo.UpdateUser(user);
            _userRepo.SaveChanges();

            return true;
        }

        public bool Delete(string id)
        {
            User? user = _userRepo.GetUserById(id);
            if (user == null) { return false; }

            _userRepo.DeleteUser(user);
            _userRepo.SaveChanges();

            return true;
        }

        //--------------------
        private TokenDto GenerateToken(IList<Claim> claimsList)
        {
            string keyString = _configuration.GetValue<string>("SecretKey") ?? string.Empty;
            var keyInBytes = Encoding.ASCII.GetBytes(keyString);
            var key = new SymmetricSecurityKey(keyInBytes);

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var expiry = DateTime.Now.AddMinutes(15);

            var jwt = new JwtSecurityToken(
                expires: expiry,
                claims: claimsList,
                signingCredentials: signingCredentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(jwt);

            return new TokenDto(TokenResult.Success, tokenString, expiry);
        }

        public async Task<TokenDto> Login(LoginDto login)
        {
            IdentityUser? user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                return new TokenDto(TokenResult.Failure);
            }

            bool isPasswordCorrect = await _userManager.CheckPasswordAsync(user, login.Password);
            if (!isPasswordCorrect)
            {
                return new TokenDto(TokenResult.UserpasswordError);
            }

            var claimList = await _userManager.GetClaimsAsync(user);
            return GenerateToken(claimList);
        }

        public async Task<RegisterResult> Register(RegisterDto registerDto)
        {
            var newUser = new User
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Gender = registerDto.Gender,
                DateOfBirth = registerDto.DateOfBirth,
                ProfileImage = registerDto.ProfileImage
            };

            var creationResult = await _userManager.CreateAsync(newUser, registerDto.password);
            if (!creationResult.Succeeded)
            {
                return new RegisterResult(false, creationResult.Errors);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, newUser.Id),
                new Claim(ClaimTypes.Role, "User")
            };

            await _userManager.AddClaimsAsync(newUser, claims);

            return new RegisterResult(true);
        }

        //---------------
    }
}
