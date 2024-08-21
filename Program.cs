using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Implementado!
Console.WriteLine("Smartphone Nokia");
Nokia nokia= new Nokia(numero: "99999999999", modelo: "Modelo C01", imei:"123456", memoria:64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone");
Iphone iphone= new Iphone(numero:"99999999999", modelo:"Modelo 15" ,imei: "2222222", memoria:128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

