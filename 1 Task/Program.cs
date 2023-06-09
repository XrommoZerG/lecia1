// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ведите номер дня недели");
string strnumberWeek = Console.ReadLine();

int numberWeek = Convert.ToInt32(strnumberWeek);

if (numberWeek == 1){

Console.WriteLine("Понедельник");
}
else if (numberWeek == 2){

Console.WriteLine("Вторник");
}
else if (numberWeek == 3){

Console.WriteLine("Среда");
}
else if (numberWeek == 4){

Console.WriteLine("Четверх");
}
else if (numberWeek == 5){

Console.WriteLine("Пятница");
}
else if (numberWeek == 6){

Console.WriteLine("Субота");
}
else if (numberWeek == 7){

Console.WriteLine("Воскресенье");
}
else if (numberWeek == 0){

Console.WriteLine("В недели больше 0 дней");
}
else {
    Console.WriteLine("В недели 7 дней не больше, пора на отдых");

}
