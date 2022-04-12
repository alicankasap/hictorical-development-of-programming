# Programlamanın Tarihsel Gelişimi

## 1) Unstructured Programming
Yapısal olmayan programlama demektir. Uygualamada sadece main() metodu bulunur. İkinci bir metod eklenemez. Kodlar yukarıdan aşağıya doğru sırayla yazılır. Aynı kod bloğuna ihtiyaç duyulduğunda ya kod tekrar yazılır ya da "go to" ile daha önce yazılmış olan kod bloğuna tekrar gönderilir ve kod oradan aşağıya doğru tekrar okunmaya başlanır. Bu tür uygulamalarda tekrar tekrar yazılan kodlar fonksiyona olan ihtiyacı doğurmuştur.

## 2) Procedural Programming
Yordamsal programlama demektir. İstenildiği kadar fonksiyon yazılabilir. Bu fonksiyonlar daha sonra ihtiyaç duyulan her yerde çağrılabilir. Bu programlama tipinde ise yazılan çok sayıda ve birbirinden bağımsız işler yapan fonksiyonlar kod satırları arttıkça yönetilebilirliği zorlaştırmıştır ve nesne tabanlı programlamaya olan ihtiyaç doğmuştur.

## 3) Object Oriented Programming
Nesne yönelimli programlama demektir. Class'ların nesnelerini oluşturarak kullanabilme esasına dayanır. Birbiriyle alakalı iş yapan fonksiyonlar aynı class'ın altında toplanır ve ihtiyaç oldukça class'ın nesnesi üretilerek çağırılıp kullanılabilir. Aynı zamanda projeyi build ettiğimizde bize "ClassAdı.dll" uzantılı bir belge oluşturur. Bu .dll uzantılı belgeyi başka bir projede de kullanabiliriz.

## 4) Compenent Based Programming (Layered Architecture)
Katmanlı mimarı yapısıdır. Örnek vermek gerekirse Entities, DataAccess, Business gibi katmanları vardır. Entities katmanında veri tabanı nesneleri tutulur. DataAccess katmanından veri tabanına erişilir vb. DataAccess.dll'ini Business katmanında referans vererek kullanabiliriz.

## 5) Service Oriented Architecture (n-tiered Achitecture)
Uygulamanın her platformda çalışması esasına dayanır. Örneğin; .Net Core Web API
