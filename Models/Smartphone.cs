using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        public Smartphone(string numero, string modelo, string imei, int memoria )
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }


        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }

        protected string Modelo;

        protected string Imei;

        protected int Memoria;

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }

        }

           public string imei
        {
            get { return Imei; }
            set { Imei = value; }

        }
        
           public int memoria
        {
            get { return Memoria; }
            set { Memoria = value; }
          
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