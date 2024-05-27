// See https://aka.ms/new-console-template for more information



double angle = (360 / (2 * 5));
angle = angle * (Math.PI / 180);
double apotem = (10 / (2 * Math.Tan(angle)));
double tan = Math.Tan(angle);
double perimeter = 5 * 10;
double regularPolygonArea = (perimeter * apotem) / 2;

Console.WriteLine(angle);
Console.WriteLine(apotem);
Console.WriteLine(tan);
Console.WriteLine(regularPolygonArea);