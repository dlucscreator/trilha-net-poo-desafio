namespace DesafioPOO.Models
{
    // A classe Iphone herda de Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que utiliza o construtor da classe base Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Configurações específicas para Iphone, se necessário
        }

        // Sobrescrita do método InstalarAplicativo para Iphone
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeAplicativo}' pela App Store...");
        }
    }
}
