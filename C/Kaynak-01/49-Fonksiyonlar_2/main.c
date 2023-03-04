#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Geriye deðer göndüren fonksiyonlar
int toplam(int s1,int s2){
	int s3;
	s3=(s1+s2)*5-10;
	return s3;
}


int main() {
	
	
	int t;
	t=toplam(4,5);
	printf("%d\n",t); //35
	
	
	printf("%d",toplam(2,3)); //15
	
	
	
	
	return 0;
}
