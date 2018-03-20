// 23.1.4 A ClassLevelVsObjectLevelVisibility.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

class Changeling
{
private:
	int m_myValue;

public:
	void ChangeMe(int newValue)
	{
		this->m_myValue = newValue;
	}

	void ChangeOther(Changeling other, int newValue)
	{
		other.m_myValue = newValue;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	Changeling first;
	Changeling second;

	//first.m_myValue = 6;
	first.ChangeMe(7);
	second.ChangeOther(first, 8);

	return 0;
}

