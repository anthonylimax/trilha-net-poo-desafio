namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string MEI, string modelo, string memoria) : base(numero, MEI, modelo, memoria){

        }
        public override void InstalarAplicativo(string nomeDoApp){
            Console.WriteLine($"instalando o {nomeDoApp} no Nokia...");
        }
    }
}