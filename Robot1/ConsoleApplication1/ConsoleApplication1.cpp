// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Header.h"
#include <iostream>

using namespace std;

	class fruit
	{
	public:
		float weight, priceperpound;
		float cost();
	};

	float fruit::cost()
	{
		return (weight * priceperpound);
	}

	int i;
	enum Test
	{
		test,
		test1
	};
	void main(void)
	{
		Motor_port x;
		fruit apple, orange;
		i = x.testing_one;
		int k = test;
		switch (k)
		{
		case test:
			break;
		}

		cout << "Enter an apple price per pound: " << flush;
		cin >> apple.priceperpound;
		cout << "Enter an apple weight " << flush;
		cin >> apple.weight;

		cout << "Enter an orange price per pound: " << flush;
		cin >> orange.priceperpound;
		cout << "Enter an apple weight: " << flush;
		cin >> orange.weight;

		cout << apple.cost() << " " << orange.cost();
		getchar();
		getchar();
	}

