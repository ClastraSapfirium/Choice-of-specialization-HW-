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
    System.Console.WriteLine(arr[i]);
}
/////////////////////////////////////
int c = 0, d = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) c += 1;
}
string [] arr1 = new string [c];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        arr1[d] = arr[i];
        d += 1;
    }
}
System.Console.WriteLine("массив с длинной строк 3 и менее элементов имеет вид: ");
for (int i = 0; i < arr1.Length; i++)
{
    System.Console.WriteLine(arr1[i]);
}