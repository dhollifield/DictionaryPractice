namespace Dictionary;
internal class Program
{
    static void Main(string[] args)
    {
        //       const myFamily = {
        //           'sister': {
        //               'name': 'Krista', 
        //	             'age': 42
        //                     }, 
        //           'mother': {
        //               'name': 'Cathie', 
        //	             'age': 70
        //                     }
        //        }

        Dictionary<string, Dictionary<string, string>> family = new Dictionary<string, Dictionary<string, string>>();
        var family2 = new Dictionary<string, Dictionary<string, string>>();//most common use
        Dictionary<string, Dictionary<string, string>> family3 = new();
        //All 3 of the above lines are 3 different ways to write the same code

        /*string name = "Alex";*/ //every variable is a type and then the name of the variable

        family.Add("sister", new Dictionary<string, string> { { "name", "Deborah" }, { "pronoun1", "she" }, { "pronoun2", "her" }, { "age", "47" }, { "birthday", "Jan 24" } });
        family.Add("mother", new Dictionary<string, string> { { "name", "Ida" }, { "pronoun1", "she" }, { "pronoun2", "her" }, { "age", "78" }, { "birthday", "Nov 20"} });
        family.Add("father", new Dictionary<string, string> { { "name", "Gerald" }, { "pronoun1", "he" }, { "pronoun2", "his" }, { "age", "83" }, { "birthday", "Nov 26" } });
        family.Add("brother", new Dictionary<string, string> { { "name", "Steve" }, { "pronoun1", "he" }, { "pronoun2", "his" }, { "age", "51" }, { "birthday", "Jul 10" } });

        string text = family["mother"]["name"];

        Console.WriteLine(text);

        foreach (var familyMember in family)
        {
            var value = familyMember.Value;
            var key = familyMember.Key;
            Console.WriteLine($"My {key}'s name is {value["name"]}, {value["pronoun1"]} is {value["age"]} years old, and {value["pronoun2"]} birthday is {value["birthday"]}.");
        }

        Dictionary<string, int> count = new Dictionary<string, int>();

        count["shirts"] = 23;
        count.Add("pants", 18);
        //check if we already have shirts in the dictionary. If not, add it; if so, increment it

        //count.Add("shirts", 8);

        int extraShirts = 10;

        if (count.ContainsKey("shirts"))
        {
            count["shirts"] += extraShirts;
        }
        else
        {
            count.Add("shirts", 10); 
        }

        Console.WriteLine(count["shirts"]);

        Dictionary<int, string> players = new Dictionary<int, string>();

        players.Add(12, "Rudy Russell");
        players.Add(25, "Sammy Sosa");

        Console.WriteLine(players[12]);
    }
}