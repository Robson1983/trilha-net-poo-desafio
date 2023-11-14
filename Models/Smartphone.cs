namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (OK)

        public string Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected string Memoria;




        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades (OK)
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}