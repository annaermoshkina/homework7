using static Library;
int[,] tr=CreateTriangle(120);
PrintTriangle(tr);
int[]koeff=GetKoeff(tr,5);
for (int i=0;i<koeff.Length;i++)
Console.WriteLine();
