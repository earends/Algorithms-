'''
Array Rotate Left
Input arr - array of n intengers
      d   - number of times to shift left
'''
def arrRotateLeft(arr,d):
    l = len(arr)
    tempArr = []
    for i in range(l):
        tempArr.append(0)
    for i in range(l):
        # switch the (-) to a (+) to do a right rotation
        tempArr[(i + (l - d)) % l] = arr[i]

    return tempArr
