public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        // [1,2,3,4,5] gas
        // [3,4,5,1,2] cost
        // startingPoint = 3
        // i = startingpoint = 3
        // accessingarray is i % 5  
        // until = startingpoint + length of array = 3 + 5 = 8 

        // start at 3 
        // gas = 4 
        // cost = 1 
        // 4 - 1 = 3 
        // is > 0 yes 
        // if you get to the last index then you are good 
        int arrLength = gas.Length;
        for (int i = 0; i < arrLength; i ++){
            int result = CanCompleteCircuitIneer(i, gas, cost);
            if (result == arrLength ){
                return i;
            }
            
            else {
                i += result;
            }
        }

        return -1;
    }

    public int CanCompleteCircuitIneer(
        int startingIndex, 
        int[] gas, 
        int[] cost)
    {
        int distanceTraveled = 0;
        // [2,3,4] = gas 
        // [3,4,3] = cost 
        int arrLength = gas.Length;
        int sumGas = 0;
        for (int i = 0; i < arrLength; i ++ )  // 2 < 5 yes
        {
            // 4 + 3 % 5 = 2
            int location = (startingIndex + i) % arrLength;
            sumGas += (gas[location] - cost[location]) ; 
            if (sumGas < 0){ // yes
                return distanceTraveled;
            }
            distanceTraveled += 1;
        }

        return distanceTraveled;
    }
}
