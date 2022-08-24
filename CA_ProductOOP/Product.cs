using CA_ProductOOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_ProductOOP
{
    
    public class Product
    {
        public long id;
        public string productName;
        public int unitsInStock;
        public double unitPrice;
        public string categoryName;
        public string supplierName;
        public ArrayList products = new ArrayList();  //producttan sonrasına geçmiyor.
        public ArrayList ozellikler2 = new ArrayList();

        public Product product = new Product();
        public Product product2 = new Product();
        public Product product3 = new Product();
        public void kaydetme()
        {

            
            product.id = 58;
            product.productName = "Telefon";
            product.unitsInStock = 25;
            product.unitPrice = 27000.35;
            product.categoryName = "Teknoloji";
            product.supplierName = "Apple";
            products.Add(product);
            
            product2.id = 59;
            product2.productName = "Çamaşır Makinesi";
            product2.unitsInStock = 10;
            product2.unitPrice = 12500.65;
            product2.categoryName = "Beyaz Eşya";
            product2.supplierName = "Bosch";
            products.Add(product2);
            
            product3.id = 60;
            product3.productName = "Güneş Gözlüğü";
            product3.unitsInStock = 30;
            product3.unitPrice = 1500.50;
            product3.categoryName = "Aksesuar";
            product3.supplierName = "Ray-Ban";
            products.Add(product3);

        }

        public void listele()
        {
            foreach(object product in products)
            {
                if(product is Product)
                {
                   Product product1 = (Product)product;
                    string result = $"Ürün ID'si: {product1.id}\nÜrün ismi: {product1.productName}\nStoktaki Ürün Adedi: {product1.unitsInStock}\nÜrün fiyatı: {product1.unitPrice}\nKategori Adı: {product1.categoryName}\nTedarikçi Adı: {product1.supplierName}\n\n\n";
                    Console.WriteLine(result);
                }
            }
            
        }

        public void güncelle()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz ürünü seçin");
            int secim,secim2;
            string[] ozellikler = { "Ürün ID'si", "Ürün İsmi", "Stoktaki Ürün Adedi", "Ürün Fiyatı", "Kategori Adı", "Tedarikçi Adı" };
            secim = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Şimdi de seçmiş olduğunuz ürünün hangi özelliğini değiştirmek istediğinizi seçin ");
            for(int i=0; i < ozellikler.Length; i++)
            {
                Console.WriteLine($"{i+1}- {ozellikler[i]}");
            }
            secim2 = int.Parse(Console.ReadLine())-1;
            
            switch(secim)
            {
                case 0:
                    products[0] = product;
                    switch(secim2)
                    {
                        case 0:
                            ozellikler2[0] = product.id;
                            Console.WriteLine("Lütfen ürün ID'si girin");
                            product.id = long.Parse(Console.ReadLine());
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }       
}
