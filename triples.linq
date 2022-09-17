<Query Kind="Statements" />

Enumerable.Range(2,10)
	.Select(c => new { Length = 2*c, height= c*c - 1, Hypotenuse = c*c + 1})
	.Dump("pythogorean triples");