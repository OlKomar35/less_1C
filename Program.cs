//Задача.2 Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a1 = 5;
int b1 = 7;
int max = a1;
if (max < b1) { max = b1; }
Console.WriteLine($"max= {max}");

int a2 = 2, b2 = 10;
if (a2 < b2)
{
    Console.WriteLine($"max= {b2}");
}
else
{
    Console.WriteLine($"max= {a2}");
}


Console.Write("Введите число a= ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b= ");
int b3 = Convert.ToInt32(Console.ReadLine());
if (a3 > b3){
    Console.WriteLine($"большее число а= {a3}");
}else {
  Console.WriteLine($"большее число b= {b3}");  
}

