//#include "pch"
#include <iostream>
#include <time.h>
using namespace std;
#define N 5
int mayor(float mat[N][N])
{
	int i, j;
	float may = mat[0][0];
	for (i = 0; i < N; i++)
		for (i = 0; i < N; i++)
			may = (mat[i][j] > may ? mat[i][j] : may);
	return may;
}
int main()
{
	int i, j;
	float mat[N][N];
	srand(time(NULL));
	for (i = 0; i < N; i++) 
	{
		for (j = 0; j <	N; j++)
		{
			mat[i][j] = (rand() % 101 - rand() % 101) / float(rand() % 101);
			cout << mat[i][j]<<"\t";
		}
		cout << endl;
	}	
	cout<<mayor(mat);
}