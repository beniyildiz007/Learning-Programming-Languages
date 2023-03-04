#include <stdio.h>
#include <stdlib.h>

//Define ile if-else kýsa kullanýmý -makro-
#define Maksimum(s1,s2) (s1>s2) ? s1 : s2

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("%d\n",Maksimum(5,8)); //8
	printf("%d\n",Maksimum(7,3)); //7
	printf("%d\n",Maksimum(4,4)); //4	
	
	
	
	return 0;
}
