using System;

namespace ClassMetotDemo 
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

            Musteri customer1 = new Musteri();
            customer1.Adi = "Jack";
            customer1.Soyadi = "Humbler";
            customer1.Id = 00234532;
            customer1.CepNo = 5123428998;

            Musteri customer2 = new Musteri();
            customer2.Adi = "Cash";
            customer2.Soyadi = "Jora";
            customer2.Id = 98764531;
            customer2.CepNo = 7653452634;

            Musteri customer3 = new Musteri();
            customer3.Adi = "Jay";
            customer3.Soyadi = "Fat";
            customer3.Id = 65748356;
            customer3.CepNo = 7518768976;

            Musteri customer4= new Musteri();
            customer4.Adi = "Kemal";
            customer4.Soyadi = "Kurt";
            customer4.Id = 76538909;
            customer4.CepNo = 4569879009;

            Musteri[] customers = {customer1, customer2, customer3,customer4 };

            foreach (Musteri customer in customers)
            {
                Console.WriteLine(customer.Adi + "  " + customer.Soyadi);
                Console.WriteLine(customer.CepNo);
            }



        }
    }
}