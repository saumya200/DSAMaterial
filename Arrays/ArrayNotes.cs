/* 
1)get(i) ---> returns A[i]
         ---> very fast
         ----> Time complexity : O(1)

2) search(v) ---> checks the array elements i.e 'v' and returns true when A[i] == v;
             ----> Time Complexity : a) Best Case =  when the element is found in first position O(1);
                                     b) Worst Case = when the element is not in first position , and hence we need to scan each and
                                     every element O(n);

3)insert (i, v) ----> insert v at A[i]
                ---> Time Complexity : a) Best Case = when the element is insert at i == Nth position, since no need to shift
                                        the element present in the right side O(1);
                                        b) Worst Case = when the element is insert at i == 0 position, hence there is shifting of
                                       N elements to the right side . O(n);
                

4)remove(i) ---> Time complexity: a) Best Case = when the element is removed at i== N-1 position , since no shifting of N elements 
                                     is required.
                                  b) Worst Case = when the element is removed in position other than Nth position , shifting of elements
                                   is required and hence O(n).


5) Fixed Space issues :

The size of the compact array M is not infinite, but a finite number. This poses a problem as the maximum size may not be known in advance in many applications.

If M is too big, then the unused spaces are wasted.
If M is too small, then we will run out of space easily.


Solution for above fixed space issue problem is creating a VARIABLE SPACE:

----By making M a variable . . So when the array is full, we create a larger array (usually two times larger) and move the elements 
from the old array to the new array. Thus, there is no more limits on size other than the (usually large) physical computer memory 
size.

6) There are various applications that can be done on a Compact (Integer) Array A:

   a) Searching for a specific value v in array A,
   b) Finding the min/max or the k-th smallest/largest value in (static) array A,
   c) Testing for uniqueness and deleting duplicates in array A,
   d) Counting how many time a specific value v appear in array A,
   e) Set intersection/union between array A and another sorted array B,
   f) Finding a target pair x ∈ A and y ∈ A such that x+y equals to a target z,
   g) Counting how many values in array A is inside range [lo..hi], etc.
*/