﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalsPlotter.Classes
{
    public static class Constants
    {
        public static class Fractals
        {
            public static string pyphagorTree = "Пифагорово дерево";
            public static string windTree = "Обдуваемое ветром фрактальное дерево";
            public static string kohLine = "Кривая Коха";
            public static string triangle = "Треугольник Серпинского";
            public static List<String> fractalsNames = new List<string>() { pyphagorTree, windTree, triangle };
        }
    }
}
