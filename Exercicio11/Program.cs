﻿using System;

int a, b, c, delta;

Console.WriteLine("Digite o valor para A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor para B: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor para C: ");
c = Convert.ToInt32(Console.ReadLine());

delta = (b * b) - 4 * a * c;

Console.WriteLine("O valor de delta é: " + delta);

