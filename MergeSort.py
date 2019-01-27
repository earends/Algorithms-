def MergeSort(arr):
    if len(arr) > 1:
        #find the middle
        middle = len(arr)//2             
        #temp arrays of left and right
        tempArrL = arr[:middle]
        tempArrR = arr[middle:]     
        MergeSort(tempArrL)            
        MergeSort(tempArrR)            
        merge(arr, tempArrL, tempArrR)                        
    
    

def merge(arr,tempArrL,tempArrR):

    l = 0 # l tracks the left array index
    r = 0 # j tracks the right array index
    k = 0 # k tracks the original array index
    
    while l < len(tempArrL) and r < len(tempArrR):
        if tempArrL[l] < tempArrR[r]:
            arr[k] = tempArrL[l]
            l += 1
        else:
            arr[k] = tempArrR[r]
            r +=1 
        k += 1
    #check if anything is left over from the left array 
    while l < len(tempArrL):
        arr[k] = tempArrL[l]
        l += 1
        k += 1
    #check if anything is left over from the right array 
    while r < len(tempArrR):
        arr[k] = tempArrR[r]
        r += 1 
        k += 1


 




