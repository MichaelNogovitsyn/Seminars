// алгоритм сортировки выбором min->max
// 7 2 3 4 5 1 2 3
using static Sorting;
using static Infrastracture;

/* int[] array = CreateArray(10);
Print(array);
SortSelection(array);
Print(array); */

//1 var
int[] ar=10.CreateArray(min:10,max:50);
ar.Print();
ar.SortSelection();
ar.Print();

//2 var
10.CreateArray(min:10,max:50)
.Print()
.SortSelection()
.Print();