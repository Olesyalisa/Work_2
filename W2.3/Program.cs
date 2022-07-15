/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

DniNedeli(6); 
DniNedeli(7); 
DniNedeli(1); 
 
void DniNedeli (int num) 
{ 
    if (num == 6 || num == 7) 
    { 
        Console.WriteLine(num + " :weekend"); 
    } 
    else if (num == 1) 
    { 
        Console.WriteLine(num + " :not a day off"); 
    } 
}

