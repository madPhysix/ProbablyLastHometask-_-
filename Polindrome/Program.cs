internal class Program
{
    static void Main(string[] args)
    {
        IsPalindrome();
        FindFirstFromRight();
        ReverseNumber();
        FindSumOfDigits();
        ArithmeticOperations();
    }

    static void IsPalindrome()
    {
        Console.WriteLine("Enter the number you want to check if it is a palindrome.");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 10 == n / 1000 && (n / 10) % 10 == (n / 100) % 10)

            Console.WriteLine("YES");

        else Console.WriteLine("NO");
    }

    static void FindFirstFromRight()
    {
        Console.WriteLine("Write the number which you want find first number from right");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n % 10);
    }

    static void ReverseNumber()
    {
        Console.WriteLine("Please enter the number you want to reverse");
        int straight = Convert.ToInt32(Console.ReadLine());
        int reversed = (1000 * (straight % 10)) + (100 * ((straight / 10) % 10)) + (10 * ((straight / 100) % 10)) + (straight / 1000);
        Console.WriteLine(reversed);
    }

    static void FindSumOfDigits()
    {
        Console.WriteLine("Please enter 3digit number you want find sum of digits of:");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = n % 10 + (n / 10) % 10 + n / 100;
        Console.WriteLine(sum);
    }

    static void ArithmeticOperations()
    {
        Console.WriteLine("Enter two digits and an operation you want to make with them.(+,-,*,/)");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());

        switch (c)
        {
            case '+': Console.WriteLine(a+b);
                break;
            case '-': Console.WriteLine(a-b);
                break;
            case '*': Console.WriteLine(a*b);
                break;
            case '/': Console.WriteLine(a/b);
                break;
            default: Console.WriteLine("Invalid Input");
                break;
        }
    }
}