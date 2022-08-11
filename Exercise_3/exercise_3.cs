int[] week = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine("Введите порядковый номер дня недели (начиная с понедельника): ");
int i = Convert.ToInt32(Console.ReadLine());
if (i < week[5])
{
    Console.WriteLine("Это будний день :(");
}
else
{
    Console.WriteLine("Это выходной! :)");
}