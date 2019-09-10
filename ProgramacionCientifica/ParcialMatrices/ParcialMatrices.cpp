#include <iostream>
#include <time.h>
#include "ParcialMatrices.h"
#define N 4
using namespace std;
int mayor(int mat[N][N])
{
	int i, j;
	float may = mat[0][0];
	for (i = 0; i < N; i++)
		for (j = 0; j < N; j++)
			may = (mat[i][j] > may ? mat[i][j] : may);//criptica
	return may;
}
int menor(int mat[N][N])
{
	int i, j;
	float may = mat[0][0];
	for (i = 0; i < N; i++)
		for (j = 0; j < N; j++)
			may = (mat[i][j] < may ? mat[i][j] : may);//criptica
	return may;
}
void mostrarMatriz(int (mat[N][N]))
{
	int i, j;
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < N; j++)
			cout << mat[i][j] << "\t";
		cout << endl;
	}
}
float promedioMatriz(int mat[N][N])
{
	float promedio=0;
	int i, j;
	for (i = 0; i < N; i++)
		for (j = 0; j < N; j++)
			promedio += mat[i][j];
	return promedio/(N*N);
}
//creo la matriz y la utilizo con distintas funciones
void insertarMatriz()
{
	srand(time(NULL));
	int i, j, mat[N][N];
	for (i = 0; i < N; i++)
	for (j = 0; j < N; j++)
			mat[i][j] = rand() % 101;
	muestraResultados(mat);
}
void muestraResultados(int  mat[N][N])
{
	//promedio de la matriz
	cout << "el promedio del la matriz es: " << promedioMatriz(mat) << endl;
	//diferencia con mayor y promedio
	cout << "el mayor valor de la matriz es: " << mayor(mat) << " la diferencia con el promedio es: " <<
		 mayor(mat) - promedioMatriz(mat) << endl;
	//diferencia con promedio y menor
	cout << "el menor valor de la matriz es: " << menor(mat) << " la diferencia con el promedio es: " <<
		promedioMatriz(mat) - menor(mat) << endl;
	//muestro la matriz
	mostrarMatriz(mat);
}
int main()
{
	insertarMatriz();	
}
