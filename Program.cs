namespace Lab___Deconstruct_Objects_to_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hairbrush hairbrush = new Hairbrush(Hairbrush.Gender.women, "Wood", "Curly", "Pink", "Shine Enhancing");
            Console.WriteLine(hairbrush.ToString());
            Wallet wallet = new Wallet(Wallet.CareInstructions.MachineWash, "Fabric", 50.50, "Classic", "Credit Card");
            Console.WriteLine(wallet.ToString ());
            Water_bottle waterbottle = new Water_bottle(Water_bottle.Shape.Rectangular, "Ello", "Aluminum", 14, "Double Wall");
            Console.WriteLine(waterbottle.ToString ());
            Notebook notebook = new Notebook(Notebook.Condition.New, "Oxford", "A4", "95", 140);
            Console.WriteLine(notebook.ToString ());
        }
    }
}