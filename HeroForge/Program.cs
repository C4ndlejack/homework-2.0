class Hero
{
    public string Name;
    public string Race;
    public string Sex;
    public string Class;
    Dictionary<string,int> Attributes = new Dictionary<string,int>()
    {
        {"Strength",0},
        {"Stamina",0},
        {"Dexterity",0},
        {"Intelligence",0},
        {"Wisdom",0},
        {"Charisma",0}
    };
}

class Program
{
    static void SelectRace(Hero myHero)
    {
        string[] nameRaces = {"Human", "Elf", "Dwarf", "Orc", "Goblin"};
        Console.WriteLine("Choose your character's race:");
        Select(nameRaces);
        string heroRace = nameRaces[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("You choose a " + heroRace);
        myHero.Race = heroRace;
    }
    static void SelectSex(Hero myHero)
    {
        string[] nameSex = {"Male", "Female"};
        Console.WriteLine("Choose your sex:");
        Select(nameSex);
        string heroSex = nameSex[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Your sex is " + heroSex);
        myHero.Sex = heroSex;
    }
     static void SelectClass(Hero myHero)
    {
        string[] nameClasses = {"Fighter", "Mage", "Thief", "Priest", "Paladin", "Warlock"};
        Console.WriteLine("Choose your class:");
        Select(nameClasses);
        string heroClass = nameClasses[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Your class is " + heroClass);
        myHero.Class = heroClass;
    }
    static void Select(string[] words)
    {
        for(int i = 0; i < words.Length; i++)
        {
            Console.Write(i+1 + " - " + words[i] + " | ");
        }
        Console.WriteLine("");
    }
    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("What is your name, stranger? ");
        myHero.Name = Console.ReadLine();
        SelectRace(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Your characteristics: ");
        Console.WriteLine ("Your name is - " + myHero.Name);
        Console.WriteLine ("Your sex is - " + myHero.Sex);
        Console.WriteLine ("Your race is - " + myHero.Race);
        Console.WriteLine ("Your class is - " + myHero.Class);
        
    }
}