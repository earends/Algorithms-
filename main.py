import bubbleSort as b
import MergeSort as m 
import ArrayRotateLeft as a 
import ArrayRotate90 as a90
import Common as c
import Test
import LinkedList as l

'''
Sample Function to generate Node List
'''
def GenerateNodeList():
    myList = l.LinkedList()
    n1 = l.Node(1)
    n2 = l.Node(2)
    n3 = l.Node(3)
    n4 = l.Node(4)
    n5 = l.Node(5)
    n6 = l.Node(6)
    n7 = l.Node(7)
    n8 = l.Node(8)
    n9 = l.Node(9)
    n1.next = n2
    n2.next = n3 
    n3.next = n4
    n4.next = n5 
    n5.next = n6 
    n6.next = n7 
    n7.next = n8 
    n8.next = n9
    myList.head = n1
    return myList



arr = [1,5,2,6,3,7,4,8,10,9]
print('Starting Arry: ')
print arr 
print('Bubble Sorted: ')
print b.BubbleSort(arr)
arr = [1,5,2,6,3,7,4,8,10,9] #make sure array stays unsorted
print('Merge Sorted: ')
m.MergeSort(arr)
print arr
print 'array rotated'
print a.arrRotateLeft(arr,1)
print 'array rotated 90 degrees'
a = [[1,2,3,4],[5,6,7,8],[9,10,11,12],[13,14,15,16]]
print 'Starting Array before 90 degree rotation'
c.Print2DArray(a)
print '------------'
a90.PrintArrFromRotate(a)
print 'new list'
n = GenerateNodeList()
n.printList(n.head)
print 'List printed'
head = n.reverseLinkedList(n.head,3)
n.printList(head )


