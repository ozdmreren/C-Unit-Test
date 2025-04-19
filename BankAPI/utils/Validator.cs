

using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public class Validator{
    public static Password Password {get;} = new Password(); 
    public static string Email(string email){
        Regex reg = new Regex("^[a-zA-Z0-9.+_%-]+@[a-zA-Z-0-9.-]+\\.[a-zA-Z]{2,4}$");
        try{
        if(!reg.IsMatch(email)){
            throw new ArgumentException("Invalid email");
        }
        }
        catch(ArgumentException ex){
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
        return email;
    }


}