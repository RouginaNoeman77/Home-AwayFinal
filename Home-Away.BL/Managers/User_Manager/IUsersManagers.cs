﻿
using Home_Away.BL.Dtos;
using Home_Away.DAL;

namespace Home_Away.BL.Managers;

public interface IUsersManagers
{
    
    IEnumerable<UserReadDto> GetAllUsers();
    UserReadDto? GetUserById(string id);
    IEnumerable<UserReadDto> GetUsersByRole(string role);
    IEnumerable<UserReadDto> GetAllOwners();
    IEnumerable<UserReadDto> GetAllRenters();
    UserReadDto? GetUserWithAllOwnedProperties(string id);
    UserReadDto? GetUserWithAllReservations(string id);
    UserReadDto? GetUserWithAllReviews(string id);
    UserReadDto? GetUserWithAllQuestionsAnswers(string id);

    void Add(UserAddDto entity);
    bool Update(UserUpdateDto entity);
    bool Delete(string id);
}