using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    public class Wallet
    {
        public enum CareInstructions { DryClothclean, HandWash, MachineWash, WetWipeClean }
        CareInstructions _careInstructions;
        string _Material;
        double _Price;
        string _Style;
        string _CompartmentType;

        public Wallet(CareInstructions careInstructions, string material, double price, string style, string compartmenttype)
        {
            _careInstructions = careInstructions;
            _Material = material;
            _Price = price;
            _Style = style;
            _CompartmentType = compartmenttype;
        }

        public override string ToString()
        {
            return $"Wallet Material: {_Material}   \nWallet Price: {_Price}    \nWallet Style: {_Style}    \nWallet Compartment Type: {_CompartmentType}   \nCare Instruction: {_careInstructions}\n";
        }

    }
}
   
