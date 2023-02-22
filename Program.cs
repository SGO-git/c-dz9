//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] coordsA = new int[3];
System.Console.WriteLine("Imput coord X dot A");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Imput coord Y dot A");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Imput coord Z dot A");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];
System.Console.WriteLine("Imput coord X dot B");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Imput coord Y dot B");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Imput coord Z dot B");
coordsB[2] = Convert.ToInt32(Console.ReadLine());


double Dist = Math.Sqrt(Math.Pow(coordsB[0]-coordsA[0], 2) + Math.Pow(coordsB[1]-coordsA[1], 2) + Math.Pow(coordsB[2]-coordsA[2], 2));
Dist = Math.Round(Dist, 2);
System.Console.WriteLine(Math.Round(Dist, 2));