int[] setOfNumber = new int[5];

for (int i = 0; i < setOfNumber.Length; i++)
{
    setOfNumber[i] = new Random().Next(1,10);
}

foreach (var item in setOfNumber)
{
   Console.Write(item);
}

int max = setOfNumber[0];

foreach (var item in setOfNumber)
{
    if (max < item)
    {
        max = item;
    }
}
   Console.WriteLine("");
   Console.WriteLine(max);
