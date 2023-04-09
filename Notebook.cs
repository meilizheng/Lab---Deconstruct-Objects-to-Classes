using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    public class Notebook
    {
        public enum Condition { New, used}
        Condition _condition;
        string _Brand;
        string _PaperSize;
        string _PaperBrightRate;
        int _numberOfPages;

        public Notebook (Condition condition, string brand, string papersize, string paperbrighrate, int numberofpages)
        {
            _condition = condition;
            _Brand = brand;
            _PaperSize = papersize;
            _PaperBrightRate = paperbrighrate;
            _numberOfPages = numberofpages;
        }

        public Condition Condition1 { get => _condition; set => _condition = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public string PaperSize { get => _PaperSize; set => _PaperSize = value; }
        public string ParerBringRate { get => _PaperBrightRate; set => _PaperBrightRate = value; }
        public int NumberOfPages { get => _numberOfPages; set => _numberOfPages = value; }

        public override string ToString()
        {
            return $"Notebook Condition: {_condition} \nNotebook Brand:{_Brand} \nPaper size:{_PaperSize} \nPaper Bright Rate: {_PaperBrightRate} \nTotal Pages: {_numberOfPages}   \n";
        }
    }  
    
}
