// InvalidCastInCpp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;


class Mammal
{
public:
	void Speak() {cout<<"some noise"<<endl;}
	void GiveBirthToLiveYoung() { cout<<"Give birth"<<endl; }
	void GrowHair() { cout<<"Grow Hair"<<endl;}
};


class Cat : public Mammal
{
public:
	void Purr(){cout<<"puuuuuuuuuuurrrrrrrrrr"<<endl;}
	void Hate() {cout<<"what cats always do"<<endl;}
	void ChaseMice() {cout<<"get dinner"<<endl;}
};

class Dog : public Mammal
{
private:
	char* whatADogSays;

public:
	void PeeOnFireHydrant() { cout<<"Wizz"<<endl; }
	void AttackMailman() {cout<<"Hate on the mailman"<<endl;}
	void Bark() { cout<<whatADogSays<<endl; }

	Dog()
	{
		whatADogSays = "woooof wooooooof woooooooof";
	}
};


int _tmain(int argc, _TCHAR* argv[])
{

	Cat* m = new Cat();

	m->Speak();

	Dog* d = (Dog*)m;

	Mammal* m2 = new Mammal();
	//for(int i = 0; i < 10; i++)
	//{
	//	m2 = new Mammal();
	//}

	d->AttackMailman();
	d->Bark();
	d->GrowHair();
	d->PeeOnFireHydrant();
	d->Speak();
	d->GiveBirthToLiveYoung();

	char c;
	cin>>c;
	return 0;
}

