

Console.WriteLine("Welome to PUBG Mobile Azerbaijan!!!");
Console.WriteLine();
Console.WriteLine("Click ENTER to continue\r\n(Davam etmek üçün ENTER düymesini basın)");
Console.ReadLine();
Console.WriteLine("1. Mermileri tek tek at\r\n2. Mermilerin hamısını birden at\r\n" +
    "3. Mermini yeniden doldur\r\n4. Oyundan çıx\r\n5. Mermi sayını gösder");
Console.WriteLine();
Console.Write("Reqem Daxil Edin:   ");

int UserInput;

try
{
    UserInput= Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Düzgün reqem daxil edin!!!");
    UserInput = Convert.ToInt32(Console.ReadLine());
}

int NumberOfBullets=30;
int[] MyNumbers = { 1, 2, 3, 4, 5 };

for (int i = 0; i < MyNumbers.Length;)
{
if (UserInput == 1)
{
        do
        {
            if (NumberOfBullets <= 0)
            {
                WriteConsole(UserInput, NumberOfBullets);
                try
                {
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Düzgün reqem daxil edin!!!");
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }
                break;
            }
            NumberOfBullets--;
            WriteConsole(UserInput, NumberOfBullets);
            try
            {
                UserInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Düzgün reqem daxil edin!!!");
                UserInput = Convert.ToInt32(Console.ReadLine());
            }
        } while (UserInput == 1);
}
if (UserInput == 2)
{
    do
    {
            if (NumberOfBullets <= 0)
            {
                WriteConsole(UserInput, NumberOfBullets);
                UserInput = Convert.ToInt32(Console.ReadLine());
                break;
            } 
        WriteConsole(UserInput, NumberOfBullets);
        UserInput = Convert.ToInt32(Console.ReadLine());
        NumberOfBullets = 0;
    } while (UserInput == 2);
}
if (UserInput == 3)
{
    do
    {
        NumberOfBullets = 30;
        WriteConsole(UserInput, NumberOfBullets);
        UserInput = Convert.ToInt32(Console.ReadLine());
    } while (UserInput == 3);
}
if (UserInput == 4)
{
        WriteConsole(UserInput, NumberOfBullets);
        break;
}
if (UserInput == 5)
{
    do
    {      
        WriteConsole(UserInput, NumberOfBullets);
        UserInput = Convert.ToInt32(Console.ReadLine());
    } while (UserInput == 5);
}

 if (UserInput >5||UserInput==0)
{
        WriteConsole(UserInput, NumberOfBullets);
    UserInput = Convert.ToInt32(Console.ReadLine());
}

}


static void WriteConsole(int Input,int Bullets)
{
    if (Bullets<=0)
    {
        Console.WriteLine("Mermi sayı 0 yeniden Doldur!");
    }
    else if (Input==1)
    {
        Console.WriteLine($"1 Mermi atıldı!          \r\n  {Bullets} Mermi qaldi");
    }
    else if (Input==2)
    {
        Console.WriteLine($"Bütün mermiler atıldı!\r\n    Mermini Yeniden Doldur!");
    }
    else if (Input==3)
    {
        Console.WriteLine("Mermiler yeniden dolduruldu!\r\nMermi sayı 30! ");
    }
    else if (Input==4)
    {
        Console.WriteLine("Oyun dayandı!");
    }
    else if (Input==5)
    {
        Console.WriteLine($"Mermi sayı {Bullets} ");
    }
    else
    {
        Console.WriteLine("Düzgün reqem daxil edin!!!");
    }
}


