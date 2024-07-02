﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenLibrary3
{
    public class Flower : IComparable<Flower>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Flower(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public void Show()
        {
            Console.WriteLine($"Название: {Title}\n" +
                $"- Описание: {Description}\n");
        }
        public int CompareTo(Flower other)
        {
            return Title.CompareTo(other.Title);
        }
    }
}