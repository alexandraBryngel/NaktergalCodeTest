using NaktergalCodeTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NaktergalCodeTest.Services
{
    public class NaktergalenService
    {

        public void PrintOddNumbers()
        {
            //Det står alla nummer mellan 1 och 99 vilket inte egentligen innefattar 1 och 99 
            //Men jag väljer ändå att tolka de som om vi vill ha med 1 och 99
            for(int i = 1; i <= 99; i+=2)
            {
                Console.WriteLine(i);                
            }
        }
        public int LargestNumber(int[] array)
        {          
            var max = array.Max();
            return max;
        }

        public int ParseAndSumJSON(string filePath)
        {
            string jsonFromFile;
            using (var reader = new StreamReader(filePath))
            {
                jsonFromFile = reader.ReadToEnd();
            }            

            var kittensFromJson = JsonConvert.DeserializeObject<List<Kitten>>(jsonFromFile);

            var sumTails = kittensFromJson.Sum(item => item.tailLength);

            return sumTails; 
        }

        public void ParseXmlAndWriteToConsole(string xmlPath)
        {
            string xmlString = System.IO.File.ReadAllText(xmlPath);

            var doc = XDocument.Parse(xmlString);

            var kittenNames = (from k in doc.Root.Elements("Kitten")
                         select (string)k.Element("Name")
                          ).ToList();

            kittenNames.ForEach(k => Console.WriteLine(k));

            
        }
    }
}