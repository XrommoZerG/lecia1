// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Введите число");
string? strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);

int notnumber = number * -1;

if(number > notnumber){

    while(notnumber <= number){
        Console.WriteLine(notnumber);

        notnumber++;


    }

}
else if (number < notnumber){

    while(number <= notnumber){
        Console.WriteLine(number);

           number++;

    }


}

else{
    Console.WriteLine("Ноль это ноль и всё");
}

