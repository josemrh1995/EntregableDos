namespace PuntoUno.Class;
using PuntoUno.Interfaces;

public class Prueba{

    public IMonoplazaInterface Monoplaza1, Monoplaza2, Monoplaza3;// nos dice que estos dados nuevos deben tener lo que nos pide la interface

    public Prueba(IMonoplazaInterface M1, IMonoplazaInterface M2, IMonoplazaInterface M3){

        Monoplaza1 = M1;
        Monoplaza2 = M2;
        Monoplaza3 = M3;

    }

    public void RealizarPrueba (){

        Monoplaza1.Apagar();
        Monoplaza1.Encender();
        Monoplaza1.Movimiento();
        Monoplaza1.Detener();
        Monoplaza1.Apagar();
        Monoplaza1.Tiempo();


    }

}