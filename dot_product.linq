<Query Kind="Statements" />

int[] v1 = {1, 2, 3};
int[] v2 = {3, 2, 1};

v1.Zip(v2, (a, b) => a * b ).Dump("dot product");