public abstract class Smartphone
{
    // Propriedades que representam as características de um smartphone
    public string Numero { get; private set; }
    public string Modelo { get; private set; }
    public string IMEI { get; private set; }
    public int Memoria { get; private set; }

    // Construtor que recebe os parâmetros para inicializar as propriedades
    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
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
