namespace Garnbibliotek.App;

class Program
{
    static void Main()
    {

    List<string> yarnList = new List<string>();
    string menu = "";
    
    do
    {    
        Console.WriteLine("Välkommen till Garnbiblioteket!");
        Console.WriteLine("Välj vad du vill göra:");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("1. Lägg till garn");
        Console.WriteLine("2. Visa garn");
        Console.WriteLine("3. Ändra garn");
        Console.WriteLine("4. Ta bort garn");
        Console.WriteLine("5. Avsluta");

//---------------------------------------------------------------------------------------------------
        
        switch(menu)
        {
            case "1":

            Console.WriteLine("Vilket garn vill du lägga till?");
            string? addYarn = Console.ReadLine();
            Console.WriteLine($"{addYarn} tillagt");
            Console.WriteLine("Vill du återgå till menyn? Ja => ");

            break;
        }








        
    }
    while(menu != "5");

    }



}
