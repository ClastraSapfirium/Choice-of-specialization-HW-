int a = 0;
string b;
Console.Clear();
System.Console.WriteLine("Введите размер массива: ");
b = Console.ReadLine();
a = Convert.ToInt32(b);

string [] arr = new string [a];
for (int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine("Введите строку: ");
    b = Console.ReadLine();
    arr[i] = b;
}
System.Console.WriteLine("Заданный массив имеет вид: ");
for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]} ");
}
Console.Clear();
System.Console.WriteLine("Массив из строк, длинна которых меньше либо равна 3 символа: ");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) System.Console.WriteLine(arr[i]);
}