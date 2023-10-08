public class Solution {
    public int Candy(int[] ratings) {
        int[] left = new int[ratings.Length];
        left[0] = 1;
        for (int i =1; i < ratings.Length; i ++){
            if (ratings[i] > ratings[i - 1]){
                left[i] = left[i - 1] + 1;
            }
            else {
                left[i] = 1;
            }
        }

        Console.Out.WriteLine(String.Join(",",left));

        int[] right = new int [ratings.Length];
        right[ratings.Length -1] = 1;
        for (int i = ratings.Length - 2; i >= 0; i --){
            if (ratings[i] > ratings[i + 1]){
                right[i] = right[i + 1] + 1;
            }
            else {
                right[i] = 1;
            }
        }

        Console.Out.WriteLine(String.Join(",",right));

        int sum = 0;


        for (int i = 0; i < ratings.Length; i ++){
            sum += GetMax(right[i], left[i]);
        }

        return sum;
        
       

       

         //  1 2 3  1  1  1 1
         //  1 1 1  1  3  2 1

            //  1 2 3  1  3  2 1

            // is the left and right higher or equal
            // if yes than give 1 

            // are you higher than the person to the left
            // give yourself one more than them 

            // 
            
        

    }

    public int GetMax(int first, int second){
        if (first > second){
            return first;
        }
        else {
            return second;
        }
    }
}
