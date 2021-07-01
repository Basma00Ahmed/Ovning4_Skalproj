1. Stack is used for static memory allocation and Heap for dynamic memory allocation. 
The Stack is responsible for keeping track of what's executing in our code (or what's been "called").  The Heap is responsible for keeping track of our objects (our data).

2. Value Type:
Value type variables can be assigned a value directly.
Reference Type:
It refers to a memory location. Using multiple variables, the reference types can refer to a memory location
A reference type is always stored on the heap. While Value types, are stored where they are declared.
Thus, value types can be stored both on the stack or the heap.

3. In first X  value type is declared in a method, which is added to the stack.
In second X  reference type is declared in a class, which is added to the heap.

Exercise 1:
2. if Count of elements equal to or exceeds Capacity of list, then the Capacity will increase automatically.
3. By doubling the size of capacity (underlying array).
4. This is because it is more efficient to allocate a bigger chunk of memory some of the time than to allocate memory for one more item every time you add one.
5.No, Use TrimExcess () method to decrease capacity of list.
6. it will improve the performance by avoiding the overhead of resizing the ArrayList by estimating or finding the exact size of the ArrayList beforehand.

Exercise 3.
It is not so smart to use a stack in the ICA queue because of we should follow the concept of first come first service but the stack concept is last come first service (last in, first out).

Exercise 6.
Recursion uses more memory compared to iteration because every time the recursive function is called, the function call is stored in stack.
