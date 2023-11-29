using DesafioPOO.Models;

Nokia nokia = new Nokia("1", "Lumia", "312331", 2048);

nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();

Iphone iphone = new Iphone("2", "iPhone 15 Pro Max", "7326838291", 8000);
iphone.InstalarAplicativo("WhatsApp.");
iphone.Ligar();
iphone.ReceberLigacao();