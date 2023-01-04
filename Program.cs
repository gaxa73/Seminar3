//Задача 1
//Работа с кейсами
//Дни недели; Пример.
// Console.WriteLine("Число обозначающее день недели");
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// switch(num)
// {
//     case 1:{
//         Console.WriteLine("Воскресенье! ");
//         break;
//     }    
//     case 2:{
//         Console.WriteLine("Понедельник! ");
//         break;
//     }
//     case 3:{
//         Console.WriteLine("Вторник! ");
//         break;
//     }
//     case 4:{
//         Console.WriteLine("Среда! ");
//         break;
//     }
//     case 5:{
//         Console.WriteLine("Четверг! ");
//         break;
//     }    
//     case 6:{
//         Console.WriteLine("Пятница! ");
//         break;
//     }    
//     case 7:{
//         Console.WriteLine("Воскресенье! ");
//         break;
//     }
//     default:{
//         Console.WriteLine("Введите число от 1 до 7: ");
//         break;
//     }                       
// }

//Задача 2
//Принимаем на вход координаты (Х и Y) где
//(Х не равен 0 и Y не равен 0) и выдает 
//номер четверти в которой находиться точка.
// Console.Write("Введите число Х: ");
// int X = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число Y: ");
// int Y = int.Parse(Console.ReadLine()!);

// if (X > 0 && Y > 0){
//     Console.WriteLine("Первая чверть!");
// }
// if (X < 0 && Y > 0){
//     Console.WriteLine("Вторая чверть!");
// }
// if (X < 0 && Y < 0){
//     Console.WriteLine("Третья чверть!");
// }
// if (X > 0 && Y < 0){
//     Console.WriteLine("Четвертая чверть!");
// }

//Задача 3
//Даеться номер чверти 
//какие координаты в этой чверти
// Console.WriteLine("Введите номер чверти: ");
// Console.WriteLine("Больше > ; Меньше < ; ");
// int num = int.Parse(Console.ReadLine()!);
// switch(num)
// {
//     case 1:{
//         Console.WriteLine("X > 0, Y > 0 ");
//         break;
//     }  
//     case 2:{
//         Console.WriteLine("X < 0, Y > 0 ");
//         break;
//     }
//     case 3:{
//         Console.WriteLine("X < 0, Y < 0 ");
//         break;
//     }
//     case 4:{
//         Console.WriteLine("X > 0, Y < 0 ");
//         break;
//     }
//     default:{
//         Console.WriteLine("Неправильные данные! ");
//         Console.WriteLine("Введите данные от 1 до 4: ");
//         break;
//     }           
// }      

//Задача 4
//Получаем координаты двух точек
//найти растояние между ними в два D пространстве
// Console.WriteLine("Введите координату Х, точку 1; ");
// int xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y, точку 1; ");
// int ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Х, точку 2; ");
// int xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y, точку 2; ");
// int yb = int.Parse(Console.ReadLine()!);

// double res =Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// Console.WriteLine($"Растояние между точками: {res:f2}");

//Задача 5
//Принимаем число и выдаем таблицу
//квадрата чисел от 1 до N;
//Пример 1
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= num; i++){
//      Console.WriteLine(Math.Pow(i, 2));
// }
//Пример 2
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= num; i++){
//      Console.Write($"{Math.Pow(i, 2)} ");
// }

//ДЗ
//Задача 1
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, 
//является ли оно палиндромом.
//Проверка на пятизначность обязательна
//14212 -> нет
//12821 -> да
//23432 -> да

// Console.WriteLine("Домашнее задание: ");
// Console.WriteLine("Введите число: ");
// string num = (Console.ReadLine()!);

// void CheckingNumber(string num){
//  if (num[0] == num[4] || num[1] == num[3]){
//     Console.WriteLine($"Ваше число: {num} - палиндром.");
// }
// else 
//       Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
// }
// if (num!.Length == 5){
//   CheckingNumber(num);
// }
// else 
//      Console.WriteLine($"Введите пятизначное число");

//ДЗ
//Задача 2
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Домашнее задание: ");
// int x1 = Cor("x", "A");
// int y1 = Cor("y", "A");
// int c1 = Cor("c", "A");
// int x2 = Cor("x", "B");
// int y2 = Cor("y", "B");
// int c2 = Cor("c", "B");
// int Cor (string A, string B)
// {
// Console.WriteLine($"Введите координату {A}, точку {B}; ");
// return Convert.ToInt16(Console.ReadLine());
// }
// double res = Math.Sqrt
// (Math.Pow(x2 - x1, 2) + 
// Math.Pow(y2 - y1, 2) + 
// Math.Pow(c2 - c1, 2));
// Console.WriteLine($"Растояние между точками: {res:f3}");

//ДЗ
//Задача 3
//Напишите программу, которая принимает 
//на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Домашнее задание: ");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= num; i++){
     Console.Write($"{Math.Pow(i, 3)} ");
}
