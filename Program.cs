internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Çalısan sayısı: {Calisan.EmpNumber}");

        Calisan calisan = new Calisan("Deniz", "Öz", "IK");
        Console.WriteLine($"Çalısan sayısı: {Calisan.EmpNumber}");
        Calisan calisan1 = new Calisan("Melek", "Öz", "IK");
        Calisan calisan2 = new Calisan("Aslı", "Çınar", "IK");
        Console.WriteLine($"Çalısan sayısı: {Calisan.EmpNumber}");
        
        Console.WriteLine($"88+99: {Islemler.sum(88,99)}");
        Console.WriteLine($"99-88: {Islemler.subt(99,88)}");

         //Static sınıf üyesine erişim
        Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);

        //Static olmayan sinif üyesine erişim
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Deniz";
        ogrenci1.Soyisim = "Arda";
        
        Ogrenci ogrenci2 = new Ogrenci();
        ogrenci2.Isim = "Ayşe";
        ogrenci2.Soyisim = "Yılmaz";

        Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
    }
}

class Calisan
{
    private static int empNumber;//field

    public static int EmpNumber { get => empNumber; set => empNumber=value; }//property

    private string name;
    private string surname;
    private string department;

    static Calisan() //Static Constructor
    {
        empNumber=0;
    }

    public Calisan(string name, string surname, string department)  //Parameterized Constructor
    {
        this.name = name;
        this.surname = surname;
        this.department = department;
        empNumber++;
    }

   
}

static class Islemler
{
     public static long sum(int x, int y)
    {
        return x+y;
    }
     public static long subt(int x, int y)
    {
        return x-y;
    }
}

class Ogrenci
{
    public static int OgrenciSayisi = 0;
    public string Isim;
    public string Soyisim;
    public Ogrenci()
    {
        OgrenciSayisi++;
    }
}