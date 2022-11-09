using DesafioPOO.Models;

// READY! TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "362515456", modelo: "bg15", emei: "114455", memoria: 16);
n1.Ligar();
n1.InstalarAplicativo(nomeApp: "WhatsApp");

Iphone i1 = new Iphone(numero: "558412514", modelo: "Ib9", emei: "777888", memoria: 64);
i1.ReceberLigacao();
i1.InstalarAplicativo(nomeApp: "Telegram");