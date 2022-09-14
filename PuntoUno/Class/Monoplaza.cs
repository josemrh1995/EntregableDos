namespace PuntoUno.Class;
using PuntoUno.Interfaces;// en este lugar voy a utilizar lo que este en esta interface

public class Monoplaza : IMonoplazaInterface{// aqui estamos obligando a que la clase tenga los metodos de la interface, o de donde las este heredando
    protected int valor;
    protected Random random;
    string estado1, estado2, escuderia;

    public Monoplaza(){
        random = new Random();
    }

    public void Encender(){
        estado1 = "encendido";
        Console.WriteLine("Vehiculo encendido");
    }

    public void Apagar(){
        estado1 = "apagado";
        Console.WriteLine("Vehiculo apagado");

    }

    public void Detener(){
        estado1 = "detenido";
        Console.WriteLine("Vehiculo detenido");

    }

    public void Movimiento(){
        estado1 = "movimiento";
        Console.WriteLine("Vehiculo en movimiento");

    }

    public int Tiempo(){
        valor = random.Next(1, 999); // los limites el primero lo toma y el segundo no por lo que se debe colocar 1 mas
        return 1;
    }
    public int MostrarTiempo(){

        return 1;

    }
    public void Escuderia(){
        Console.WriteLine("Cual es la escuderia del vehiculo");
        escuderia = Console.ReadLine();

    }


}