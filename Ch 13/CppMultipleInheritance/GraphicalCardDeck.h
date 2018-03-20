#pragma once
#include "CardDeck.h"
#include "GraphicalObject.h"

class GraphicalCardDeck : public CardDeck , public GraphicalObject
{
public:
	GraphicalCardDeck(void);
	~GraphicalCardDeck(void);

	virtual void Draw();
	//void Paint();
};