<Query Kind="Statements" />

int[] array = {3,4,3,2,3,-1,3,3,2};
array.ToLookup (a=>a).Where(a=>a.Count()>=
	2).Dump("Repeat");
	