using System;

public class Program
{
    public static int operation_(int[] height)
    {
        int n = height.Length;
        if (n <= 2)
            return 0;

        int left = 0;
        int right = n - 1;
        int leftMax = 0;
        int rightMax = 0;
        int water = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] > leftMax)
                    leftMax = height[left];
                else
                    water += leftMax - height[left];

                left++;
            }
            else
            {
                if (height[right] > rightMax)
                    rightMax = height[right];
                else
                    water += rightMax - height[right];

                right--;
            }
        }

        return water;
    }

    public static void Main()
    {
        //int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }; //6 Ok
		//int[] height = { 0,2,3,0,1,2,5 }; //6 (TEST1 OK)
		int[] height = { 3,0,2,0,4,2,5 }; //9 (TEST2 OK)
		int result = operation_(height);
        Console.WriteLine(result);
    }
}