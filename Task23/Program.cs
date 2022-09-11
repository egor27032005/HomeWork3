Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i =0;
int cube;
while (n>i){
    i=i+1;
    cube = i*i*i;
    Console.Write(cube+", ");
}