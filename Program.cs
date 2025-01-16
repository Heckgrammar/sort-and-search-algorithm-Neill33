using System.Diagnostics;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();

            int[] array = CreateArray(n);

            if (array == null)
            {
                Console.WriteLine("Array has not been created");
                return;
            }
        }
        static int[] CreateArray(Random r)
        {
            Console.WriteLine("Enter the length of your array: ");
            int arraylength = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine($"Enter number {i+1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers;
        }

        static void menu()
        {

            Console.WriteLine("Enter what search you want to do: 1:Linear search, 2:Binary search, 3:Bubble sort, 4:Merge sort, 9 ");
            string option = Console.ReadLine();
        }
        
        static void BubbleSort(int[] a)
        {
            
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            return true;
        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            return true;
        }

    }
}
