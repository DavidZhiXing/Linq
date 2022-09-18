<Query Kind="Statements" />

string algae="A";
Func<string,string> transFormA=x=>x.Replace("A","AB");
Func<string,string> markBs=x=>x.Replace("B","[B]");
Func<string,string> transFormB=x=>x.Replace("[B]","A");
int length=7;
Enumerable.Range(1,length).ToList().ForEach(
	k=>algae=transFormB(transFormA(markBs(algae))));
	
algae.Dump("Algae at 7th Iteration");