#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Ellerin plaka numaralar�n� ��renmek istersek 81 tane if-else kullanmam�z gerekir
//Bunun yerine enum kullanarak daha pratik ve k�sa yollu bir ��z�m elde edebiliriz

enum sehirler{
	ilkdeger,adana,adiyaman,afyon,agri,amasya,ankara,antalya,balikesir
};


int main() {
	
	enum sehirler il;
	il=amasya;
	printf("%d",il); //%d kullan�l�yor ��nk� il de�i�kenin de�eri otomatik olarak bir indeks numaras� vermektedir
	//Output = 5
	
	
	return 0;
}
