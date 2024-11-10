namespace DesafioPOO.Models
{
    // A classe Nokia herda de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia que utiliza o construtor da classe base Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Configurações específicas para Nokia, se necessário
        }

        // Sobrescrita do método InstalarAplicativo
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeAplicativo}' pela Nokia Store...");
        }
    }
}
