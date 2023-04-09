using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    public class Water_bottle
    {
        public enum Shape { Oval, Rectangular, Round, Square}
        Shape _shape;
        string _Brand;
        string _BottleMaterial;
        int _BottleCapacity;
        string _SpecialFeature;

        public Water_bottle(Shape shape, string brand, string bottleMaterial, int bottleCapacity, string specialFeature)
        {
            _shape = shape;
            _Brand = brand;
            _BottleMaterial = bottleMaterial;
            _BottleCapacity = bottleCapacity;
            _SpecialFeature = specialFeature;          
        }

        public Shape Shape1 { get => _shape; set => _shape = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public string BottleMaterial { get => _BottleMaterial; set => _BottleMaterial = value; }
        public int BottleCapacity { get => _BottleCapacity; set => _BottleCapacity = value; }
        public string SpecialFeature { get => _SpecialFeature; set => _SpecialFeature = value; }

        public override string ToString()
        {
            return $"Bottle Material: {_BottleMaterial}    \nBottle Brand: {_Brand}  \nBottle Capacity: {_BottleCapacity}oz   \nBottle Shape: {_shape}  \nBottle Special Feature: {_SpecialFeature}\n";
        }
    }
}
