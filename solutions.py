'''
Algorithms included:
-twosum
-add two nums
-longest substring without repeating chars 
-longest palindromic substring
-string to integer atoi
-3sum wihtout distinct
-letter combinations
-valid parenthesis
-merge two sorted lists
-merge k sorted lists
-level order
- subset 
- rotate 
- group annograms
-validate bst
-maxprofit
'''
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
            
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        #create a stack to hold the order of elements
        stck = []
        #create a dictionary to check 
        d = {')':'(',']':'[','}':'{'}
        
        for i in range(len(s)):
            #check for closing bracket
            if s[i] in d:
                #check to make sure value opening matches closing
                if len(stck) == 0 or stck.pop() != d[s[i]]:
                    return False
                
            else:
                #add to stack 
                stck.append(s[i])
        #check to make sure stack is empty 
        if len(stck) != 0:
            return False
        return True
    
    def mergeTwoLists(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        if l1 == None and l2 == None:
            return None
        l3 = ListNode(None)
        #keep pointer to head
        temp = l3 
        while l1 != None and l2 !=None:
            #if l3 val is None first case
            if l3.val != None:
                l3.next = ListNode(None)
                l3 = l3.next
            #compare values and assign l3 val
            if l1.val < l2.val:
                l3.val = l1.val
                l1 = l1.next
            else:
                l3.val = l2.val
                l2 = l2.next
        #get the last ends
        while l1 != None:
            if l3.val != None:
                l3.next = ListNode(None)
                l3 = l3.next
            l3.val = l1.val
            l1 = l1.next
        while l2 != None:
            if l3.val != None:
                l3.next = ListNode(None)
                l3 = l3.next
            l3.val = l2.val
            l2 = l2.next
        
        return temp
    
    
    def mergeKLists(self, lists: List[ListNode]) -> ListNode:
        if len(lists) == 0:
            return lists
        newList = ListNode(None)
        temp = newList
        listsHaveItems = True
        smallest = 0
        while smallest != None:
            smallest = None
            smallestIndex = None
            #O of len(Lists)
            for i in range(len(lists)):
                if lists[i] == None:
                    continue
                if smallest == None or lists[i].val < smallest:
                    smallest = lists[i].val
                    smallestIndex = i
            #if no smallest all lists are empty return None
            if smallest != None:
                #check to see if beginning of new list
                if newList.val != None:
                    newList.next = ListNode(None)
                    newList = newList.next
                #add smallest to list
                newList.val = smallest
                #iterate list smalltest came from 
                lists[smallestIndex] = lists[smallestIndex].next
            
        return temp
    
    def levelOrder(self, root: TreeNode) -> List[List[int]]:
        arr = []
        if root:
            self.level(root,0,arr)
        
        return arr
            
    def level(self,root, height, arr):
        if len(arr) == height:
            arr.append([])
        if root != None:
            arr[height].append(root.val)
        if root.left:
            self.level(root.left,height + 1,arr)
        if root.right:
            self.level(root.right,height + 1,arr)
    '''
    trapping rain water
    solution incomplete
    idea is solid
    '''
    def trap(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        ans = 0
        #cant trap any on last and first element
        for i in range(1,len(height) - 1):
            temp = self.getMaxLeftRight(height,i)
            if temp[0] != -1 and temp[1] != -1:
                ans += min(temp[0],temp[1]) - height[i]
        return ans
            
    def getMaxLeftRight(self,arr,index):
        left = index - 1
        leftMax = -1
        right = index + 1
        rightMax = -1
        while left > 0:
            if arr[left] > arr[index]:
                leftMax = max(leftMax,arr[left])
                left -= 1
        while right < len(arr):
            if arr[right] > arr[index]:
                rightMax = max(rightMax,arr[right])
                right += 1
        return [leftMax,rightMax]
    
    def rotate(self, matrix):
        """
        :type matrix: List[List[int]]
        :rtype: None Do not return anything, modify matrix in-place instead.
        """
        l = len(matrix[0])
        for i in range(l//2): 
            #start at i for depth
            for j in range(i,l-i-1):
                t = matrix[i][j]
                #bottom left goes to top left
                matrix[i][j] = matrix[l-j-1][i]
                #bottom right goes to bottom left
                matrix[l-j-1][i] = matrix[l-i-1][l-j-1]
                #top right goes to bottom right
                matrix[l-i-1][l-j-1] = matrix[j][l-i-1]
                #top left goes to top right
                matrix[j][l-i-1] = t
            
    def subset(arr):                  
        max_len = 2 ** len(nums)
            ans = []
            for i in range(max_len):
                temp = []
                for j in range(len(nums)):
                    if (i & (1 << j)) > 0:
                        temp.append(nums[j])
                ans.append(temp)
            return ans  
        
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        d = {}
        ans = []
        '''
        sorted: [unsorted]
        '''
        for i in range(len(strs)):
            temp = ''.join(sorted(strs[i]))
                
            if temp in d:
                d[temp].append(strs[i])
            else:
                d[temp]= [strs[i]]
                
        #iterate through dictionary 
        for x in d:
            ans.append(d[x])
        return ans
    
    def isValidBST(self, root: TreeNode) -> bool:
    
        return self.isBST(root,-132312414242342,34242432423424)
    def isBST(self,Node,mini,maxi):
        if not Node:
            return True
        #first condition cant be false
        #set big enough values
        if Node.val < mini or Node.val > maxi: 
            return False

        return (self.isBST(Node.left, mini, Node.val-1) and self.isBST(Node.right, Node.val+1, maxi))
    
    def maxProfit(self, prices: List[int]) -> int:
        minprice = 1000000000
        max_val = 0
        for i in range(len(prices)):
            #if you get 10 nums 10,9,8..0 your always selling at a loss
            if prices[i] < minprice:
                minprice = prices[i]
            else:
                #sell if it makes you more money, dont otherwise 
                max_val = max(max_val,prices[i] - minprice)
        return max_val
    
    def ladderLength(self, beginWord: str, endWord: str, wordList: List[str]) -> int:
        if endWord not in wordList or not endWord or not beginWord or not wordList:
            return 0 
        #do the preprocessing 
        all_combos = {}
        l = len(beginWord)
        for i in range(len(wordList)):
            for j in range(l):
                temp = wordList[i][:j] + "*" + wordList[i][j+1:]
                if temp in all_combos:
                    all_combos[temp].append(wordList[i])
                else:
                    all_combos[temp] = [wordList[i]]
        
        
        q = [(beginWord,1)]
        #keep visited to prevent cycles
        visited = {beginWord:True}
        #while the queue is not empty, empty means no match 
        while q:
            #pop the current word
            t = q.pop(0)
            #split the word and len 
            
            tw = t[0]
            tlen = t[1]
            #find transformation of popped word
            for a in range(l):
                tempForm = tw[:a] + "*" + tw[a+1:]
                
                #for each word that is found as a combo
                if tempForm in all_combos:
                    #for each found matching word
                    for w in all_combos[tempForm]:
                        #if matching word is endWord
                        if w == endWord:
                            return tlen + 1
                        #if matchingWord has not been visited yet
                        #append the visited word to the queue
                        if w not in visited:
                            visited[w] = True
                            q.append((w,tlen+1))
                    #clear the dictionary 
                    all_combos[tempForm] = []

                
        return 0 
