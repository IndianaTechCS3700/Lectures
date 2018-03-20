#include "stdafx.h"
#include <iostream>
using namespace std;

#include "CardDeck.h"
#include "GraphicalObject.h"
#include "GraphicalCardDeck.h"

// Call the methods directly in the respective base classes
void BaseClassCalls()
{
	CardDeck cardDeck;
	cardDeck.Draw();

	GraphicalObject go;
	go.Draw();
}

// Try to call the method in the child class
void ChildClassCall()
{
	GraphicalCardDeck gcd;
	gcd.Draw();
	//gcd.Paint();
}

//void SubstitutionCalls()
//{
//	GraphicalCardDeck* gcd = new GraphicalCardDeck();
//	CardDeck* cd = gcd;
//	GraphicalObject* go = gcd;
//
//	cd->Draw();
//	go->Draw();
//	gcd->Draw();
//}

int _tmain(int argc, _TCHAR* argv[])
{
	//BaseClassCalls();
	ChildClassCall();
	//SubstitutionCalls();

	char x;
	cin>>x;

	return 0;
}