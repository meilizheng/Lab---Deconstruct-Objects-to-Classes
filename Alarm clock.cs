using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    public class Alarm_clock
    {
        public enum DisplayType { Analog, Digital}
        public enum PowerSourceType { Battery, Electric, Solar}
        PowerSourceType powerSourceType;
        DisplayType _displayType;
        string _Brand;
        string _Shape;
        string _Material;
        double _Price;
    }
}
