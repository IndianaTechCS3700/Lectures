// Sample4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Parent 
{
public:
	void example (int a) 
	{ 
		cout<<"in parent method"<<endl; 
	}
};

class Child : Parent 
{
public:
	void example (int a, int b)
	{ 
		cout<<"in child method"<<endl; 
	}
};


int _tmain(int argc, _TCHAR* argv[])
{
	Child *aChild = new Child();
	//aChild->example(3);


	cout<<"Press Any Key to Continue"<<endl;
	char x;
	cin>>x;
	return 0;
}

