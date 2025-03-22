using Herencia_Polimorfismo;


Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

AutoCombustión combus = new AutoCombustión(2025, "Rojo", "Ferrari");

combus.InformacionVehiculo();
combus.encender();
combus.acelerar();
combus.frenar();
combus.frenar();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());

