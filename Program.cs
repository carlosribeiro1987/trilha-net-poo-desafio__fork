using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia ", "00000000000001", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Calculadora");
Iphone iphone = new Iphone("987654321", "iPhone 15", "00000000000002", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
