using System.Linq;

namespace Practice1_XML
{
    public class PasswordChecker
    {
        public int Check(string password)
        {
            var score = 0;

            if (password.Length >= 7) score++;

            if (password.Any(char.IsUpper)) score++;

            if (password.Any(char.IsLower)) score++;

            if (password.Any(char.IsNumber)) score++;

            if (password.Any(char.IsSymbol) || password.Any(char.IsPunctuation))
                score++;

            return score;
        }
    }
}