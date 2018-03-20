// Sample6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

void Example(int w, int x, int y = 3, int z = 4, char zz = 'c')
{
	cout<<w<<x<<y<<z<<endl;
}

int _tmain(int argc, _TCHAR* argv[])
{
	Example(1, 2);
	Example(2, 4, 6);
	Example(2, 4, 6, 8);
	Example(1, 2, 'd');

	char x;
	cin>>x;
	return 0;
}