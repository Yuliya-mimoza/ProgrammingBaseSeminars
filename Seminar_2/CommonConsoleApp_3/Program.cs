// программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number =new Random().Next(100,1000);
Console.WriteLine(number);

int a1=number/100*10;
int a2=number%10;

int number2=a1+a2;
Console.WriteLine($"Новое число после удаления второй цифры = {number2}"); 