using Calculo_Velocidade;

//Declaração variaveis

double KI; //Km inicial
double KF; //Km final
double CC; //Consumo de combustivel
double DP; //Distancia percorrida
double GC; // Gasto total combustivel

Calculo _CalculoVelocidade = new Calculo();

Console.WriteLine("Por gentileza, informe a kilometragem inicial: ");
KI = double.Parse(Console.ReadLine());

Console.WriteLine("Por gentileza, informe a kilometragem final: ");
KF = double.Parse(Console.ReadLine());

DP = _CalculoVelocidade.Calculo_Distancia_Percorrido (KF, KI);

Console.WriteLine("Por gentileza, informe o consumo de combustível em litros: ");
CC = double.Parse(Console.ReadLine());

GC = _CalculoVelocidade.Calculo_Combustivel (DP, CC);


Console.WriteLine("A cada litro consumido o veículo percorreu: {0}Km ", + GC);
Console.ReadLine();
