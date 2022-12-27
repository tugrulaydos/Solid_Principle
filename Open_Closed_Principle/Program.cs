
//Open Closed Principle, OOP tasarımlarda bir sınıfın gereksinimler doğrul-
//sunda değiştirmeye gerek duyulmaksızın genişletilebilir bir şekilde tasar-
//lanmasını savunan bir prensiptir.
//Kodun Değiştirilmesi --> var olanın yeni gereksinime göre güncel halinin işlenmesidir.
//Kodun genişletilmesi--> Kodu değiştirmeksizin yeni gereksinime göre gelecek
//olan davranışın uygulamaya eklenebilmesidir.



class ParaGonderici
{
    public void Gonder(IBanka banka ,int Tutar, string HesapNo)
    {        

        banka.ParaTransfer(Tutar, HesapNo);

    } 
}

interface IBanka
{
    bool ParaTransfer(int tutar, string hesapNo);
}

class Garanti:IBanka
{
    public string HesapNo { get; set; }

    public void ParaGonder(int tutar)
    {

    }

    public bool ParaTransfer(int tutar, string hesapNo)
    {
        ParaGonder(tutar);
        HesapNo = hesapNo;
        Console.WriteLine("Garanti ile {0} Lira {1} Hesap Numarasına Gonderildi",tutar,hesapNo);
        
        return true;
    }
}

class HalkBank:IBanka
{    

    public void GonderilecekHesapNo(string hesapNo)
    {

    }

    public void Gonder(int tutar)
    {

    }

    public bool ParaTransfer(int tutar, string hesapNo)
    {
        GonderilecekHesapNo(hesapNo);

        Gonder(tutar);

        Console.WriteLine("Halkbank ile {0} Lira {1} Hesap Numarasına Gonderildi", tutar, hesapNo);

        return true;
    }
}

internal class Program
{    

    static void Main(string[] args)
    {
        ParaGonderici paraGonderici = new ParaGonderici();

        paraGonderici.Gonder(new Garanti(), 1500,"A-95612");
        

    }
}


