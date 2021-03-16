// Реверсирование массива.
using System;
class RevCopy
{
    public static void Main()
    {
        int i, j;
        int[] nums1 = new int[10];
        int[] nums2 = new int[10];
        for (i = 0; i < nums1.Length; i++)
            nums1[i] = i;
        Console.Write("Исходное содержимое массива: ");
        for (i = 0; i < nums2.Length; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
        // Копируем массив nums1 в массив nums2 с
        // изменением порядка следования элементов.
        if (nums2.Length >= nums1.Length) // Необходимо
                                          // убедиться, что массив nums2
                                          // достаточно велик.
            for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                nums2[j] = nums1[i];
        Console.Write("Содержимое массива в обратном порядке: ");
        for (i = 0; i < nums2.Length; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();
    }
}
