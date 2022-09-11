Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a/1000;
int c = (a%10)*10+(a%100)/10;
if (a<10000){
    Console.WriteLine("Число не подходит");
}
else if (a>99999){
    Console.WriteLine("Число не подходит");
}
else if (b==c || a>99999 || a<10000){
Console.WriteLine("Да");
}
else if (b!=c || a>99999 || a<10000){
Console.WriteLine("Нет");
}