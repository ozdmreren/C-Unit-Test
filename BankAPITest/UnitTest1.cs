using Xunit;

namespace BankAPITest;

public class Tests
{
    [Fact]

    public void TestConstructor(){
        string expectedName = "Ziraat Bankası";

        Bank bank = new Bank(expectedName);

        Xunit.Assert.Equal(expectedName,bank.BankName);
    }

    [Fact]

    public void TestCanChangeBankName(){
        string bankName = "Garanti Bankası";

        Bank bank = new Bank("Deniz Bankası");
        bank.BankName = bankName;

        Xunit.Assert.Equal(bankName,bank.BankName);
    }

    [Fact]

    public void TestGetBalanceCorrectly(){
        User ahmet = new User("Ahmet","Keskin","ahmet@hotmail.com","pass123456","5090291881",new BankAccount(new Bank("Ziraat")));

        double balance = ahmet.BankAccount.GetBalance();

        Xunit.Assert.Equal(0,balance);
    } 

    [Fact]

    public void TestBalanceType(){
        User ahmet = new User("Ahmet","Keskin","ahmet@hotmail.com","pass123456","5090291881",new BankAccount(new Bank("Ziraat")));

        Xunit.Assert.IsType<double>(ahmet.BankAccount.GetBalance());
    }

    [Fact]

    public void TestGetBalanceAndWithdraw(){
        User ahmet = new User("Ahmet","Keskin","ahmet@hotmail.com","pass123456","5090291881",new BankAccount(new Bank("Ziraat")));

        double withdrawAmount = 2000;

        double depositAmount = 2500;

        ahmet.BankAccount.Deposit(depositAmount);

        ahmet.BankAccount.Withdraw(withdrawAmount);

        Xunit.Assert.Equal(500,depositAmount-withdrawAmount);
    }
}

