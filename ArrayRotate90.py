'''
Rotate an array 90 degrees
'''

def Rotate90(arr):
    l = len(arr)
    for i in range(l//2):
        for j in range(i,l-i-1):
            #top left goes to temp 
            temp = arr[i][j]
            #top right goes to top left
            arr[i][j] = arr[j][l-1-i]
            #bottom right goes to top right
            arr[j][l-1-i] = arr[l-1-i][l-1-j]
            #bottom left goes to bottom right
            arr[l-1-i][l-1-j] = arr[l-1-j][i]
            #temp goes to bottom left 
            arr[l-1-j][i] = temp
    return arr

def PrintArrFromRotate(arr):
    Rotate90(arr)
    for i in range(len(arr)):
        for j in range(len(arr)):
            print(arr[i][j]),
        print ''  
          