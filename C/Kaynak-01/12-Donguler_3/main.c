#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	//Fibonacci serisinin ilk 10 eleman�n� listeleyen program
	
	int a,b,c,i;
	a=1;
	b=1;
	
	printf("%d\n",a);
	printf("%d\n",b);
	
	for(i=1;i<=8;i++){ //10 eleman istendi�i i�in 8 yazd�k ��nk� ilk 2 eleman zaten 1 ve bunlar� yukar�da yazd�rm��t�k
		c=a+b;
		a=b;
		b=c;
		printf("%d\n",c);
	}
	
	
	return 0;
}
