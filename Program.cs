// Задать число N и вывести все чётные числа до N
Console.WriteLine("Введите число");
string anamber = Console.ReadLine();
int namber = Convert.ToInt32(anamber);

int a = 2;
while (a <= namber)
{
            Console.WriteLine(a);
            a = a + 2;
}