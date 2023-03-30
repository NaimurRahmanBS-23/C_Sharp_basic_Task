Console.WriteLine("for loop example = ");
int i = 0;
for( i = 1; i <= 100; i++)
{
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i+" ");
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("While loop example = ");
// While Loop
i = 0;
while (i++<=100)
{
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Do while  loop example = ");
//Do while
i = 0;
do
{
    if (i == 95) continue;
    if (i == 99) break;
    Console.Write(i + " ");
}
while(i++<=100);

Console.WriteLine();
Console.WriteLine();



// Foreach Loop
Console.WriteLine("foreach loop example = ");
int [] arr = { 4, 1, 5, 1, 77, 4, 1 };
foreach(int val in arr)
{
    Console.Write(val+ " ");
}

