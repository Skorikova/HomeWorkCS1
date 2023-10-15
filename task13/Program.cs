int ReadInt(string msg) //объявляем функцию ридинт и строковый параметр msg
{
    Console.WriteLine(msg);//пишет на терминал параметр msg
    string numb = Console.ReadLine();//функция считывания строки с терминала
    int number;// объявление переменной намбер
    number = int.Parse(numb);// как результат преобразования строки в число
    return number;// возврат из функции
}
 
int number = ReadInt("Введите число ");// вызываем функцию ридинт передаем параметр "введите трехзначное число", потом результат складываем в переменную намбер
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");//если число не трехзначное выводим пользователю ошибка  
}
if(number < 1000 && number > 99)
{
    int ThirdDigit = number % 10;
    Console.WriteLine("ThirdDigit="+ ThirdDigit); 
}
if(number < 10000 && number > 999)
{
    int ThirdDigit = number / 10 % 10;
    Console.WriteLine("ThirdDigit="+ ThirdDigit);
}
if(number < 100000 && number > 9999)
{
    int ThirdDigit = number / 100 % 10;
    Console.WriteLine("ThirdDigit="+ ThirdDigit);
}
