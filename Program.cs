double Base, Altura, Area;

Console.Write("Base....:  ");
Base = Convert.ToDouble(Console.ReadLine());

Console.Write("Altura..:  ");
Altura = Convert.ToDouble(Console.ReadLine());

Area = (Base * Altura) / 2;

Console.WriteLine($"Área..: {Area:N3}");