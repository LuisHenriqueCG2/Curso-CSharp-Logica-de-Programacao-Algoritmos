﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1011_Esfera
    {
        public void Esfera()
        {
            int raio;
            double vVolume;
            double pi = 3.14159;

            raio = int.Parse(Console.ReadLine());

            vVolume = (double)((4 / 3.0) * pi * Math.Pow(raio, 3));

            Console.WriteLine("VOLUME = " + vVolume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
