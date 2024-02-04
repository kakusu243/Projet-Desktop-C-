// See https://aka.ms/new-console-template for more information
int  Nombres;
string nbre;
int i;
Console.WriteLine("entrer un nombre");
nbre = Console.ReadLine();
Nombres=Convert.ToInt32(nbre);
for (i = 0; i < Nombres; i++)
{
    if (Nombres%i== 0)
    {
        Console.WriteLine(i + "est un diviseur de" + Nombres);
    }
}

Console.WriteLine("Hello, World!");
