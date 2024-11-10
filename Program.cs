using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Nokia
            Console.WriteLine("### Testando o Nokia ###");
            Nokia nokia = new Nokia(numero: "11987654321", modelo: "Nokia 3310", imei: "123456789", memoria: 64);
            
            // Testando métodos da classe Nokia
            Console.WriteLine($"Número: {nokia.Numero}");
            nokia.FazerLigacao();
            nokia.EnviarMensagem("Olá! Este é um teste de mensagem.");
            nokia.InstalarAplicativo("WhatsApp");

            // Teste com a classe Iphone
            Console.WriteLine("\n### Testando o iPhone ###");
            Iphone iphone = new Iphone(numero: "11912345678", modelo: "iPhone 12", imei: "987654321", memoria: 128);
            
            // Testando métodos da classe iPhone
            Console.WriteLine($"Número: {iphone.Numero}");
            iphone.FazerLigacao();
            iphone.EnviarMensagem("Olá! Testando envio de mensagem.");
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("\nTestes concluídos.");
        }
    }
}
