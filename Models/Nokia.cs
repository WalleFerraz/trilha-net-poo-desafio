

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // READY! TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando: " + nomeApp + " no celular Nokia.");
        }
    }
}