<Query Kind="Statements" />

List<double> numbers=new List<double>(){1,2,3,4};
List<double> movingAvgs=new List<double>();
int windowsSize= 2;
Enumerable.Range(0,numbers.Count - windowsSize+1)
	.ToList()
	.ForEach(k=>movingAvgs.Add(numbers.Skip(k).Take(windowsSize).Average()));
	movingAvgs.Dump();