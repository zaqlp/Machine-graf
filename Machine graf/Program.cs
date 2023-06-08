//Console.ReadLine();

int[] o = {2,3,8,6,4,5};
//(int x, int y)[] o = {(1,1), (2,2) , (3,3), (4,4 ), (5,5)};
int po = 0;
int pr = 0;
int sou = 0;
foreach(int i in o)
{
    sou = sou + i;
    po++;
    
}
pr = sou / po;
int f = 0;
List<int> smerodatnacisla = new List<int>();
foreach (int i in o)
{
    smerodatnacisla.Add((Math.Abs(i- pr))^2);
}

Console.WriteLine(po);
Console.WriteLine(sou);
Console.WriteLine(pr);
while (f < smerodatnacisla.Count)
{
    Console.WriteLine(o[f]);
    Console.WriteLine(smerodatnacisla[f]);
    f++;
}


