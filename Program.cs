using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654", modelo: "Modelo 1042", imei: "123456899", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "654987", modelo: "Modelo XR", imei: "45613987", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");