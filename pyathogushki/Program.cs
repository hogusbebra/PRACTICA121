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
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12},
    {13,14,15,0}
};

int w = nums.GetLength(0);
int h = nums.GetLength(1);


while (nums == nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + "\t");
        }
        
        Console.WriteLine();
    }
    int a = 0;
    Console.WriteLine("На что скипаем?");
    int b = Convert.ToInt32(Console.ReadLine());
    int line3 = -1, tab3 = -1;
    int line4 = -1, tab4 = -1;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            if (nums[i, j] == a)
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
    bool IsWinner(int[,] nums)
    {
        int n = 1;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                if (nums[i, j] != n)
                {
                    return false;
                }
                n = (n + 1) % (w * h);
            }
        }
        return true;
    }


    if (Math.Abs(line3 - line4) + Math.Abs(tab3 - tab4) == 1)
    {
        int temp = nums[line3, tab3];
        nums[line3, tab3] = nums[line4, tab4];
        nums[line4, tab4] = temp;
    }
    else
    {
        Console.WriteLine("Так нельзя");
    }
}

