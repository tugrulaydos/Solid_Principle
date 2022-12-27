
//Solid Prensibleri Faydaları:
//Koda, Sürdürülebilirlik, Genişletilebilirlik, Yeniden Kullanılabilirlik 
//ve Esneklik Sağlar

public class Araba:ITasit,Sinyal
{
    public void GazVer()
    {
        Console.WriteLine("Gaza Bas");
    }

    public void FrenYap()
    {
        Console.WriteLine("Frena Bas");
    }

    public void SolaSinyal()
    {
        Console.WriteLine("Mandali Yukari Cevir");
    }

    public void SagaSinyal()
    {
        Console.WriteLine("Mandali Asagi Cevir");
    }
}

public class Otobus:ITasit,Sinyal
{
    public void Gazla()
    {
        Console.WriteLine("Gaza Bas");
    }

    public void Frenle()
    {
        Console.WriteLine("Frena Bas");
    }

    public void SolaSinyal()
    {
        Console.WriteLine("Pistonu Yukari Kaldir");
    }

    public void SagaSinyal()
    {
        Console.WriteLine("Pistonu asagi indir");
    }

    public void GazVer()
    {
        Gazla();
    }

    public void FrenYap()
    {
        Frenle();
    }
}

public class Bisiklet:ITasit
{
    public void Gazla()
    {
        Console.WriteLine("Pedal Çevir");
    }

    public void FrenYap()
    {
        Console.WriteLine("Pedalı Sık");
    }

    public void GazVer()
    {
        Gazla();
    }

    
}

interface ITasit
{
    public void GazVer();

    public void FrenYap();

   
}

interface Sinyal
{
    public void SagaSinyal();

    public void SolaSinyal();
}

class Vasita
{    

    ITasit _I1;

    public Vasita(ITasit I1)
    {
        _I1 = I1;
    }

    public void Kullan()
    {
        _I1.GazVer();
        _I1.FrenYap();
        (_I1 as Sinyal)?.SagaSinyal();
        (_I1 as Sinyal)?.SolaSinyal();        
    }
}




internal class Program
{

    static void Main(string[] args)
    {
        Vasita v1 = new Vasita(new Bisiklet());
        v1.Kullan();        
        
    }
}


