

public class UserService{
    private User _user {get;init;}
    public UserService(User user){
        _user = user;
    }
    
    // Mevduat-Emanet
    public void Deposit(double amount)=>_user.BankAccount.Deposit(amount);

    public void Withdraw(double amount)=>_user.BankAccount.Withdraw(amount);

    public double GetBalance()=>_user.BankAccount.GetBalance();

}