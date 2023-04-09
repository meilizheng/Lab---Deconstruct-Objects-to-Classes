 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    public class Hairbrush
    {
        public enum Gender { women, men }
        Gender gender = Gender.women;
        string _Material;
        string _HairType;
        string _Color;
        string _ProductBenifit;

        public Hairbrush(Gender gender, string material, string hairType, string color, string productBenifit)
        {
            this.gender = gender;
            _Material = material;
            _HairType = hairType;
            _Color = color;
            _ProductBenifit = productBenifit;
        }


        public Gender Gender1 { get => gender; set => gender = value; }
        public string Material { get => _Material; set => _Material = value; }
        public string HairType { get => _HairType; set => _HairType = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string ProductBenifit { get => _ProductBenifit; set => _ProductBenifit = value; }

        public override string ToString()
        {
            return $"Brush Material: {_Material}    \nBrush Benifit: {_ProductBenifit}  \nBrush Color: {_Color} \nHair Type: {_HairType}    \nFor: {this.gender}\n";
        }
    }
}
