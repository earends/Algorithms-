class Solution(object):
    def convert(self, s, numRows):
        """
        :type s: str
        :type numRows: int
        :rtype: str
        """
        ans_arr = []
        for i in range(numRows):
            temp = []
            ans_arr.append(temp)
            
        i = j = 0;
        while i < len(s):
            j = 0 # reset j 
            while j < numRows and (j + i) < len(s):
                if j != 0 and j != numRows-1:
                    ans_arr[j].append(s[i + j])
                    tempI = (j + i) + ((numRows - (j + 1)) * 2)
                    if tempI < len(s): 
                        ans_arr[j].append(s[tempI])
                else:
                    ans_arr[j].append(s[i + j])
                j += 1
            if numRows == 1:
                i += 1
            else:
                i+= (numRows + (numRows - 2))
        
        ans = ""
        for i in range(len(ans_arr)):
            ans = ans + ''.join(ans_arr[i])
            
        return ans
                    
