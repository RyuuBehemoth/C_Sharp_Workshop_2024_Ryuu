// See https://aka.ms/new-console-template for more information



int[] array = { -5,-7,-3,4,-1};
for (int i = 0; i < array.Length; i++) 
{ 
    Console.WriteLine(array[i]); 
}
List<int> result = new List<int>();
result = array.ToList();
result.Sort();
array = result.ToArray();

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine(array.Max());