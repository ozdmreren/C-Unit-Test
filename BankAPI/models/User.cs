

using System.Security.Cryptography;

public class User{

    private string _password;
    public User(string firstName,string lastName,string email,string password,string phoneNumber,BankAccount bankAccount = null){
        FirstName = firstName;
        LastName = lastName;
        Email = Validator.Email(email);
        Password = Validator.Password.Hash(password);
        PhoneNumber = phoneNumber;
        BankAccount = bankAccount;
    }

    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public string Password {
        get=>_password;
        set=>_password = Validator.Password.Hash(value);
    }
    public string PhoneNumber {get;set;}
    public BankAccount BankAccount{get;set;}
}