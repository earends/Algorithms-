import bubbleSort as b
import MergeSort as m 
import ArrayRotateLeft as a 


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

