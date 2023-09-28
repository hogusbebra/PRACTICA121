//int[] nums = new int[4] { 1, 2, 3, 5 };
//Console.WriteLine("какое первое????");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("какое второе????");
//int b = Convert.ToInt32(Console.ReadLine());
//int c = nums[a];
//nums[a] = nums[b];
//nums[b] = c;
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write(nums[i] + " ");
//}


using System;
int[,] nums = new int[4, 4]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 0}
};
Random random = new Random();
int w = nums.GetLength(0);
int h = nums.GetLength(1);
int n = w * h;
while (n > 1)
{
    n--;
    int k = random.Next(n + 1);
    int temp = nums[n / h, n % h];
    nums[n / h, n % h] = nums[k / h, k % h];
    nums[k / h, k % h] = temp;
}
bool isCorrectOrder = false; 
while (!isCorrectOrder) 
{
    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            Console.Write(nums[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Что двигаем на пустое(0)?");
    int b = Convert.ToInt32(Console.ReadLine());

    int line3 = -1, tab3 = -1;
    int line4 = -1, tab4 = -1;

    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            if (nums[i, j] == 0)
            {
                line3 = i;
                tab3 = j;
            }
            if (nums[i, j] == b)
            {
                line4 = i;
                tab4 = j;
            }
        }
    }
    if ((Math.Abs(line3 - line4) == 1 && tab3 == tab4) || (Math.Abs(tab3 - tab4) == 1 && line3 == line4))
    {
        int temp = nums[line3, tab3];
        nums[line3, tab3] = nums[line4, tab4];
        nums[line4, tab4] = temp;
    }
    else
    {
        Console.WriteLine("Так нельзя");
    }
    isCorrectOrder = CheckCorrectOrder(nums);
}
Console.WriteLine("Ура победа");
bool CheckCorrectOrder(int[,] array)
{
    int value = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != value % (w * h))
            {
                return false;
            }
            value++;
        }
    }
    return true;
}
