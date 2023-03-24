namespace Calculo_Velocidade;

public class Calculo
{
    public double Calculo_Distancia_Percorrido (double KF, double KI) {

        double DP = (KF - KI);
        return DP;
    }

    public double Calculo_Combustivel (double DP, double CC) {

        double GC = (DP/CC);
        return GC;
    }
}
