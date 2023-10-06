using System;

void Clear()
{
Console.WriteLine("(press any key)");
Console.ReadLine();
Console.Clear();
}

Console.WriteLine("Välkommen till Tamagochi! Nu ska du få adoptera en gnocchi. Vad vill du döpa den? ");

Gochi gnocchi = new Gochi();
gnocchi.name = Console.ReadLine();
Console.WriteLine($"Grattis! nu äger du {gnocchi.name} och ansvarar för dens överlevnad.");

Clear();

while (gnocchi.GetAlive() == true)
{
System.Console.WriteLine("Vad vill du göra med din gnocchi? svara med en siffra.");
Console.WriteLine($"1: Mata {gnocchi.name}.");
Console.WriteLine($"2: Prata med {gnocchi.name}.");
Console.WriteLine($"3: Lär {gnocchi.name} ett nytt ord.");

string Action = Console.ReadLine();
Console.Clear();
if (Action == "1")
{
gnocchi.Feed();
}
if (Action == "2")
{
gnocchi.Hi();
}
if (Action == "3")
{
gnocchi.Teach();
}
else
{
    Console.WriteLine($"Du och {gnocchi.name} stirrar på varandra i tystnad...");
}
gnocchi.Tick();
}

Console.WriteLine("RIP");

Console.ReadLine();