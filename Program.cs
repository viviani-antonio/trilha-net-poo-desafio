using System.Net.Http.Headers;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero: "14785-2963", modelo: "modelo a1", imei: "imei adezer1234", memoria: 64);
Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("joguinho");
Console.WriteLine($"Numero: {nokia.Numero} - Modelo: {nokia.modelo} - IMEI: {nokia.imei} - Memoria: {nokia.memoria}");
Console.WriteLine($"");

Iphone iphone = new Iphone(numero: "9999-8888", modelo: "IPHONE 15", imei: "IPHONE1234562", memoria: 256);
Console.WriteLine("Smartphone Iphone");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine($"Numero:{iphone.Numero} - Modelo: {iphone.modelo} - IMEI:{iphone.imei} - Memoria:{iphone.memoria}");
Console.WriteLine($"");
