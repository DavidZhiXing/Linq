<Query Kind="Statements" />

string serpinskiTrangle = "A";

Func<string,string> transFormA=x=>x.Replace("A","B-A-B");
Func<string,string> markBs=x=>x.Replace("B","[B]");
Func<string,string> transFormB=x=>x.Replace("[B]","A+B+A");

int length = 6;

Enumerable.Range(1, length)
.ToList()
.ForEach(k=>serpinskiTrangle = 
 	transFormB(transFormA(markBs(serpinskiTrangle))));
	
serpinskiTrangle
	.Replace("A", "forward 5" + Environment.NewLine)
		.Replace("B", "forward 5" + Environment.NewLine)
			.Replace("+", " left 60" + Environment.NewLine)
				.Replace("-", "right 60" + Environment.NewLine)
	.Dump("Logo Commands for drawing SerpingSky Triangle");