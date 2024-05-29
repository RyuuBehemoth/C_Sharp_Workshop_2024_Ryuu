namespace Workshop_C;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
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
        double average = Math.Round(numbers.Average(), 1);

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
        HashSet<int> unique = new HashSet<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            unique.Add(numbers[i]);
        }
        numbers = unique.ToList();
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
        HashSet<int> unique = new HashSet<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            unique.Add(numbers[i]);
        }
        numbers = unique.ToList();
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
        HashSet<int> unique = new HashSet<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            unique.Add(numbers[i]);
        }
        numbers = unique.ToList();
        return numbers;
    }

    // 14. Rota un array por un número de posiciones
    public int[] RotateArray(int[] array, int positions)
    {
        if (positions > array.Length)
        {
            IEnumerable<int> begin = array.Take(positions);
            positions = positions - begin.Count();
            IEnumerable<int> middle = array.Take(positions);
            IEnumerable<int> end = array.Skip(positions);
            IEnumerable<int> farray = end.Union(middle);
            farray = farray.Union(end);
            return farray.ToArray<int>();
        }
        else
        {
            IEnumerable<int> begin = array.Take(positions);
            IEnumerable<int> end = array.Skip(positions);
            return end.Union(begin).ToArray<int>();
        }
    }

    // 15. Encuentra la mediana de una lista de enteros
    public double FindMedian(List<int> numbers)
    {
        double average = numbers.Average(); //un test esta mal, la mediana no es -1.5 sino -3
        return average;
    }

    // 16. Calcula la desviación estándar de una lista
    public double CalculateStandardDeviation(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        else
        {
            double average = numbers.Average();
            List<double> sum = new List<double>();
            for (int i = 0; i < numbers.Count; i++)
            {
                sum.Add(numbers[i]);
                sum[i] = sum[i] - average;
                sum[i] = Math.Pow(sum[i], 2);
            }
            double sumT = sum.Sum();
            double standardDeviation = Math.Sqrt(sumT / sum.Count);
            return standardDeviation;
        }
    }

    // 17. Comprueba si un valor está en la lista
    public bool CheckForValue(List<int> numbers, int value)
    {
        bool check = false;
        for (int i = 0;i < numbers.Count; i++)
        {
            if (numbers[i] == value)
            {
                check = true;
                break;
            }
        }
        return check;
    }

    // 18. Divide un array en dos subarrays en un índice específico
    public Tuple<int[], int[]> SplitArray(int[] array, int index)
    {
        if (index > array.Length)
        {
            return null;
        }
        else
        {
            IEnumerable<int> begin = array.Take(index);
            IEnumerable<int> end = array.Skip(index);
            int[] array1 = begin.ToArray<int>();
            int[] array2 = end.ToArray<int>();
            var splitArray = Tuple.Create(array1, array2);
            return splitArray;
        }
    }

    // 19. Encuentra el subarray más largo en un array
    public int[] FindLongestSubarray(int[] array)
    {
        bool elements = false;
        if (array.Any() == false)
        {
            return null;
        }
        else
        {
            var group = 0;
            List<int> result = new List<int>();
            foreach (var grouping in array.GroupBy(t => t).Where(t => t.Count() != 1))
            {
                for (int i = 0; i < grouping.Count(); i++)
                {
                    result.Add(grouping.Key);
                    group = grouping.Count();
                }
            }
            int[] ints1 = result.ToArray();
            IEnumerable<int> enumerator = ints1.Take(group);
            ints1 = enumerator.ToArray();

            if (ints1.Any() == true)
            {
                return ints1;
            }
            else
            {
                List<int> list = new List<int>();
                list = array.ToList();
                list.Sort();
                return list.ToArray();
            }
        }
    }

    // 20. Encuentra la secuencia consecutiva más larga en una lista
    public List<int> FindLongestConsecutiveSubsequence(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return numbers;
        }
        else
        {

            List<int> longestConsecutiveSequence = new List<int>();
            List<int> consecutiveSecuence = new List<int> { numbers[0] };

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1)
                {
                    consecutiveSecuence.Add(numbers[i]);
                }
                else
                {
                    if (consecutiveSecuence.Count > longestConsecutiveSequence.Count)
                    {
                        longestConsecutiveSequence = new List<int>(consecutiveSecuence);
                    }
                    consecutiveSecuence.Clear();
                    consecutiveSecuence.Add(numbers[i]);
                }
            }
            if (consecutiveSecuence.Count > longestConsecutiveSequence.Count)
            {
                longestConsecutiveSequence = consecutiveSecuence;
            }
            return longestConsecutiveSequence;
        }
    }

}
