# Buble Sort

### Summary

Is a very basic sorting algorithm and follows these steps:

1 - Point to two consecutive items in the array. (Initially, we start at the very beginning of the array and point to its first two items)

[ 2, 1, 3, 5]  pointers → (2,1)

2 - If two items are out of order (in other words the left value is greater than the right value) **swap** them.

[ 1, 2, 3, 5 ]  swap → (2,1) —> (1,2)

(if they already happen to be in the correct order, do nothing for this step)

3 - Move the ‘pointers’ one cell to the right:

[ 1, 2, 3, 5 ] pointers → (2,3) 

Repeat steps 1 and 2 until ve reach the end of the array of items that have already been sorted.

### Buble Sort in Action

Our starting array: [4, 2, 7, 1, 3]

Step #1: First we compare 4 and 2 . They are out of order.

Step #2: So we **swap** them [2, 4, 7, 1, 3]

Step #3: Next, we compare 4 and 7. They are in the correct order. So we don’t need to perform swaps.

Step #4: We now compare 7 and 1. 

Step #5: They are out of order so we **swap** them. [2, 4, 1, 7, 3]

Step #6: We compare 7 and 3.

Step #7: They are out of order so swap them. [2, 4, 1, 3, 7]

**We now know for a fact that 7 is in its correct position. Because we kept moving it along to the right until it reached its proper place.**

**This is the reason that this algorithm is called Bubble Sort. In each pass-through the highest unsorted value “bubbles” up to its correct position.**

Since we made at least one swap, we need to conduct another one.

**Begin Passthrought #2:** [2, 4, 1, 3, **7**]

Step #8: [2, 4, 1, 3, **7**] pointers → (2, 4) ⇒ they are in correct order, so move on.

Step #9: [2, 4, 1, 3, **7**] pointers → (4, 1) ⇒ out of order.

Step #10: swap ⇒ [2, 1, 4, 3, **7**]

Step #11: [2, 1, 4, 3, **7**] pointers → (4, 3) ⇒ out of order.

Step #12: swap ⇒ [2, 1, 3, **4**, **7**]

- We don’t have to compare the 4 and 7 because we know that the 7 is already in its correct position and we also know 4 is bubbled up to its correct position.

We now begin Passthrought #3:

Step #13: [2, 1, 3, **4**, **7**] pointers ⇒ (2, 1) ⇒ out of order.

Step #14: swap ⇒ [1, 2, 3, **4**, **7**]

Step #15: [1, 2, 3, **4**, **7**] pointers ⇒ (2, 3) ⇒ in order, no swap.

- We now know the 3 has bubbled up to its correct spot. Since we swapped in this passthrough we need to perform another one.

**Passthrough #4:**

Step 16: [1, 2, **3**, **4**, **7**] pointers ⇒ (1, 2) ⇒ They are in order, no swap.

- We can end the passthrough since all remaining values are already sorted. Now we made a passthrough that didn’t require swaps. We know our array is completely sorted.

[**1, 2, 3**, **4**, **7**]

### Efficiency of Bubble Sort

This algorithm contains two kinds of steps.

- Comparison: Two numbers are compared to determine which is greater.
- Swaps: Two numbers swapped with one another.

**How many comparisons take place Bubble Sort?**

Out example has 5 elements #1 passthough had 4 comparisons #2 passthrough 3 comparisons ...etc. 

So that’s 4 + 3 + 2 + 1 = 10 comparisons to put more generally we make (N - 1) + (N - 2) + (N - 3)... + 1 comparisons.

**How many swaps?**

In the worst case if the array is in reverse order with 10 elements. We have  9+8+7+6+5+4+3+2+1=45 swaps.

And in an array with 20 elements, we have 19+18+17+16.....+3+2+1=190 comparisons.

Notice the inefficiency here, as the number increase the number of steps grows exponentially.

| N data element | Max of Steps |
| --- | --- |
| 5 | 20 |
| 10 | 90 |
| 20 | 380 |
| 40 | 1560 |
| 80 | 6320 |

If you look precisely at the growth of steps as N increases, you will see it’s growing by approximately N².

| N data elements | #of Bubble Sort steps | N² |
| --- | --- | --- |
| 5 | 20 | 25 |
| 10 | 90 | 100 |
| 20 | 380 | 400 |
| 40 | 1560 | 1600 |
| 80 | 6320 | 6400 |

**Therefore, in BIG O NOTATION, we would say Bubble Sort has the efficiency of O(N²)**

O(N²) is considered to be a relatively inefficient algorithm, since data increases, the steps increase dramatically.

*one last note O(N²) also referred to **quadratic time.**

**When you see a nested loop, O(N²) alarm bells should start in your head.**