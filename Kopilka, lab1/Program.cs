using System;

public class HelloWorld
{
public static void Main(string[] args)
{

//Ввод какого-либо предмета, на который пользователь хочет накопить
Console.WriteLine("Вы копите на ");

//Название этого предмета
string name = Console.ReadLine();

//Программа спрашивает, сколько стоит эта вещь
Console.WriteLine("Сколько стоит " + name.ToString() + "?");

//Сколько стоит эта вещь
string allsumString = Console.ReadLine();

//Преобразование строки в число
int allsumArg = Convert.ToInt32(allsumString);

//Первоначальная сумма всегда будет равняться нулю
int begin = 0;

while (begin < allsumArg) {


Console.WriteLine("Сколько хотите сейчас внести?");

//Внесение денег
string sumString = Console.ReadLine();

//Преобразование строки в число
int sumArg = Convert.ToInt32(sumString);

begin = begin + sumArg;

if((allsumArg-begin) <= 0) {
Console.WriteLine();
} else {
Console.WriteLine("Осталось накопить " + (allsumArg-begin));
}

}

//Вывод результата
Console.WriteLine("Поздравляю! Вы накопили на " + name.ToString());

}
}