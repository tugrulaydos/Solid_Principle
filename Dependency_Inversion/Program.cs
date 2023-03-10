
//Bir Sınıfın herhangi bir türe olan bağımlılık durumuna karşı dikkatimizi
//çeken ve bu bağımlılığın mümkün mertebe tersine çevrilmesini öneren bir ilkedir.

//Bu prensip; geliştiricinin herhangi bir türe bağımlı olmadığını, bilakis
//türlerin/yani nesnelerin geliştiriciye bağımlı olduğunu savunur.

//DI, bir sınıfın concrete somut sınıflara değil onların abstraction'larına bağlı olması gerektiğini önerir.
//Böylece o sınıf herhangi bir somut sınıfa bağlı olmayacak, tam tersi somut sınıf(lar) ilgili sınıfa 
//bağlılık sergiliyor olacaktır.
//Böylece hiç bir sınıf concrete yapılanmalara değil onların abstractionlarına güvenecektirler.

class MailService
{
    public void SendMail(IMailServer mail)
    {
        mail.Send(".....",",,,,,");
    }
}

interface IMailServer
{
    void Send(string body, string to);
}

class Gmail:IMailServer
{
    

    public void Send(string body, string to)
    {
        Console.WriteLine($"{body} send to {to} with Gmail");
    }
}

class Yandex:IMailServer
{
    public void Send(string body, string to)
    {
        Console.WriteLine($"{body} send to {to} with Yandex");
    }
    
}

class Hotmail:IMailServer
{
   

    public void Send(string body, string to)
    {
        Console.WriteLine($"{body} send to {to} with Hotmail");
    }
}

internal class Program2
{    

    static void Main(string[] args)
    {
       MailService mailService = new MailService();
       mailService.SendMail(new Yandex());

    }
}






