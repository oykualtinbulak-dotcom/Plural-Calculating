Console.Write("Sayı Giriniz :");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen çift sayıya kadar olan çift sayılar :");
int count = 0;
for(int i = 1; i <= number; i++)
{
    count=count+1;
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.Write("CountLoop Value :"+ count);
