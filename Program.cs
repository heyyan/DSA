// See https://aka.ms/new-console-template for more information

//
using DSA.Search;



//LinearSearch linearSearch = new LinearSearch();
//var res = linearSearch.Search([27, 1, 120, 10, 3, 90, 25, 14, 1, 34, 90, 78], 3);

//var hash = new HashTableSearch();
//var res = hash.Search([27, 1, 120, 10, 3, 90, 25, 14, 1, 34, 90, 78], 3);

//var bin = new BinarySearch();
//var res = bin.Search([1, 1, 3, 10, 14, 21, 25, 27, 79, 90, 90, 120], 3);

//var ter = new TernarySearch();
//var res = ter.Search([1, 1, 3, 10, 14, 21, 25, 27, 79, 90, 90, 120], 120);

//var jmp = new JumpSearch();
//var res = jmp.Search2([1, 1, 3, 10, 14, 21, 25, 27, 79, 90, 91, 120], 91);

//var exp = new ExponentialSearch();
//var res = exp.Search([1, 1, 3, 10, 14, 21, 25, 27, 79, 90, 91, 120], 91);

var fib = new FibonacciSearch();
var res = fib.Search([1, 1, 3, 10, 14, 21, 25, 27, 79, 90, 91, 120], 91);


Console.WriteLine(res);
