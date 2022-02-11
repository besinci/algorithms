# Selection Sort

![https://programmercave0.github.io/assets/selectionsort.png](https://programmercave0.github.io/assets/selectionsort.png)

### Summary

We check each cell of the array from left to right to determine which value is least. As we move from cell to cell, we keep in a variable the lowest value(its index) we’ve encountered so far. If we encounter a cell that contains a value that is even less than the one in our variable, we replace it so the variable now points to the new index. Once we determined which index contains the lowest value, **we swap that index with the value we began the passthrough with.** 

### Selection Sort in Action

Example of the array: [**4**, 2, 7, 1, 3]

Step #1: We compare the 2 with the lowest value so far(which happens to be 4 - first element of the array).

The 2 is even less than the 4, so it becomes the lowest value so far.

[4, **2**, 7, 1, 3] ⇒ lowest value is 2.

Step #2: We compare the next value the 7 with the lowest value so far. The 7 is greater than the 2, so 2 remains our lowest value:

[4, 2, **7**, 1, 3] ⇒ lowest value is still 2.

Step #3: We compare the 1 with the lowest value so far

[4, 2, 7, **1**, 3] Since the 1 is even less than the 2, the 1 becomes our new lowest value.

[4, 2, 7, **1**, 3] ⇒ lowest value is 1

Step #4: We compare the 3 to the lowest value so far, which is the 1. We’ve reached the end of the array, and we’ve determined that 1 is the lowest value out of the entire array.

Step #5: Since 1 is the lowest value, we swap it with whatever value is at index 0 the index we began this passthrough with:

[**1**, 2, 7, 4, 3]

We have now determined that the 1 is in its correct place within the array.

We are now ready to begin our second passthrough:

The first cell index 0 is already sorted, so this passthrough begins at the next cell, which is index 1. The value at index 1 is the number 2, and it is the lowest value we know so far

[1, **2**, 7, 4, 3]

Step #6: We compare the 7 with the lowest value so far. The 2 is less than the 7, so the 2 remains our lowest value.

Step #7: We compare the 4 with the lowest. It’s less than the 4, so the 2 remains our lowest value.

Step #8: Compare 3 with the lowest value so far. 2 is less than the 3, so 2 remains as the lowest value.

We have reached the end of the array. We don’t need to perform any swaps in this passthrough, and we can therefore conclude that 2 is in its correct spot. The second pass through leaving us with: [**1, 2**, 7, 4, 3]

We now begin passthrough #3:

We begin at index 2 which contains 7. The value 7 is the lowest value so far.

Step #9: We compare 7 with 4. We note that 4 is our new lowest value.

Step #10: We encounter 3, which is even lower than the 4, so the new lowest value is 3.

Step #11: We’ve reached the end of the array, so we swap the 3 with the value that we started out passthrough at, which is the 7:

[**1, 2**, 3, 4, 7]

We now know the 3 is in the correct place within the array.

[**1, 2**, **3**, 4, 7]

We begin the fourth passthrough with the index 3: The 4 is the lowest value so far

Step #12: We compare 4 with 7

The 4 remains the lowest value we’ve encountered in this passthrough so far, so we don’t need any swaps and we know it’s in the correct place.

Since all the cells besides the last one are correctly sorted, that must mean that the last cell is also in the correct order, and our entire array is properly sorted.

[**1, 2**, **3, 4, 7**]

## The efficiency of Selection Sort

Selection sort contains 2 types of steps: comparisons and swaps. 

We compare each element with the lowest number we’ve encountered in each passthrough, and we swap the lowest number into its correct position.

For our example array containing five elements, we had to make a total of ten comparisons.

| Passthrough # | # of comparisons |
| --- | --- |
| 1 | 4 |
| 2 | 3 |
| 3 | 2 |
| 4 | 1 |

Total of 4 + 3 + 2 + 1 = 10 comparisons.

To put in more generally: (N - 1) + (N - 2) + (N - 3) + ... + 1 comparisons.

As swaps we only need to make a maximum of one swap per passthrough. 

Contrast this with Bubble Sort, where in a worst-case scenario—an array in descending order— we have to make a swap for each and every comparison.

## Comparison between Bubble Sort and Selection Sort

| N elements | Max # of steps in Bubble Sort | Max # of steps in Selection Sort |
| --- | --- | --- |
| 5 | 20 | 14 (10 comparisons + 4 swaps) |
| 10 | 90 | 54 (45 comparisons + 9 swaps) |
| 20 | 380 | 199 (180 comparisons + 19 swaps) |
| 40 | 1560 | 819 (780 comparisons + 39 swaps) |
| 80 | 6320 | 3239(3160 comparisons + 79 swaps) |

**It’s clear that Selection Sort contains about half the number of steps that Bubble Sort does, Selection Sort is twice as fast.**