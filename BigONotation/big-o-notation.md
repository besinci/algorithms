# Big O Notation

We can’t simply label one algorithm a ‘22 step algorithm’ and another a ‘400 step algorithm’. This is because the number of steps that an algorithm takes cannot be pinned down to a single number. For example Linear Search if the array contains 22 elements linear search will take 22 steps. If the array has 400 elements -it takes 400 steps.

So the more accurate way to say quantify efficiency of Linear Search is to say that it would take **N steps** for **N elements** in the array.

### Big O: Count the steps

Instead of focusing on units of time Big O archives consistency by focusing **only in the number of steps** that an algorithm takes.

Reading from an array take just one step, no matter how large the array is. **0(1)** - pronounce ‘Big Oh of 1’. Today’s hardware it may take just a nanosecond but in both cases the algorithm takes just a single step.

For N elements in the array, linear search can take up to a maximum number of N steps.

**O(N)** - pronounce ‘Oh of N’.

O(N) is the ‘Big O’ way of saying that for N elements inside an array, the algorithm would take N steps to complete.

### Constant time vs Linear Time

Another way of saying this is that **Big O answers the following question: How does the number of steps change as the data increases.**

When an array increases in size by one element, O(N) algorithm will increase bye one step. An algorithms that is O(1) will take the same number if steps no matter how large the array gets.

O(1) is the way to describe any algorithm that doesn’t change its number of steps even when data increases.

**Big O Notation generally refers to worst-case scenario unless specified otherwise.**

This is why linear search will describe O(N). It can be O(1) in a best-case scenario.

The reason for this ‘pessimistic’ approach can be useful tool: knowing exactly how inefficient an algorithm can get.

In Big O, we describe Binary Search as having a time complexity of **O(log N)** - pronounce ‘Oh of log N’ —also known as **complexity of log time.**

### O(log N)

An algorithm that increases one step each time the data is doubled. As we learned Binary Search does just that.

To Understand O(log N) you need to understand what [logarithms](https://www.notion.so/Logarithm-feeae60ca23643e8b0206a8a72eb6589) are.

Whenever we say O(log N) It’s actually shorthand for saying 0(log₂ N). We are just omitting that small 2 for convenience.

O(log N) means that for N data elements, the algorithms would take log₂ N steps. If there are 8 elements in the array the algorithms would take 3 steps since log₂ = 3.

Another way saying **if we keep dividing the 8 elements in half, it would take us 3 steps until we end up with 1 element.**

This is exactly what happens in Binary Search.

Demonstrate diff between O(N) and O(log N)

| N elements | O(N) | O(log N) |
| --- | --- | --- |
| 8 | 8 | 3 |
| 16 | 16 | 4 |
| 32 | 32 | 5 |
| 64 | 64 | 6 |
| 128 | 128 | 7 |
| 256 | 256 | 8 |

**While O(N) algorithms takes as many steps as there are data elements. The O(log N) algorithms takes just one additional step every time the data elements are doubled.**

## Ignoring Constants

In the world of Big O Selection Sort and Bubble Sort are described in the same way O(N²).

Again → Big O describes how many steps are required to the number of data elements.

So Selection Sort is roughly half of whatever N² is. It would reason that we’d describe the efficiency of Selection Sort as O(N² / 2).

In reality, however, Selection Sort is described in Big O as O(N²) just like Bubble Sort.

This is because the major rule of Big O. **Big O ignores constants.**

In our case technically O(N² / N) becomes simply O(N²).

Even O(100N) which is 100 times slower than O(N) would be referred to as O(N).

## The role of Big O

The purpose of Big O is that in different classifications there will be a point at which one classification supersedes the other in speed, and will remain faster forever. When that point occurs exactly, however, is not the concern of the Big O.

Because of this, there is no such a thing as O(100N)— it is simply written as O(N).

Similarly with large amounts of data O(log N) will always be faster than O(N), even if given O(log N) algorithm is O(2 * log N) under the hood.

So Big O is an extremely useful tool because if two algorithms fall under different classifications of Big O.

You’ll generally know which algorithm to use since, with large amounts of data, one algorithm is guaranteed to be faster than the other at a certain point.

**However, the main takeaway of this chapter is when two algorithms fall under the same classification of Big O, it doesn’t necessarily mean that both algorithms process at the same speed.**

After all Bubble Sort is twice as slow as Selection Sort even though both are O(N²).
