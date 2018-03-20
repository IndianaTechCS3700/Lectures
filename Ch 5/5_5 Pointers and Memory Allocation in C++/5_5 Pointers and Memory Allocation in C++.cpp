// 5_5 Pointers and Memory Allocation in C++.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

class PlayingCard
{
public:
	void Flip();

private:
	int rank;
	bool isFaceUp;
};

void PlayingCard::Flip()
{
	this->isFaceUp = !this->isFaceUp;
}

void Example1()
{
	PlayingCard* myCard = new PlayingCard();

	delete myCard;
}

void Example2()
{
	PlayingCard* myCard = new PlayingCard();
	// What happens here?
}

void Example3()
{
	PlayingCard* myCard = new PlayingCard();

	delete myCard;

	delete myCard;
	// What happens here?
}

void Example4()
{
	PlayingCard* myCard = new PlayingCard();

	delete myCard;

	// Pretend there is interesting code here

	myCard->Flip();
}

int _tmain(int argc, _TCHAR* argv[])
{
	Example1();

	Example2();

	//Example3();

	Example4();

	return 0;
}