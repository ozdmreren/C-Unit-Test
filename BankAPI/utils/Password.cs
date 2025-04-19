
using System.Security.Cryptography;
using System.Text;

public class Password{
    public string Hash(string password){
        using(SHA256 sha256 = SHA256.Create()){
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();

            foreach(byte b in hashBytes){
                sb.Append(b);
            }

            return sb.ToString();
        }
    }
}