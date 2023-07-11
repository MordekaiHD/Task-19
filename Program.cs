// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void ShowPalindrome(int number1, int number2, int number3)
{
    if(number2 == number1 / 1000);
    if(number3 == number1 % 100);
    if(number2 == number3);
    Console.Write("Палинтроп");
    else
    {
       Console.Write("NO"); 
    }           
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
