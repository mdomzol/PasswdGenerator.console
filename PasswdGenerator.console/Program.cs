using System;
using System.Linq;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Podaj długość hasła (8-256): ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length < 8 || length > 256)
            {
                Console.WriteLine("Nieprawidłowa długość.");
                WaitForExit();
                return;
            }

            string password = GeneratePassword(length);

            Console.WriteLine("\nWygenerowane hasło:");
            Console.WriteLine(password);

            Console.WriteLine($"\nSpełnia wymagania: {ValidatePassword(password)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }

        WaitForExit();
    }

    static string GeneratePassword(int length)
    {
        // ❌ usunięte mylące znaki: O, 0, l, 1, I
        const string lower = "abcdefghijkmnopqrstuvwxyz";     // bez l
        const string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";      // bez I, O
        const string digits = "23456789";                     // bez 0,1
        const string symbols = "!@#$%^&*()-_=+[]{}<>?";

        var categories = new[] { lower, upper, digits, symbols };

        char[] password = new char[length];
        int index = 0;

        // minimum 1 znak z każdej kategorii
        foreach (var cat in categories)
        {
            password[index++] = GetRandomChar(cat);
        }

        string allChars = string.Concat(categories);

        // reszta znaków
        for (; index < length; index++)
        {
            password[index] = GetRandomChar(allChars);
        }

        Shuffle(password);

        return new string(password);
    }

    static char GetRandomChar(string chars)
    {
        int index = RandomNumberGenerator.GetInt32(chars.Length);
        return chars[index];
    }

    static void Shuffle(char[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = RandomNumberGenerator.GetInt32(i + 1);
            (array[i], array[j]) = (array[j], array[i]);
        }
    }

    static bool ValidatePassword(string password)
    {
        if (password.Length < 8 || password.Length > 256)
            return false;

        bool hasLower = password.Any(char.IsLower);
        bool hasUpper = password.Any(char.IsUpper);
        bool hasDigit = password.Any(char.IsDigit);
        bool hasSymbol = password.Any(c => !char.IsLetterOrDigit(c));

        int categories = new[] { hasLower, hasUpper, hasDigit, hasSymbol }.Count(x => x);

        return categories >= 3;
    }

    static void WaitForExit()
    {
        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zamknąć...");
        Console.ReadKey();
    }
}