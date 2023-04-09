using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Meili Zheng;
//4/9/2023;
//Lab- Deconstruct Objects to Classes;

namespace Lab___Deconstruct_Objects_to_Classes
{
    //Create a alarm clock class; 
    public class Alarm_clock
    {
        //create filed;
        public enum DisplayType { Analog, Digital}
        public enum PowerSourceType { Battery, Electric, Solar}
        List<string> Theme;
        PowerSourceType powerSourceType;
        DisplayType _displayType;
        string _Brand;
        string _Shape;
        string _Material;
        double _Price;
      
        //create constructor;
        public Alarm_clock(List<string> theme, PowerSourceType powerSourceType, DisplayType displayType, string brand, string shape, string material, double price)
        {
            Theme = theme;
            this.powerSourceType = powerSourceType;
            _displayType = displayType;
            _Brand = brand;
            _Shape = shape;
            _Material = material;
            _Price = price;
        }

        //create property;
        public List<string> Theme1 { get => Theme; set => Theme = value; }
        public PowerSourceType PowerSourceType1 { get => powerSourceType; set => powerSourceType = value; }
        public DisplayType DisplayType1 { get => _displayType; set => _displayType = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public string Shape { get => _Shape; set => _Shape = value; }
        public string Material { get => _Material; set => _Material = value; }
        public double Price { get => _Price; set => _Price = value; }      

        //format display result;
        public override string ToString()
        {
            string result =$"Alarm Clock Material: {_Material}\n";
            result += $"Alarm Clock Price: ${_Price}\n";
            result += $"Alarm Clock Shape: {_Shape}\n";
            result += $"Alarm Clock Brand: {_Brand}\n";
            result += $"Alarm Clock Display Type: {_displayType}\n";
            result += $"Alarm Clock Power Source Type: {this.powerSourceType}\n";
            result += $"Alarm Clock Theme:\n";
            foreach (string theme in Theme)
            {
                result += $"{theme}";
            }     
            return result;
        }

         
    }
}
