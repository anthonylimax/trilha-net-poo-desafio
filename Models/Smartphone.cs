namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string MEI;
        private string memoria;
        private string modelo;
        public string numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string MEI, string modelo, string memoria)
        {

            this.numero = numero;
            this.memoria = memoria;
            this.MEI = MEI;
            this.modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}