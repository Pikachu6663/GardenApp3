using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenLibrary3;

namespace GardenApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание первого объекта класса Garden
            Garden garden1 = new Garden("ул. Цветочная, ст_1", "Иван Иванов");
            garden1.AddFlower(new Flower("Роза", "Красивая красная роза"));
            garden1.AddFlower(new Flower("Тюльпан", "Яркий желтый тюльпан"));
            garden1.AddFlower(new Flower("Лилия", "Белая лилия с приятным ароматом"));
            garden1.AddFlower(new Flower("Маргаритка", "Простая и очаровательная маргаритка"));
            garden1.AddFlower(new Flower("Подсолнух", "Высокий подсолнух с большим цветком"));

            // Показ всех объектов класса Flower для первого сада
            garden1.ShowAll();

            // Создание второго объекта класса Garden
            Garden garden2 = new Garden("просп. Ленина, ст_45", "Анна Петрова");
            garden2.AddFlower(new Flower("Гвоздика", "Красная гвоздика"));
            garden2.AddFlower(new Flower("Орхидея", "Элегантная белая орхидея"));
            garden2.AddFlower(new Flower("Нарцисс", "Желтый нарцисс"));
            garden2.AddFlower(new Flower("Пион", "Розовый пион с крупными лепестками"));
            garden2.AddFlower(new Flower("Лаванда", "Ароматная лаванда"));

            // Показ всех объектов класса Flower для второго сада
            garden2.ShowAll();

            // Создание третьего объекта класса Garden
            Garden garden3 = new Garden("ул. Парковая, ст_78", "Петр Сидоров");
            garden3.AddFlower(new Flower("Ромашка", "Белая ромашка с желтой серединкой"));
            garden3.AddFlower(new Flower("Георгин", "Красный георгин"));
            garden3.AddFlower(new Flower("Хризантема", "Желтая хризантема"));
            garden3.AddFlower(new Flower("Калла", "Белая калла"));
            garden3.AddFlower(new Flower("Фиалка", "Фиолетовая фиалка"));

            //фывфыв

            Console.ReadLine();

        }
    }
}
