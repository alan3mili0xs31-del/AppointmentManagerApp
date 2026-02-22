using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string EmailAdress { get; private set; }
        private string _hashedPassword;
        public DateTime CreationDate { get; private set; }
        public int Status { get; private set; }

        public User(
            string userName, 
            string emailAdress, 
            string password)
        {
            IsValidUserData(userName, emailAdress);

            Id = Guid.NewGuid();
            UserName = userName;
            EmailAdress = emailAdress;
            _hashedPassword = password;
            CreationDate = DateTime.Now;
            Status = 1;
        }

        public User(
            Guid id,
            string userName,
            string emailAdress,
            string password,
            DateTime creationDate,
            int status)
        {
            Id = id;
            UserName = userName;
            EmailAdress = emailAdress;
            _hashedPassword = password;
            CreationDate= creationDate;
            Status = status;
        }

        public void ChangeUserName(string userName)
        {
            IsValidUserName(userName);
            UserName = userName;
        }

        public void ChangePassword(string password)
        {
            _hashedPassword = password;
        }

        public void ChangeEmailAdress(string emailAdress)
        {
            IsValidEmailAdress(emailAdress);
            EmailAdress = emailAdress;
        }

        public void DoesPasswordMatch(string password)
        {
            if (!_hashedPassword.Equals(password))
                throw new InvalidDataException("Credencials not valid.");
        }

        private void IsValidUserData(
            string userName, 
            string emailAdress)
        {
            IsValidUserName(userName);
            IsValidEmailAdress(emailAdress);
        }

        private void IsValidEmailAdress(string emailAdress)
        {
            string pattern = @"^[\w.\-]{20, 200}$";
            if (!Regex.IsMatch(emailAdress, pattern))
                throw new ArgumentException("Value entered for user's email adress is not valid.");
        }

        private void IsValidUserName(string userName)
        {
            string pattern = @"^\.{5, 100}$";
            if (!Regex.IsMatch(userName, pattern))
                throw new ArgumentException("Value entered for user's name is not valid.");
        }
    }
}
