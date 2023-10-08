public class Solution {
    public int Trap(int[] height) {
        int[] maxLeftArray = new int[height.Length];
        int maxLeft = 0;
        maxLeftArray[0] =0;
        for (int i =1; i < height.Length; i ++){
            int m = GetMax(maxLeft, height[i-1]);
            Console.WriteLine($"m:{m}, i:{i}, height i-1:{height[i - 1]}");
            maxLeft = m;
            maxLeftArray[i] = m;
        }

        Console.WriteLine(String.Join(",",maxLeftArray));

        int[] maxRightArray = new int[height.Length];
        int maxRight = 0;
        maxRightArray[height.Length - 1] =0;
        for (int i =height.Length - 2; i >= 0; i --){
            int m = GetMax(maxRight, height[i + 1]);
            maxRight = m;
            maxRightArray[i] = m;
        }

        Console.WriteLine(String.Join(",",maxRightArray));

        int sum = 0;
        for (int i =0; i < height.Length; i ++){
            int r = GetMin(maxLeftArray[i],maxRightArray[i]) - height[i];
            if (r > 0){
                sum += r;
            }
        }

        return sum;
    }

    public int GetMax(int a, int b)
    {
        if (a > b){
            return a;
        }
        else {
            return b;
        }
    }

    public int GetMin(int a, int b)
    {
        if (a < b){
            return a;
        }
        else{
            return b;
        }
    }
}
