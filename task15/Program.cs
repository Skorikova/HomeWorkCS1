﻿int ReadInt(string msg) //объявляем функцию ридинт и строковый параметр msg
{
    Console.WriteLine(msg);//пишет на терминал параметр msg
    string numb = Console.ReadLine();//функция считывания строки с терминала
    int number;// объявление переменной намбер
    number = int.Parse(numb);// как результат преобразования строки в число
    return number;// возврат из функции
}
int number = ReadInt("Введите число ");// вызываем функцию ридинт передаем параметр "введите трехзначное число", потом результат складываем в переменную намбер

if(number <= 7 && number > 5)
{ 
    Console.WriteLine("Это выходной");  
}
else
{
    Console.WriteLine("Это не выходной");
}