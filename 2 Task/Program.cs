Console.WriteLine("Ведите первое число: ");

string? strnumber1 = Console.ReadLine();

Console.WriteLine("Ведите второе число: ");

string? strnumber2 = Console.ReadLine();

int number1 = Convert.ToInt32(strnumber1);

int number2 = Convert.ToInt32(strnumber2);


if( number1 / number2 == number2 )
{
    Console.WriteLine("Первое число являеться квадратом второго ");
}
else
{
        Console.WriteLine("Первое число НЕ! являеться квадратом второго ");

}


