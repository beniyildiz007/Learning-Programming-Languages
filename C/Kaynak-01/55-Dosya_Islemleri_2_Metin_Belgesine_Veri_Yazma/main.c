#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *dosya;
	dosya=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\55-Dosya_Islemleri_2_Metin_Belgesine_Veri_Yazma\\bilgi.txt","w");
	
	
	putc('a',dosya);
	putc('\n',dosya);
	putc('b',dosya);
	
		
	fclose(dosya);
	
	
	return 0;
}
