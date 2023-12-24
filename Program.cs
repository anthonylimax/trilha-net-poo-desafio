using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("numero", "mei", "modelo", "memoria");
        Smartphone nokia = new Nokia("numero", "mei", "modelo", "memoria");
        iphone.Ligar();
        nokia.Ligar();
        iphone.ReceberLigacao();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("whatsapp");
        iphone.InstalarAplicativo("whatsapp");
    }
}