﻿using Library.Model;

namespace Library.Interfaces
{
    public interface IUserRepository
    {
        public IQueryable<UserModel> GetUsers();
        public bool AddUser(UserModel user);
        public bool RemoveUser(UserModel user);
        public UserModel? GetUser(string login);
        public UserModel? GetUser(string login, string password);
        public bool SaveChanges();
    }
}