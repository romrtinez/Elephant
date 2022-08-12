Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true) 
{
    char input = Console.ReadKey(true).KeyChar;
    Console.WriteLine("Your pressed " + input);

    if (input == '1')
    {
        Console.WriteLine("Calling lloyd.WhoAmI()");
        lloyd.WhoAmI();
    }
    else if (input == '2')
    {
        Console.WriteLine("Calling lucinda.WhoAmI()");
        lucinda.WhoAmI();
    }
    else if (input == '3')
    {
        Elephant swap;
        swap = lloyd;
        lloyd = lucinda;
        lucinda = swap;
        Console.WriteLine("References have been swapped");
    }
    else if (input == '4')
    {
        lloyd = lucinda;
        lloyd.EarSize = 4321;
        lloyd.WhoAmI();
    }
    else if (input == '5')
    {
        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
    }
    else return;
    Console.WriteLine();
}

class Elephant
{
    public int EarSize;
    public string Name;
    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name);
        Console.WriteLine("My ears are " + EarSize);
    }

    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " heard a message");
        Console.WriteLine(whoSaidIt.Name + " said this: " + message);
    }

    public void SpeakTo(Elephant whoToTalkTo, string message)
    {
        whoToTalkTo.HearMessage(message, this);
    }
}