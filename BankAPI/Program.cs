
User ahmet = new User("Ahmet","Keskin","ahmet@hotmail.com","pass123456","5090291881");

ahmet.BankAccount = new BankAccount(new Bank("Ziraat Bankası"));

UserService userService = new UserService(ahmet);

Console.WriteLine(userService.GetBalance());

userService.Deposit(2500);

Console.WriteLine(userService.GetBalance());

userService.Withdraw(2000);

Console.WriteLine(userService.GetBalance());

userService.Withdraw(2000);

Console.WriteLine(userService.GetBalance());