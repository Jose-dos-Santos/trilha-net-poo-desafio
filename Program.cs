using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone celularNokia = new Nokia(numero:"12 1234-56789", imei:"FDTY$%#@#H", memoria: 64, modelo: "XPT07");
celularNokia.Ligar();
celularNokia.InstalarAplicativo("You tube");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone celularIphone = new Iphone(numero: "12 9874-5612", imei: "JGD345@#jh&", memoria: 64, modelo: "X12");
celularIphone.Ligar();
celularIphone.InstalarAplicativo("Mercado livre");