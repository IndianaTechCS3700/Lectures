// 23.3.3 Friends.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Matrix;

class Vector
{
private:
	float v[4];

	friend Vector Multiply (Matrix m, Vector v);
};

class Matrix
{
private:
	Vector vec[4];

	friend Vector Multiply (Matrix m, Vector v);
};

Vector Multiply(Matrix m, Vector v)
{
	Vector r;

	for (int i = 0; i<4; i++)
	{
		r.v[i] = 0;
		for (int j = 0; j < 4; j++)
		{
			r.v[i] += m.vec[i].v[j] * v.v[j];
		}
	}

	return r;
}

int _tmain(int argc, _TCHAR* argv[])
{
	Vector myVec;
	//myVec.v = 7;

	Matrix m;
	//m.vec[0] = myVec;

	char bucket;
	cin>>bucket;
	return 0;
}