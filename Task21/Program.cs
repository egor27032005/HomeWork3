Console.Clear();
Console.Write("Введите координаты первой точки: ");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: ");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int c2 = Convert.ToInt32(Console.ReadLine());
int x = (a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2);
double w = Math.Sqrt(x);
Console.WriteLine(Math.Round(w, 2));

