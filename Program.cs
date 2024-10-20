using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("12345678", "Tijolão", "111111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Gmail");

Console.WriteLine();

Console.WriteLine("Iphone:");

Smartphone iphone = new Iphone("87654321", "15 Pro Max", "222222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");