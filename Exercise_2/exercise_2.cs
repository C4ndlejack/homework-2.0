char[] array = Console.ReadLine().ToCharArray();
int i = 3;
if(i > array.Length)
{
     Console.Write("Третья цифра отсутствует!");
    
}
else
{
    Console.Write("Третья цифра введенного вами числа - ");
    Console.Write(array[2]);
}