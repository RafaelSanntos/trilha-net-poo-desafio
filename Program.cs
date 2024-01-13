using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Exemplo de uso da classe Iphone
  Console.WriteLine("Celular Iphone:");
  Iphone iphone = new Iphone(numero: "907129958", modelo: "iPhone 15", imei: "IMEI907", memoria: 128);
  iphone.Ligar();
  iphone.InstalarAplicativo("WhatsApp");

  Console.WriteLine();

  // Exemplo de uso da classe Nokia
  Console.WriteLine("Celular Nokia:");
  Nokia nokia = new Nokia(numero: "568535434", modelo: "Nokia 3310", imei: "IMEI326", memoria: 36);
  nokia.ReceberLigacao();
  nokia.InstalarAplicativo("Snake");

  Console.ReadLine();