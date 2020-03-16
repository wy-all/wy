// gao.cpp : �������̨Ӧ�ó������ڵ㡣
//

// monkey.cpp : �������̨Ӧ�ó������ڵ㡣
//


#include"stdafx.h"
#include<iostream>
using namespace std;
#define MaxSize 100
typedef int SElemType;
typedef int Status; 
typedef struct
{
	SElemType *base;
	SElemType *top;
	int stacksize;
}SqStack;
//��ʼ����ջ
void InitStack_Sq(SqStack& S)
{
	S.base = new SElemType[MaxSize];
	if (!S.base)
		exit(0);
	S.top = S.base;
	S.stacksize = MaxSize;
}
//�ж�˳��ջ�Ƿ�Ϊ��
bool StackEmpty_Sq(SqStack S)
{
	if (S.top == S.base)
		return true;
	else
		return false;
}
//��ջ
void Push(SqStack &S, SElemType e)
{
	if (S.top - S.base == MaxSize)
		exit(0);
	*S.top++ = e;
}
//��ջ
void Pop(SqStack& S, SElemType& e)
{
	if (S.top == S.base)
		exit(0);
	e = *--S.top;
}

void Conversion(int num,int a)
{
	SqStack S;
	int e;
	InitStack_Sq(S);
	while (num != 0)
	{
		Push(S, num % a);
		num = num / a;
	}
	if(a==16)
	{
		while (!StackEmpty_Sq(S))
		{
			Pop(S, e);
			switch (e)
			{
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				cout << e;
				break;
			case 10:
				cout << 'A';
				break;
			case 11:
				cout << 'B';
				break;
			case 12:
				cout << 'C';
				break;
			case 13:
				cout << 'D';
				break;
			case 14:
				cout << 'E';
				break;
			case 15:
				cout << 'F';
				break;
			}
		}
	}
	else
	{
		while (!StackEmpty_Sq(S))
		{
			Pop(S, e);
			cout<<e;
		}

		
	}
	cout<<endl;
}



int main()
{
	int num,a;
	cout << "������һ��ʮ����������Ҫת���Ľ�������";
	cin >> num>>a;
	Conversion( num, a);
	
}
