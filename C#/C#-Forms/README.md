>_Büyük fikirler büyük başarılar getirmez, küçük başarılar büyük başarıları inşa eder._



## İçindekiler (Contents)
1. [Temel Araç Kullanımları](#p1)
    1. [Merhaba Dünya](#o1)
    2. [Label Textbox](#o2)
    3. [Combobox ve Listbox](#o3)
    4. [Maskedbox, Picturebox, Datetime](#o4)
    5. [Checkbox ve Radiobutton](#o5)
    6. [Giriş Paneli Uygulaması](#o6)
2. [Değişkenler](#p2)
    1. [String Değişkenler](#o7)
    2. [Int Değişkenler](#o8)
    3. [Int Değişkenlerde Klavyeden Veri Girişi](#o9)
    4. [Int Değişkenlerde Pratikler](#o10)
    5. [Double Değişkenler](#o11)
    6. [Örnek Uygulama](#o12)
3. [Karar Yapıları](#p3)
    1. [if-else Koşulu](#o13)
    2. [Pratik Örnek -1](#o14)
    3. [Pratik Örnek -2](#o15)
    4. [Switch-Case Yapısı](#o16)
4. [Döngüler](#p4)
    1. [For Döngüsü](#o17)
    2. [Pratik Örnek](#o18)
    3. [While Döngüsü](#o19)
    4. [Do-While Döngüsü](#o20)
    5. [Timer Kullanımı](#o21)
    6. [Timer ile Saat Yapımı](#o22)
    7. [ProgressBar Kullanımı](#o23)
5. [Diziler](#p5)
    1. [Dizi Tanımlama](#o24)
    2. [Dizi Elemanları Listeleme](#o25)
    3. [Foreach Döngüsü](#o26)
6. [Metotlar](#p6)
    1. [Değer Döndürmeyen Metotlar](#o27)
    2. [Değer Döndüren Metotlar](#o28)
    3. [Küp Hesaplayan Metot](#o29)
7. [Sınıflar](#p7)
    1. [Sınıf Oluşturma](#o30)
    2. [Geriye Değer Döndürmeyen Metot](#o31)
    3. [Geriye Değer Döndüren Metot](#o32)
    4. [Constructor Metotlar](#o33)
    5. [Constructor Metotlar -2](#o34)
8. [Ekstra Araçlar](#p8)
    1. [Menu Strip Kullanımı](#o35)
    2. [Chart Aracı Kullanımı](#o36)
    3. [Context Menu Strip Kullanımı](#o37)
9. [Ekstra Yapılar](#p9)
    1. [Random Kullanımı](#o38)
    2. [Sayısal Loto Uygulaması](#o39)
    3. [Captcha Oluşturma](#o40)
    4. [Formlar Arası Geçiş](#o41)
    5. [Formlar Arası Veri Taşıma](#o42)
    6. [Pointer Yapısı](#o43)
    7. [Enum Yapısı](#o44)
    8. [Matematik Fonksiyonları](#o45)
    9. [Dinamik Araçlar](#o46)
10. [Veritabanı SQL Projesi](#p10)
11. [Dosya İşlemleri](#p11)
    1. [Araçlar](#o47)
    2. [Metin Belgesi Oluşturma](#o48)
    3. [Metin Belgesi Okuma](#o49)
    4. [Metin Belgesine Veri Kaydet](#o50)
    5. [PDF Okuma](#o60)
12. [Access Veri Tabanı Projesi](#p12)
13. [Hata Kontrolü | Try-Catch Yapısı](#p13)
14. [İlişkili Tablolar ile E-Okul Projesi](#p14)
15. [Entity Framework Projesi](#p15)
16. [N Katmanlı Mimari Projesi](#p16)
    1. [Ana Katman]
    2. [Data Access Layer]
    3. [Entity Layer]
    4. [Logic Layer]



# 01- Temel Araç Kullanımları <a name="p1"></a>

### A-) Merhaba Dünya  <a name="o1"></a>
```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Merhaba_Dunya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }
    }
}
```

### B-) Label Textbox  <a name="o2"></a>
```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Label_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında belirlediğimiz label'lara belirlediğimiz değerler getirilecek
            label4.Text = "Berkan Nihat";
            label5.Text = "Yıldız";
            label6.Text = "Software Developer";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Butona tıkladığımızda textbox1 içerisindeki bilgiler label8 içerisine aktarılacak
            label8.Text = textBox1.Text;
        }
    }
}
```

### C-) Combobox ve Listbox  <a name="o3"></a>
```c#

```

### D-) Maskedbox, Picturebox, Datetime  <a name="o4"></a>
```c#

```

### E-) Checkbox ve Radiobutton  <a name="o5"></a>
```c#

```

### F-) Giriş Paneli Uygulaması  <a name="o6"></a>
```c#

```

# 02- Değişkenler <a name="p2"></a>

### A-) String Değşikenler  <a name="o7"></a>
```c#

```

### B-) Int Değişkenler  <a name="o8"></a>
```c#

```

### C-) Int Değşikenlerde Klavyeden Veri Girişi  <a name="o9"></a>
```c#

```

### D-) Int Değişkenlerde Pratikller  <a name="o10"></a>
```c#

```

### E-) Double Değişkenler  <a name="o11"></a>
```c#

```

### F-) Örnek Uygulama  <a name="o12"></a>
```c#

```

# 03- Karar Yapıları <a name="p3"></a>

### A-) if-else Koşulu  <a name="o13"></a>
```c#

```

### B-) Örnek Pratik -1  <a name="o14"></a>
```c#

```

### C-) Örnek Pratik -2  <a name="o15"></a>
```c#

```

### D-) Switch-Case Yapısı  <a name="o16"></a>
```c#

```

# 04- Döngüler <a name="p4"></a>

### A-) For Döngüsü <a name="o17"></a>
```c#

```

### B-) Pratik Örnek <a name="o18"></a>
```c#

```

### C-) While Döngüsü <a name="o19"></a>
```c#

```

### D-) Do-While Döngüsü <a name="o20"></a>
```c#

```

### E-) Timer Kullanımı <a name="o21"></a>
```c#

```

### F-) Timer ile Saat Yapımı <a name="o22"></a>
```c#

```

### G-) ProgressBar Kullanımı <a name="o23"></a>
```c#

```

# 05- Diziler <a name="p5"></a>

### A-) Dizi Tanımlama <a name="o24"></a>
```c#

```

### B-) Dizi ELemanları Listeleme <a name="o25"></a>
```c#

```

### C-) Foreach Döngüsü <a name="o26"></a>
```c#

```

# 06- Metotlar <a name="p6"></a>

### A-) Değer Döndürmeyen Metotlar <a name="o27"></a>
```c#

```

### B-) Değer DÖndüren Metotlar <a name="o28"></a>
```c#

```

### C-) Küp Hesaplayan Metot <a name="o29"></a>
```c#

```

# 07- Sınıflar <a name="p7"></a>

### A-) Sınıf Oluşturma <a name="o30"></a>
```c#

```

### B-) Geriye Değer Döndürmeyen Metot <a name="o31"></a>
```c#

```

### C-) Geriye Değer Döndüren Metot <a name="o32"></a>
```c#

```

### D-) Constructor Metotlar <a name="o33"></a>
```c#

```

### E-) Constructor Metotlar -2 <a name="o34"></a>
```c#

```

# 08- Ekstra Araçlar <a name="p8"></a>

### A-) Menu Strip Kullanımı <a name="o35"></a>
```c#

```

### B-) Chart Aracı Kullanımı <a name="o36"></a>
```c#

```

### C-) Context Menu Strip Kullanımı <a name="o37"></a>
```c#

```

# 09- Ekstra Yapılar <a name="p9"></a>

### A-) Random Kullanımı <a name="o38"></a>
```c#

```

### B-) Sayısal Loto Uygulaması <a name="o39"></a>
```c#

```

### C-) Captcha Oluşturma <a name="o40"></a>
```c#

```

### D-) Formlar Arası Geçiş <a name="o41"></a>
```c#

```

### E-) Formlar Arası Veri Taşıma <a name="o42"></a>
```c#

```

### F-) Pointer Yapısı <a name="o43"></a>
```c#

```

### G-) Enum Yapısı <a name="o44"></a>
```c#

```

### H-) Matematik Fonksiyonları <a name="o45"></a>
```c#

```

### I-) Dinamik Araçlar <a name="o46"></a>
```c#

```

# 10- Veritabanı SQL Projesi <a name="p10"></a>

# 11- Dosya İşlemleri <a name="p11"></a>

### A-) Araçlar
```c#

```

### B-) Metin Belgesi Oluşturma
```c#

```

### C-) Metin Belgesi Okuma
```c#

```

### D-) Metin Belgesine Veri Kaydet
```c#

```

### E-) PDF Okuma
```c#

```

# 12- Veritabanı Access Projesi <a name="p12"></a>
```c#

```

# 13- Hata Kontrolleri (Try-Catch) <a name="p13"></a>

# 14- İlişkili Tablolar ile E-Okul Projesi <a name="p14"></a>

# 15- Entity Framework Projesi <a name="p15"></a>

# 16- N Katmanlı Mimari Proje <a name="p16"></a>

### A-) Ana Katman

### B-) Data Access Layer

### C-) Entity Layer

### D-) Logic Layer
