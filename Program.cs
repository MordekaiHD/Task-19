// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void ShowPalindrome(int number1, int number2 = 0, int number3 = 0)
{
    if(number2 == number3)
        number2 = number1 / 10000;
        number3 = number1 % 10;
    if(number2 == number3)
        Console.Write("Да");
    else
        Console.Write("Нет");       
}   
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = GetInput("Введите пятизначное число: ");
int number2 = 0;
int number3 = 0;
ShowPalindrome(number1, number2, number3);
