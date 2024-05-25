namespace Workshop_C;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

public class ArrayListOperation
{
    // 1. Encuentra el valor máximo en una lista
    public int GetMaxValue(List<int> numbers)
    {
        int max = numbers.Max();
        return max; // Solo declaración, sin implementación
    }

    // 2. Encuentra el valor mínimo en una lista
    public int GetMinValue(List<int> numbers)
    {
        int min = numbers.Min();
        return min;
    }

    // 3. Calcula el promedio de una lista
    public double CalculateAverage(List<int> numbers)
    {
        double average = Math.Round(numbers.Average(),1);
        
        return average;
    }

    // 4. Encuentra un elemento en una lista y devuelve su índice
    public int FindElement(List<int> numbers, int element)
    {
        return numbers.IndexOf(element);
    }

    // 5. Cuenta las veces que un elemento aparece en una lista
    public int CountOccurrences(List<int> numbers, int element)
    {
        int repeat = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == element)
            {
                repeat++;
            }
        }
        return repeat;
    }

    // 6. Invierte un array de enteros
    public int[] ReverseArray(int[] array)
    {
        List<int> invert = new List<int>();
        invert.AddRange(array);
        invert.Reverse();
        array = invert.ToArray();
        return array;
    }

    // 7. Ordena un array de enteros en orden ascendente
    public int[] SortArray(int[] array)
    {
        List<int> order = new List<int>();
        order.AddRange(array);
        order.Sort();
        array = order.ToArray();
        return array;
    }

    // 8. Devuelve una lista de elementos únicos
    public List<int> GetUniqueElements(List<int> numbers)
    {
        numbers.Sort();
        for (int i = 1; i > numbers.Count; i++)
        {
            if (numbers[i] == numbers[i-1])
            {
                numbers.Remove(numbers[i-1]);
            }
        }
        return numbers;
    }

    // 9. Suma todos los elementos de una lista
    public int SumElements(List<int> numbers)
    {
        int sum = numbers.Sum();
        return sum;
    }

    // 10. Multiplica todos los elementos de una lista
    public long MultiplyElements(List<int> numbers)
    {
        int mult = 1;
        for (int i = 0; i < numbers.Count; i++)
        {
            mult = mult * numbers[i];
        }
        return mult;
    }

    // 11. Obtiene el segundo elemento más grande de una lista
    public int GetSecondLargest(List<int> numbers)
    {
        for (int i = numbers.Count;i < numbers[0]; i++)
        {
            if (numbers.Max() == numbers[i])
            {
                numbers.Remove(numbers.Max());
            }
        }
        numbers.Remove(numbers.Max());
        int smax = numbers.Max();
        return smax;
    }

    // 12. Verifica si un array está ordenado
    public bool IsArraySorted(int[] array)
    {
        List<int> list = new List<int>();
        list = array.ToList();
        List<int> sorted = new List<int>();
        sorted.AddRange(list);
        sorted.Sort();
        bool a = true;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == sorted[i])
            {
                a = true;
            }
            else
            {
                a = false;
                break;
            }
        }
        return a;
    }

    // 13. Elimina duplicados de una lista
    public List<int> RemoveDuplicates(List<int> numbers)
    {
        return null;
    }

    // 14. Rota un array por un número de posiciones
    public int[] RotateArray(int[] array, int positions)
    {
        return null;
    }

    // 15. Encuentra la mediana de una lista de enteros
    public double FindMedian(List<int> numbers)
    {
        return 0.0;
    }

    // 16. Calcula la desviación estándar de una lista
    public double CalculateStandardDeviation(List<int> numbers)
    {
        return 0.0;
    }

    // 17. Comprueba si un valor está en la lista
    public bool CheckForValue(List<int> numbers, int value)
    {
        return false;
    }

    // 18. Divide un array en dos subarrays en un índice específico
    public Tuple<int[], int[]> SplitArray(int[] array, int index)
    {
        return null;
    }

    // 19. Encuentra el subarray más largo en un array
    public int[] FindLongestSubarray(int[] array)
    {
        return null;
    }

    // 20. Encuentra la secuencia consecutiva más larga en una lista
    public List<int> FindLongestConsecutiveSubsequence(List<int> numbers)
    {
        return null;
    }

}
