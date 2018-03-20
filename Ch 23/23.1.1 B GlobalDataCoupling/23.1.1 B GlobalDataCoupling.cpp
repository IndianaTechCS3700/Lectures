// 23.1.1 B GlobalDataCoupling.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>


int todaysDow;

class DowReader
{
public: void ReadDow()
	{
		// Get the current value of the Dow from
		// a web service
		todaysDow = 7656;
	}
};

class DowPrinter
{
public: void WriteDow()
		{
			std::cout<<"Today's DJIA is "<<todaysDow<<std::endl;

		}
};

int _tmain(int argc, _TCHAR* argv[])
{
	DowReader dr;
	DowPrinter dp;

	dr.ReadDow();
	dp.WriteDow();


	char x;
	std::cin>>x;
	return 0;
}

//
// C# doesn't let you have value types declared outside of a class
//

