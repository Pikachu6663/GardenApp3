using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenLibrary3
{
    public class Garden
    {
        public string Address { get; set; }
        public string Owner { get; set; }
        private List<Flower> Flowers = new List<Flower>();

        public Garden(string address, string owner)
        {
            Address = address;
            Owner = owner;

        }
        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }
        public void ShowAll()
        {
            Console.WriteLine($"Информация о саде:\n" +
                $"Адрес: {Address}\n\n" +
                $"Владелец: {Owner}\n" + "Цветы:");
            Flowers.Sort();
            foreach (Flower p in Flowers)
            {
                p.Show();
            }
        }
    }
}