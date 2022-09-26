<Query Kind="Statements" />

int n = 20;
List<int> numbers = Enumerable.Range(1,100).ToList();
List<int> nthElements = new List<int>();
Enumerable.Range(0,numbers.Count()/n)
	.ToList()
	.ForEach(k => nthElements.Add(numbers.Skip(k*n).First()));
nthElements.Dump();