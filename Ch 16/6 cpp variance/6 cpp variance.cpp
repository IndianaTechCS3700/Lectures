// 6 cpp variance.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

class King
{
public:
	virtual King* Clone()
	{
		King* k = new King();
		return k;
	}
};

class Prince : public King
{
public:
	Prince* Clone()
	{
		Prince* p = new Prince();
		return p;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	Prince* p = new Prince();
	King *k = new Prince();

	Prince* p2 = p->Clone();

	King* k1 = k->Clone();

	return 0;
}

