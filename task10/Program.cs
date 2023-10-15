int ReadInt(string msg) //объявляем функцию ридинт и строковый параметр msg
{
    Console.WriteLine(msg);//пишет на терминал параметр msg
    string numb = Console.ReadLine();//функция считывания строки с терминала
    int number;// объявление переменной намбер
    number = int.Parse(numb);// как результат преобразования строки в число
    return number;// возврат из функции
}
int number = ReadInt("Введите трехзначное число ");// вызываем функцию ридинт передаем параметр "введите трехзначное число", потом результат складываем в переменную намбер
if(number < 1000 && number > 99)
{
    int SecondDigit = number / 10 % 10;
   
    Console.WriteLine("SecondDigit="+ SecondDigit);//выводим в консоль второе число 
}
else
{
    Console.WriteLine("Это число не трехзначное");//если число не трехзначное выводим пользователю ошибка
}
