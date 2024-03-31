using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PractTask
{
    public class Citrus : Fruit
    {
        private float vitaminC;

        public float VitaminC
        {
            get { return vitaminC; }
            set { vitaminC = value; }
        }

        public Citrus() { }

        public override Fruit Input()
        {
            Citrus citrus = new Citrus();

            Console.WriteLine("Enter name");
            citrus.Name = Console.ReadLine();

            Console.WriteLine("Enter color");
            citrus.Color = Console.ReadLine();

            Console.WriteLine("Enter vitamin C");
            if (float.TryParse(Console.ReadLine(), out vitaminC))
            {
                citrus.VitaminC = vitaminC;
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }
            return citrus;
        }
        public override string ToString()
        {
            return $"Name {Name} Color {Color} Vitamin C {vitaminC}";
        }
        public override void Print(List<Fruit> citruses)
        {
            foreach (var citrus in citruses)
            {
                Console.WriteLine(citrus.ToString());
            }
        }
        public override void Initialize(List<Fruit> citruses)
        {
            string filePath = "Fruits.json";
            using (StreamWriter file = File.CreateText(filePath))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, citruses);
            }
        }


    }
}
