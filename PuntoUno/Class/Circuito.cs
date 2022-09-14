namespace PuntoUno.Class;
using PuntoUno.Interfaces;

public class Circuito : Monoplaza, IMonoplazaInterface{
public IMonoplazaInterface Monoplaza1, Monoplaza2, Monoplaza3;
private int Nvueltas,VueltaActual,TiempoActual;
public int MejorTiempo = 0;

    public Circuito(IMonoplazaInterface M1, IMonoplazaInterface M2, IMonoplazaInterface M3){

        Monoplaza1 = M1;
        Monoplaza2 = M2;
        Monoplaza3 = M3;

    }
    public void AgregarMonoplaza(){
        

    }

    public void SacarMonoplaza(){

        
    }

    public void RealizarPrueba (){

        Nvueltas = random.Next(1, 100000); // los limites el primero lo toma y el segundo no por lo que se debe colocar 1 mas
        do {
            Console.WriteLine(Monoplaza1.Tiempo);  
            VueltaActual = VueltaActual + 1;
            TiempoActual = Monoplaza1.Tiempo;
            if (TiempoActual>MejorTiempo){
                MejorTiempo = TiempoActual;
            }

        } while (VueltaActual<Nvueltas);
        
        Console.WriteLine("El mejor tiempos es ", MejorTiempo);
    }


    

} 
