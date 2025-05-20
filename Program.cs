using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "android nokia", imei: "123123123123", memoria: 2);

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "10", imei: "1231231321231231", memoria: 6);
iphone.Ligar();
iphone.InstalarAplicativo("Reddit");
iphone.ReceberLigacao();