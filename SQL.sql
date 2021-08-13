--Select  --> Sql de yorum satırı çift çizgi ile yapılır.
-- Select * from Customers  --> Bu satırdaki yıldız (*) tablodaki tüm kolonları seç demektir.
-- Select ContactName, CompanyName, City from Customers -- Burada ise Customers tablosundan sadece 3 kolonu seçtik ve listeledik.
Select ContactName Adi, CompanyName SirketAdi, City  Sehir from Customers --> Burada ise her kolonun yanına o kolona ait bir takma isim (Alias) verdik.
Select * from Customers where City = 'London'  --> Metinler ANSI standarlarında tek tırnak ile yazılır.

-- case insensitive --> Büyük küçük harf DUYARSIZ dır.
sELECT * from Products where CategoryID = 1 or CategoryID = 3 -- or (yada) iki şarttan biri oluşması yeterli

Select * from Products where CategoryID = 1 and UnitPrice >= 10 -- and (ve) iki şartın da oluşması gerekli

select * from Products order by ProductName --> order by sıralamak demek

select * from Products where CategoryID = 1 order by UnitPrice desc --> ascending (Artan) --> descending (Azalan)

select count (*) from Products --> Bu satır Products tablosunda kaç ürün/satır var demektir.

select count (*) Adet from Products where CategoryID = 2 --> Burada ise Products tablosundaki CategoryId si 2 olan ürünler say ama gösterirken başlık olarak Adet yaz dedik.

-- Eğer group by kullanıyorsak select ettiğimiz alan sadece ve sadece group by ettiğimiz alan olabilir. Yani bu örnekteki CategoryId gibi. select * from kullanamayız.
select CategoryID from Products group by CategoryID --> Senaryo : Hangi kategoride kaç farklı ürünümüz var. 

select CategoryID, count(*) from Products group by CategoryID --> Bu satırda group by ile CategoryId altında hangi kategoriden kaçar adet ürün olduğunu saydırdık. yani virgülden sonra count kullanabiliriz.

select CategoryID, count(*) from Products group by CategoryID, ProductID --> iki kolona birden group by yapabiliriz.

select CategoryID, count(*) from Products group by CategoryID having count(*)<10  --> Ürün sayısı 10 dan az olan kategorileri listele derken having kullanırız.

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID --> inner join birleştir demek. Sadece iki tabloda da eşleşen datayı getirir. Eşleşmeyen data varsa getirmez.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--> DTO = Data Transformation Object  -->C# ta bu şekilde ilişkilendireceğiz.

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID  --> Yönetim hiç satış yapamadığımız ürünleri listele derse => Buraya left yazarak solda olupta sağda olmayanları getir dedik.

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null  --> Kayıt olmuş ama hiç alışveriş yapmamış müşteriler

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID --> birden çok tabloyu birleştirmek istiyorsak kullanırız.