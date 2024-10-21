List<string> Recruits = 
[
"Karma", 
"Adoomy", 
"Banan", 
"Sayboon", 
"Habib"
];

//------------------------------//

List<string> Soldiers = [];

//------------------------------//

while (Soldiers.Count < 3)
{
    Console.WriteLine("--Potential Recruits--");
    for (int i = 0; i < Recruits.Count; i++)
    {
        Console.WriteLine($"[{i}] {Recruits[i]}");
    }
        Console.WriteLine("\n--Current Recruits--");
        for (int i = 0; i <Soldiers.Count; i ++)
    {
        Console.WriteLine($"{Soldiers[i]}");

    }
    Console.WriteLine("\nChoose a recruit:");
    int RecruitNum = 0;
    bool Convert = false;
    //------------------------------//

    while (Convert == false || RecruitNum < 0 || RecruitNum >= Recruits.Count) 
    {
        string nText = Console.ReadLine();
        Convert = int.TryParse(nText, out RecruitNum);

        if (Convert == false)
        {
            Console.WriteLine("Please enter a number!");
        }
        else if (RecruitNum < 0 || RecruitNum >= Recruits.Count)
        {
            Console.WriteLine("Please choose an available number!");
        }

    }

    //------------------------------//

    string recruit = Recruits[RecruitNum];
    Soldiers.Add(recruit);
    Recruits.RemoveAt(RecruitNum);
}

Console.WriteLine($"You recruited a total of {Soldiers.Count} soldiers.");

Console.WriteLine("Press ENTER to quit");
Console.ReadLine();



