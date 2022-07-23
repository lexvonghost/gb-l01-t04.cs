Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while(i <= n)
{
    Console.Write(i + ", ");
    i = i + 2;
}