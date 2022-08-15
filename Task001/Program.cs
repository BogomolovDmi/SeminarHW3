// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
int samenumber = number; // Я не придумал как сделать так, чтобы после while изначальное число сравнивалось с его развернутой версией, поэтому тестировал на таком же числе
int revnumber=0; // переменная для разворота числа
int chislo = 0; // переменная для обработки и сохранения последней цифры в числе
int i = 0;
if ((number<100000 && number>9999) || (number>-100000 && number<-9999))
{
        while (i<5)
            {
                chislo=samenumber % 10;
                revnumber = revnumber*10 + chislo;
                samenumber = samenumber / 10;
                i++;
            }

    if (number==revnumber)
        {
            Console.WriteLine(revnumber); //проверка
            Console.WriteLine(number); //проверка
            Console.WriteLine("Это палиндром!");
        }
    else
        {
            Console.WriteLine(revnumber); //проверка
            Console.WriteLine(number); //проверка
            Console.WriteLine("Это не палиндром =(");
        }
}        
else 
{
    Console.WriteLine("Это не пятизначное число, попробуй снова");
}
    

