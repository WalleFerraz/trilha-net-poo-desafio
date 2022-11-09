namespace DesafioPOO.Models
{
    //READY! TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // READY! TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando: " + nomeApp + " no celular Iphone.");
        }
    }
}