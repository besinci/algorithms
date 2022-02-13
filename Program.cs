using Algorithms.SearchAlgorithms;
using Algorithms.SortAlgorithms.BubbleSort;
using Algorithms.SortAlgorithms.SelectionSort;

Console.WriteLine("Hello, Algorithms!");

// Binary Search
var orderedArray = new[] {11, 47, 74, 79, 82, 95, 99, 127, 178};
var lookingNumber = 47;
var binarySearchResult = BinarySearch.Search(orderedArray, lookingNumber);
//

// Bubble Sort
var bubbleSortArr = new[] {23, 1, 24, 7, 3, 66, 76, 21, 2, 4};
var bubbleSortResult = BubbleSort.Sort(bubbleSortArr);
//

// Selection Sort
var selectionSortArr = new[] {3, 7, 1, 4};
var selectionSortResult = SelectionSort.Sort(selectionSortArr);
//

Console.ReadLine();

