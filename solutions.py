class Solution:
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
    
    
