/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


string str = 645.ToString(); 
Console.WriteLine(str[2]); 
string strF = 78.ToString(); 
Console.WriteLine("There is no third digit"); 
string strS = 32679.ToString(); 
Console.WriteLine(strS[2]);

