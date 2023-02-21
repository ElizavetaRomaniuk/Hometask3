// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input 5-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
Console.WriteLine("Incorrect input data");
else
{
    char [] palindrome = number.ToString().ToCharArray();
    bool isPalindrome = true;
    for (int i = 0; i < palindrome.Length / 2; i++)
    {
        if (palindrome[i] != palindrome[palindrome.Length - i -1])
        isPalindrome = false;
    }
    Console.WriteLine("Current number is palindrome - {0}", isPalindrome);
}
