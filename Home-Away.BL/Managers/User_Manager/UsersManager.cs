
using Home_Away.BL.Dtos;
using Home_Away.DAL;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Home_Away.BL.Managers;

public class UsersManager : IUsersManagers
{
    //Constructor
    private readonly IUserRepo _userRepo;

    public UsersManager(IUserRepo userRepo)
    {
        _userRepo = userRepo;

    }
    //Methods Implementation
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
                AcountState = r.AcountState,              

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
            Reviews= userFromDB.Reviews


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
            Answers =userFromDB.UsersAnswer


        };
    }

    public string Add(UserAddDto entity)
    {
        User r = new User
        {
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Gender = entity.Gender,
            DateOfBirth = entity.DateOfBirth,
            Owner = entity.Owner,
            EntryDate = entity.EntryDate,
            TotalMoneySpent = entity.TotalMoneySpent,
            ProfileImage = entity.ProfileImage,
            AcountState = entity.AcountState
            
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
        user.Owner = entity.Owner;
        user.EntryDate = entity.EntryDate;
        user.TotalMoneySpent = entity.TotalMoneySpent;
        user.ProfileImage = entity.ProfileImage;
        user.AcountState = entity.AcountState;
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


}
