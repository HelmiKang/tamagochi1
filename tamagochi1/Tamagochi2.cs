public class Gochi
{
private int hunger;
private int boredome;
private List<string> words = new List<string>() {"mjau"};
private bool isAlive = true;
private Random generator;
public string name;

// sänker Hunger
public void Feed()
{
Console.WriteLine("feed");

}

// skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
public void Hi()
{
    Console.WriteLine("hi");
}


// lägger till ett ord i words, och anropar ReduceBoredom.
public void Teach()
{
    Console.WriteLine("teach");
}

// ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
public void Tick()
{
hunger++;
boredome++;

if (boredome > 10 && hunger > 10)
{
    isAlive = false;
}
}

// skriver ut nuvarande hunger och boredom, och meddelar också huruvida tamagotchin lever
public void PrintStats()
{
    
}

// Returnerar värdet som isAlive har
public bool GetAlive()
{
return isAlive;
}

// sänker boredom
private void ReduceBoredom()
{
    
}


}
