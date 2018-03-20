// 5_4 Object Creation in C++.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

class PlayingCard
{
public:
	PlayingCard(int newRank, bool isNewCardFaceUp);
private:
	int rank;
	bool isFaceUp;
};

PlayingCard::PlayingCard(int newRank, bool isNewCardFaceUp)
{
	rank = newRank;
	isFaceUp = isNewCardFaceUp;
}

int _tmain(int argc, _TCHAR* argv[])
{
	// create a stack variable for a playing card and allocate memory for it
	PlayingCard myCard(3, false);

	// create a pointer for a playing card, not the card itself
	PlayingCard* anotherCard;

	// create a pointer and allocate memory for it.
	PlayingCard* otherCard = new PlayingCard(5, false);

	return 0;
}