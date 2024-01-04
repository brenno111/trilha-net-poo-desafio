using DesafioPOO.Models;

Console.WriteLine("--- Nokia ---");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "5555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");

Console.WriteLine("--- Iphone ---");
Smartphone iphone = new Iphone(numero: "456", modelo: "Modelo 2", imei: "8888", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
