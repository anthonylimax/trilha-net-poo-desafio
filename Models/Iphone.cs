namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string MEI, string modelo, string memoria) : base(numero, MEI, modelo, memoria){

        }
        public override void InstalarAplicativo(string nomeDoApp){
            Console.WriteLine($"instalando o {nomeDoApp} no Iphone...");
        }
    }
}