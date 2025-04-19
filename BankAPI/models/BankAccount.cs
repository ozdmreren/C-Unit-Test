

public class BankAccount{
    private  double balance {get;set;}
    private Bank bank {get;set;}
    public BankAccount(Bank bank){
        this.bank = bank;
    }
    public void Deposit(double amount)=>balance = balance + amount;
    public void Withdraw(double amount){
        try{
            if(amount>balance){
                throw new ArgumentException("amount can not greater than your balance");
            }else{
                balance = balance - amount;
            }
        }catch(ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
    }
    public double GetBalance()=>balance;
    public string GetBankName()=>bank.BankName;
}