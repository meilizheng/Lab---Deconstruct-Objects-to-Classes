namespace Lab___Deconstruct_Objects_to_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new instance;
            Hairbrush hairbrush = new Hairbrush(Hairbrush.Gender.women, "Wood", "Curly", "Pink", "Shine Enhancing");
            //display result;
            Console.WriteLine(hairbrush.ToString());
            Wallet wallet = new Wallet(Wallet.CareInstructions.MachineWash, "Fabric", 59.90, "Classic", "Credit Card");
            Console.WriteLine(wallet.ToString ());
            Water_bottle waterbottle = new Water_bottle(Water_bottle.Shape.Rectangular, "Ello", "Aluminum", 14, "Double Wall");
            Console.WriteLine(waterbottle.ToString ());
            Notebook notebook = new Notebook(Notebook.Condition.New, "Oxford", "A4", "95", 140);
            Console.WriteLine(notebook.ToString ());  
            //create new list; 
            List <string> theme1 = new List<string>();
            //add value to the list;
            theme1.Add("-> Airplane\n");
            theme1.Add("-> Animal\n");
            theme1.Add("-> Beach\n");
            theme1.Add("-> Cartoon\n");
            theme1.Add("-> Easter\n");
            theme1.Add("-> Christmas\n");
            theme1.Add("-> Forest\n");
            theme1.Add("-> Music\n");
            theme1.Add("-> Movie\n");
            theme1.Add("-> Sport\n");
            //create new instance;
            Alarm_clock alarmclock = new Alarm_clock(theme1, Alarm_clock.PowerSourceType.Electric, Alarm_clock.DisplayType.Digital, "Philips", "Irregular", "Glass", 29.99);
            //display result;
            Console.WriteLine(alarmclock.ToString ());
        }
    }
}