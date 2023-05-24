using System.Collections.Generic;
using System.IO;

//Feladat 1
List<string> lista = new List<string>();

StreamReader sr = new StreamReader("kifejezesek.txt");

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    lista.Add(sor);
}

sr.Close();


//Feladat 2
int kifejezesekSzama = 0;

while (kifejezesekSzama != lista.Count)
{
    kifejezesekSzama++;
}

Console.WriteLine("---Feladat 2---" + kifejezesekSzama);


//Feladat 3
int mod = 0;

foreach (string sor in lista)
{
    if (sor == "mod")
    {
        mod++;
    }
}

Console.WriteLine("---Feladat 3---" + mod);


//Feladat 4



//Feladat 5
int plusz = 0;
int minusz = 0;
int szor = 0;
int oszt = 0;
int div = 0;

foreach (string sor in lista)
{
    if (sor == "plusz")
    {
        plusz++;
    }

    else if (sor == "minusz")
    {
        minusz++;
    }

    else if (sor == "szor")
    {
        szor++;
    }

    else if (sor == "oszt")
    {
        oszt++;
    }

    else if (sor == "div")
    {
        div++;
    }
}

Console.WriteLine("---Feladat 4---");
Console.WriteLine("+   -" + plusz);
Console.WriteLine("-   -" + minusz);
Console.WriteLine("*   -" + szor);
Console.WriteLine("/   -" + oszt);
Console.WriteLine("div -" + div);


//Feladat 6
static void Felismero(string op)
{
    if (op != "+" || op != "-" || op != "*" || op != "/" || op != "div" || op != "mod")
    {
        Console.WriteLine("Hibás operátor!");
    }

    throw new Exception("Egyéb hiba");
}


//Feladat 7
Console.WriteLine("Kérek egy kifejezést:");
string userInput = Console.ReadLine();

while (userInput != "vége")
{
    Felismero(userInput);

    Console.WriteLine("Kérek egy új kifejezést:");
    userInput = Console.ReadLine();
}


//Feladat 8
StreamWriter sw = new StreamWriter("eredmenyek.txt");

sw.Close();
