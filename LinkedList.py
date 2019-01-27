class Node:
    def __init__(self, d):
        self.data = d
        self.next = None

class LinkedList:
    def __init__(self): 
        self.head = None

    def printList(self,head):
        while head.next != None:
            print head.data
            head = head.next
        print head.data     
   
    '''
    function ReverseLinkedList
    head - head of linked list
    d - reverse the list after every d'th iteration 
    for ex. 1 -> 2 -> 3 -> 4 -> 5 and d = 2
    output: 2 -> 1 -> 4 -> 3 -> 5 
    '''
    def reverseLinkedList(self,head,d):
        current = head 
        next = None
        previous = None 
        count = 0 
        while current != None and count < d:
            next = current.next 
            current.next = previous 
            previous = current
            current = next 
            count += 1 

        if next != None: 
            head.next = self.reverseLinkedList(next,d)
        
        return previous

