namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // READY! TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string Emei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            // READY! TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Emei = emei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine(value: "Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine(value: "Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}