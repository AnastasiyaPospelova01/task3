//Задача 19
//Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number;

while (true) {
    Console.Write("Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
    if (number > 99999 || number < 10000) {
        Console.WriteLine("Число не является пятизначным. Попробуйте ещё раз.");
    }
    else break;
}


int i = number;
int ReverseNumber = 0;

while (i > 0) {
    ReverseNumber = ReverseNumber * 10 + i % 10;
    i /= 10;
}

if (number == ReverseNumber) {
    Console.WriteLine("Это палиндром");
}
else {
    Console.WriteLine("Это не пaлиндром");
}