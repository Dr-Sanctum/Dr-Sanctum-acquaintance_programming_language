//Задание: Написать программу копирования массива

int[] CopyArray(int[] array)
{
int[] arr2 = new int[array.Length];
Array.Copy(array,arr2,array.Length);
return arr2;
}

int[] arr1 = new int[10]{1,3,4,5,8,9,0,546,8,9};

Console.WriteLine("Arr1");
foreach (var item in arr1)
{
    Console.Write(item + ",");
}

Console.WriteLine();

int[] arr2 = CopyArray(arr1);
Console.WriteLine("Arr2");

foreach (var item in arr2)
{
    Console.Write(item + ",");
}






