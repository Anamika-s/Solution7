using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructureDemos
{
    enum Sort { Bubble=1, Selection, Insertion, Shell, Merge };

    internal class SortingDemos
    {
        static int[] num = [12, 23, 34, 11, 35, 11, 9, 5, 6, 3, 1, 10];
        static void Main()
        {
            DisplayElements();
            Console.WriteLine("Which sorting tech");
            int ch = byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case (int)Sort.Bubble: BubbleSort(); break;
                case (int)Sort.Selection: SelectionSort(); break;
                case (int)Sort.Shell: ShellSort(); break;
                case (int)Sort.Merge: SortMethod(num, 0, num.Length-1); break;

            }
            DisplayElements();
        }
        static void BubbleSort()
        {
            int temp;
            for (int i = 0; i <= num.Length - 2; i++)
            {
                for (int j = 0; j <= num.Length - 2; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }

            }
        }

        static void SelectionSort()
        {
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                    }
                }

            }
        }

        static void ShellSort()
        {
            int n = num.Length;
            int gap = n / 2;
            int temp;
            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = num[j];
                    while (j - gap > 0 && temp < num[j - gap])
                    {
                        num[j] = num[j - gap];
                        j = j - gap;
                    }
                    num[j] = temp;
                }
                gap = gap / 2;
            }
        }
        static void MergeSort(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[20];
            int i, left_end, no, temp_pos;

            left_end = (mid - 1);
            temp_pos = left;
            no = (right - left+1);

            while ((left <= left_end) && (mid <= right))

            {
                if (num[left] <= num[mid])
                {
                    temp[temp_pos++] = num[left++];

                }
                else
                {
                    temp[temp_pos++] = num[mid++];
                }
            }
            while (left <= left_end)
            {
                temp[temp_pos++] = num[left++];

            }
            while (mid <= right)
            {
                temp[temp_pos++] = num[mid++];

            }

            for (i = 0; i < no; i++)
            {
                num[right] = temp[right];
                right--;
            }

        }

        static void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if(right>left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left , mid);
                SortMethod(numbers, (mid + 1), right);
                MergeSort(numbers, left, (mid + 1), right);
            }
        }
        static void DisplayElements()
        {
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}