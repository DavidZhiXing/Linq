<Query Kind="Statements" />

List<KeyValuePair<int,int>> cumSum = new List<KeyValuePair<int,int>>();
var range = Enumerable.Range(1,10);
range.ToList().ForEach(k=>cumSum.Add(
	new KeyValuePair<int,int>(k,range.Take(k).Sum())));
cumSum.Dump("Numbers and \"Cumulative Sum\" at each level");