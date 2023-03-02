#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Ellerin plaka numaralarýný öðrenmek istersek 81 tane if-else kullanmamýz gerekir
//Bunun yerine enum kullanarak daha pratik ve kýsa yollu bir çözüm elde edebiliriz

enum sehirler{
	ilkdeger,adana,adiyaman,afyon,agri,amasya,ankara,antalya,balikesir
};


int main() {
	
	enum sehirler il;
	il=amasya;
	printf("%d",il); //%d kullanýlýyor çünkü il deðiþkenin deðeri otomatik olarak bir indeks numarasý vermektedir
	//Output = 5
	
	
	return 0;
}
