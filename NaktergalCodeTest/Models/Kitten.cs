using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace NaktergalCodeTest.Models
{
    public class Kitten
    {
      
        public double Fluffiness { get; set; }        
        public string Name { get; set; }

        public int tailLength { get; set; }

        public bool isMale { get; set; }       
        
    }
}