void findDistance(int x1, int y1, int x2, int y2){
 double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
 Console.WriteLine("The distnce brtwen ({0},{1}) and ({2},{3}) equals {4}", x1, y1, x2, y2, Math.Round(d, 3));
}
Console.Write("Enter 4 numbers ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
findDistance(x1, y1, x2, y2);