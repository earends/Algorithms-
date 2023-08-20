public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int mc = m-1;
        int nc = n-1;
        int ec = m + n - 1;

        while (mc >= 0 && nc >= 0){
            if (nums1[mc] >= nums2[nc]){
                nums1[ec] = nums1[mc];
                ec -=1;
                mc -=1;
            }
            else {
                nums1[ec] = nums2[nc];
                ec -=1;
                nc -=1;
            }
        }
        
        while (nc >= 0){
            nums1[ec] = nums2[nc];
            ec -=1;
            nc -=1;
        }
    }
}
