// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
//  14212 -> нет
//  23432 -> да
//  12821  -> да
Console.WriteLine("Введите пятизначное число:");
int UserNumber = Convert.ToInt32(Console.ReadLine());

bool Palindrome (int number)

{
    int firstDigit = number / 10000;        // 12821 / 10000 = 1
    int firstTwoDigits = number / 1000;     // 12821 / 1000 = 12
    int secondDigit = firstTwoDigits %10;   // 12 % 10 = 2
    int fifthDigit = number % 10;           // 12821 % 10 = 1
    int forthDigit = (number / 10) % 10;    // ( 12821 / 10 ) % 10 = 1282 % 10 = 2
    
    bool result = false;

    if (firstDigit == fifthDigit && secondDigit == forthDigit)
        {
            result = true;
        }
return result;
}

bool callPalindrom = Palindrome(UserNumber);

if (callPalindrom == true)
    { 
    Console.WriteLine("Да, палиндром");
    }
else
    {
    Console.WriteLine("Нет, не палиндром");
    }