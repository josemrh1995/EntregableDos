using PuntoUno.Class;
Monoplaza Monoplaza1 = new Monoplaza();
Monoplaza Monoplaza2 = new Monoplaza();
Monoplaza Monoplaza3 = new Monoplaza();

Prueba Pista = new Prueba(Monoplaza1, Monoplaza2, Monoplaza3);

Circuito.RealizarPrueba();
Console.WriteLine(Circuito.SacarMonoplaza());