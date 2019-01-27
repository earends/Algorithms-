import bubbleSort as b
import MergeSort as m 
import ArrayRotateLeft as a 
import ArrayRotate90 as a90
import Common as c
import Test

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

