using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
namespace PractTask
{
    public class Fruit
    {
        private string name;
        private string color;

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual Fruit Input()
        {
            Fruit fruit = new Fruit();

            Console.WriteLine("Enter name");
            fruit.Name = Console.ReadLine();

            Console.WriteLine("Enter color");
            fruit.Color = Console.ReadLine();

            return fruit;
        }

        public override string ToString()
        {
            return $"Name {name} Color {color}";
        }
        public virtual void Print(List<Fruit> fruits)
        {
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.ToString());
            }
        }

        public virtual void Initialize(List<Fruit> fruits)
        {
            string filePath = "Fruits.json";
            using (StreamWriter file = File.CreateText(filePath))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, fruits);
            }
        }
    }
}
