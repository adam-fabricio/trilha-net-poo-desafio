using System.Formats.Asn1;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Criando um smartphone Nokia!!!");
Nokia s1 = new Nokia(numero: "123123", modelo: "a1", "111111", 4);
s1.Ligar();
s1.InstalarAplicativo("Reddit");
Console.WriteLine('\n');

var s2 = new Nokia(numero: "123123", modelo: "a2", imei:"111111", memoria:4);
s2.Ligar();
s2.InstalarAplicativo("Reddit");
Console.WriteLine('\n');

Smartphone s3 = new Nokia(numero: "123123", modelo: "a3", imei:"111111", memoria:4);
s3.Ligar();
s3.InstalarAplicativo("Reddit");
Console.WriteLine('\n');


Console.WriteLine("Criando um smartphone Iphone!!!");
var S4 = new Iphone("11111-2222", "15", "1234567890", 64);
S4.Ligar();
S4.InstalarAplicativo("Strava");
Console.WriteLine('\n');
