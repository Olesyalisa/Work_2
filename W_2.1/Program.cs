/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

SecondDigit(456);
SecondDigit(782);
SecondDigit(918);

void SecondDigit (int num)
{
    int x = ((num % 100) / 10);
    Console.WriteLine(" and: " + x);
}




