class Solution(object):
    '''
    zigzag converter
    PAYPALISHIRING , NUMROWS = 3
    P   A   H   N
    A P L S I I G
    Y   I   R
    RETURN PAHNAPLSIIGYIR
    '''
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
    '''
    reverse integer
    '''
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        
        #convert to string
        str_num = str(x)
        negative = False
        l = 0
        if str_num[0] == '-':
            negative = True
            l = len(str_num) - 1
            str_num = str_num[1:]
        else:
            l = len(str_num)
        str_num = str_num[::-1]
        if int(str_num) > (2**31) - 1:
            return 0 
        else:
            if negative:
                return int(str_num) * -1
            else:
                return int(str_num)
            
  def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """
        str_x = str(x)
        reverse_x = str_x[::-1]
        l = len(str_x) // 2
        for i in range(l):
            if str_x[i] != reverse_x[i]:
                return False
            
        return True
    
   #permutations
    def permute(self, nums):
        results = []
        self.permuteRec([], nums, results)
        return results
        
    def permuteRec(self, current, remaining, results):
        if len(remaining) == 0: 
            results.append(current)   
        else:
            for i in remaining:
                new_remaining = [x for x in remaining if x != i]
                self.permuteRec(current + [i], new_remaining, results)
                    
