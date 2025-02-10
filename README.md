# 🚀 **FinancialCrm**

Bu proje, finansal verilerinizi daha düzenli ve verimli bir şekilde yönetmenize olanak tanıyan bir Windows Forms uygulamasıdır. C# programlama dili ve Entity Framework ile geliştirilmiş bu uygulama, kullanıcıların banka hesaplarını takip etmelerini, ödeme ve fatura işlemlerini yönetmelerini sağlar. Ayrıca, finansal durumunuzu analiz etmenize yardımcı olacak görsel grafikler ve anlık bilgiler sunar. 

👤 **Kullanıcı Girişi**
---

• Uygulamaya giriş yapmak için kullanıcı adı ve şifre gereklidir.

• Bilgiler doğru şekilde girildiğinde, kullanıcı "Giriş Yap" butonuna tıklayarak sisteme giriş yapabilir.

• Başarılı bir giriş işlemi sonrasında, kullanıcı otomatik olarak Kategoriler Sayfasına yönlendirilir.

📝 **Kategoriler**
---

• Kategoriler modülünde her bir kategoriye ait Kategori ID ve Kategori Adı bilgileri bulunur.

• Kategoriler modülünde, mevcut tüm kategoriler listelenebilir.

• Kullanıcılar, yeni bir kategori oluşturmak için Kategori Adı belirleyebilirler.

• Mevcut bir kategori üzerinde değişiklik yapmak isteyen kullanıcılar, kategori adını güncelleyebilirler.

• Kullanıcılar, gereksiz ya da artık kullanılmayan bir kategoriyi silme işlemi yapabilirler.

💵 **Bankalar**
---

• Bankalar modülünde, kullanıcıların sahip oldukları tüm banka hesaplarının bakiye bilgileri görüntülenebilir.

• Kullanıcılar son 5 banka hareketini görüntüleyebilirler.

🧾 **Faturalar**
---

• Her bir fatura için bir başlık belirlenir. Bu başlık, faturanın neyle ilgili olduğunu belirten kısa bir açıklama veya isim olabilir. (örneğin, "Elektrik Faturası", "Su Faturası" vb.) Miktar kısmında faturanın tutarı belirtilir. Periyot ksımında ise faturanın hangi dönemi kapsadığı burada gösterilir. (Örneğin, "Ocak 2025", "Mart 2025") gibi bir tarih periyodu belirlenir.

• Ödeme listesinde bu bilgiler sıralanarak kullanıcının kolayca faturalarını takip etmesini sağlar.

• Kullanıcılar, Yeni Ödeme butonuna tıklayarak yeni bir ödeme kaydı ekleyebilirler.

• Mevcut bir ödeme kaydında değişiklik yapmak isteyen kullanıcılar, ödeme listesinde yer alan ödeme güncelleme butonuna tıklayarak düzenleme işlemi yapabilirler.

• Kullanıcılar, ödeme listesinde yer alan bir ödemeyi silmek istediklerinde ödeme sil butonuna tıklayarak ilgili kaydı kaldırabilirler.

📄 **Giderler**
---

• Giderler modülünde, kullanıcılar gider bilgilerini yönetebilir ve düzenleyebilirler. Bu modül, giderlerin başlık, tutar, tarih ve kategori gibi önemli bilgilerini içerir.

• Kullanıcılar, gider listesi butonuna tıklayarak tüm giderlerini görüntüleyebilirler.

• Kullanıcılar, gider ekle butonuna tıklayarak yeni bir gider kaydı oluşturabilirler.

• Mevcut bir gideri güncellemek isteyen kullanıcılar, gider listesinde yer alan gider güncelle butonuna tıklayarak düzenleme yapabilirler.

• Kullanıcılar, gereksiz veya yanlış girilmiş bir gideri silmek istediklerinde, gider sil butonuna tıklayarak ilgili kaydı silebilirler.

🔄 **Banka Hareketleri**
---

• Banka hareketleri modülünde, her bir banka işlemi için tarih, miktar, açıklama, işlem türü ve banka ID bilgileri bulunur. Kullanıcılar bu modülde banka hesaplarıyla ilgili tüm işlemleri yönetebilir.

• Kullanıcılar, işlem listesi butonuna tıklayarak tüm banka hareketlerini görüntüleyebilirler.

• Kullanıcılar, yeni işlem ekle butonuna tıklayarak yeni bir banka hareketi kaydedebilirler.

• Kullanıcılar, mevcut bir banka hareketini güncellemek istediklerinde, işlem güncelleme butonuna tıklayarak gerekli değişiklikleri yapabilirler.

• Kullanıcılar, artık geçerli olmayan veya yanlış girilmiş bir banka hareketini silmek istediklerinde, işlem sil butonuna tıklayarak bu işlemi gerçekleştirebilirler.

📊 **Dashboard**
---

• Dashboard modülü, kullanıcıların finansal durumlarını hızlı bir şekilde gözden geçirebileceği bir genel bakış sayfasıdır. Bu modülde, toplam bakiye, faturalar, gelen son havale bilgileri ve grafiksel analizler gibi önemli bilgiler yer alır.

• Banka Hesaplarındaki Para Miktarı: Kullanıcıların sahip olduğu tüm banka hesaplarındaki para miktarı, grafiksel olarak gösterilir.

• Ödenen ve Ödenmesi Gereken Faturalar: Kullanıcıların ödedikleri ve ödemeleri gereken faturalar grafik üzerinde gösterilir.

⚙️ **Ayarlar**
---
• Ayarlar modülü, kullanıcıların hesap bilgilerini düzenleyebileceği bir bölümdür.

 📌 **Projede Kullanılan Teknolojiler**
--

✅ C#

✅ Windows Forms

✅ Microsoft SQL Server

✅ LINQ

✅ Entity Framework

📌 **Proje Görselleri**
---

**Kullanıcı Girişi**

![FinancialCrm_4kZag0sUV5](https://github.com/user-attachments/assets/bbec7ac4-0a02-4629-a1a7-49379eb4d263)

**Kategoriler**

![devenv_OFbBbxYmXC](https://github.com/user-attachments/assets/e7c6d1e8-680b-4b62-a9e3-b777b041ce55)

**Bankalar**

![FinancialCrm_xkQdYjLsDj](https://github.com/user-attachments/assets/2df3cca9-debf-4170-8165-158103cf87c0)

**Faturalar**

![FinancialCrm_ITiYtNxRMn](https://github.com/user-attachments/assets/2a1c9165-c60f-47ee-83b1-910f211ef7ac)

**Giderler**

![FinancialCrm_d5VC7X3b1v](https://github.com/user-attachments/assets/094e1224-7100-4b6b-b19f-90a0e0a6d9fb)

**Banka Hareketleri**

![FinancialCrm_4EMIafe2jY](https://github.com/user-attachments/assets/0af63214-ae85-40fc-80f4-58789e0b2467)

**Dashboard**

![FinancialCrm_Lp1paZL1hM](https://github.com/user-attachments/assets/5f87566f-0382-4df6-99fe-60a446ca840b)

**Ayarlar**

![FinancialCrm_LJbiKmUkJy](https://github.com/user-attachments/assets/f3750588-e911-4ea5-ad7d-ac4bbc1d08ba)








