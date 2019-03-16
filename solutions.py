class Solution:
    '''
    keep a dictionary of values
    '''
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #create a set to hold all of the values that we have seen 
        s = {}
        #loop through each number if we have seen k - val[i] then return both indeces
        #if not add number to the set 
        for i in range(len(nums)):
            if target-nums[i] in s:
                return [s[target-nums[i]],i]
            else:
                s[nums[i]] = i
                
    '''
    Kepp track of your iterations, when stuff is null ..etc 
    '''
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        #simple addition 
        #keep track of the remainder and the sum 
        r = 0 #remainder
        s = 0 #sum 
        #keep going until both are null 
        ans = ListNode(None)
        #retain pointer to head
        tempans = ans
        while l1 != None or l2 != None:
            #check for first case
            if ans.val != None:
                ans.next = ListNode(None)
                ans = ans.next
            #check to see if one is None intialize start to 0
            templ1 = 0 
            templ2 = 0 
            if l1 != None:
                templ1 = l1.val
            if l2 != None:
                templ2 = l2.val 
            #calculate sum first because you want to use last remainder
            s = (templ1 + templ2 + r) % 10 
            r = (templ1 + templ2 + r) // 10 
           
            ans.val = s
            
            #iterate l1 and l2
            if l1 != None:
                l1  = l1.next
            if l2 != None:
                l2 = l2.next
        if r != 0:
            ans.next = ListNode(None)
            ans = ans.next
            ans.val = r
            
        return tempans
    '''
    keep track of the start, the end will be tracked by your iterations
    always update the dictionary and max_len each time with values previously found
    '''
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        # we are going to store each character and when we saw it in a dictionary 
        chars = {}
        # we are going to constantly be calculating the max_len
        max_len = 0
        start = 0
        for i in range(len(s)):
            #check to see if char is in dictionary 
            if s[i] in chars:
                #make sure we are not updating start to pre start
                start = max(start,chars[s[i]] + 1)
            #no matter what we are either adding or updating to the dictionary
            chars[s[i]] = i
            max_len = max(max_len,i - start + 1)
        
        return max_len
    
    def myAtoi(self, str):
        """
        :type str: str
        :rtype: int
        """
        
        #look for first non white space character
        #takes an optional plus or minus sign
        #followed by as manu numerical digits as possible 
        # then any non number after that is considered bad
        
        nums = {'0':0,'1':1,'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9}
        sign = None
        ans = 0
        num_or_sign = False
        for i in range(len(str)):
            if str[i] in nums or str[i] == '-' or str[i] == '+' or str[i] == ' ':
                #check for signs first
                if str[i] == ' ':
                    continue
                num_or_sign = True
                if str[i] == '-':
                    sign = '-'
                elif str[i] == '+':
                    sign = '+'
                else:
                    ans = (ans * 10) + nums[str[i]]
            else:
                if num_or_sign == False:
                    return 0
        if sign != None:
            if sign == "-":
                ans = ans * -1
        
        return ans
    
    '''
    Think of recursion, think of the iterations luke
    '''
    def longestPalindrome(self, s):
        """
        :type s: str
        :rtype: str
        """
        
        #keep track of start and max_len 
        #store combos in array 
        arr = [[0 for a in range(len(s))] for b in range(len(s))]
        max_len = 0
        start = 0
        #all single chars are palindromes 
        for c in range(len(s)):
            arr[c][c] = True
            max_len = 1
        
        #check for all pal's len 2 
        for d in range(len(s) - 1):
            if s[d] == s[d + 1]:
                #mark the array as True
                start = d
                arr[d][d+1] = True
                max_len = 2
        
        k = 3 #check for palindromes len 3 and above 
        n = len(s)
        while k <= n:
            
            i = 0 #reset 0 to each time so you can start a beginning
            
            while i < n-k + 1:
                j = i + k - 1 # j needs to start 3 spaces out 
                #check to make sure the iteration before hand is 
                if arr[i + 1][j -1] and s[i] == s[j]:
                    arr[i][j] = True
                    
                    if k >= max_len:
                        start = i 
                        max_len = k
                i += 1
            k += 1
        
        #print the answer
        ans = ''
        for e in range(start,max_len + start):
            ans = ans + s[e]
        return ans
    
    def threeSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        ans = []
        for i in range(len(nums)):
            temp = self.twoSumForThreeSum(nums,0-nums[i],i)
            if temp != None:
                temp.insert(0,nums[i])
                ans.append(temp)
        return ans
        
    
    def twoSumForThreeSum(self,nums,target):
        s = set()
        for i in range(len(nums)):
            if  index == i:
                continue
            if target - nums[i] in s:
                return [target - nums[i],nums[i]]
            else:
                s.add(nums[i])
        return None
    
    def letterCombinations(self, digits):
        #error checking
        if len(digits) < 1:
            return []
        #create dctionary to hold numbers 
        phone = {}
        phone['2'] = 'abc'
        phone['3'] = 'def'
        phone['4'] = 'ghi'
        phone['5'] = 'jkl'
        phone['6'] = 'mno'
        phone['7'] = 'pqrs'
        phone['8'] = 'tuv'
        phone['9'] = 'wxyz'
        result = []
        
        self.combos(phone,digits,0,result,'')
        return result
    
    def combos(self,phone,digits,index,result,current_val):
        if index == len(digits):
            return result.append(current_val)
        
        num = phone.get(digits[index]) #ex. abc
        for i in range(len(num)):
            self.combos(phone,digits,index + 1,result,current_val + num[i])
    
    
