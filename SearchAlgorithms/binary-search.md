# Binary Search

Think binary search as a guessing game we were playing when we were kids. For example, I want you to guess a number from 1 to 100 and when you guess I will say to you it is **greater** or **smaller** than your guess. Most important think about binary search if you want to use it you need a sorted array. If your array is not sorted it will not work.

**Big O Notation: O(log N)**

![Binary Search](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/372e30dd-833e-4cde-8c97-22eab353e812/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220201%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220201T201943Z&X-Amz-Expires=86400&X-Amz-Signature=2ad79510bf59b6785881b87ecd59f45f9cb2439fb94920af91ab2c279a891453&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22&x-id=GetObject)

### Binary Search vs Linear Search

With an array of one hundred values here are the maximum numbers of steps it would take for each type of search.

- Linear Search: One hundred steps
- Binary Search: Seven steps

With an array of 10.000 elements, a linear search can take to 10.000 steps while a binary search takes up to **a maximum of thirteen steps**.

Keep in mind: Ordered arrays aren’t faster in every aspect. Insertion in the ordered array is slower than in standard arrays.

**Trade-off**: Slower Insertion - Faster Search.

You must analyze your app to see what is better fit for you.
