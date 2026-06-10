using EspacioSistema;
Console.WriteLine("Hello, World!");
//c
Empleado[] listaEmpleados= new Empleado[3];
//crear y cargar empleado
for (int i = 0; i < listaEmpleados.Length; i++)
{
    listaEmpleados[i]= new Empleado();

    //pedir datos
    //nombre
    System.Console.WriteLine("Ingrese nombre: ");
    
    listaEmpleados[i].Nombre= Console.ReadLine()?? "";
    

    //apellido
    System.Console.WriteLine("Ingrese apellido: ");
    listaEmpleados[i].Apellido= Console.ReadLine()?? "";
    

    //fecha nacimiento
    System.Console.WriteLine("Ingrese fecha de nacimiento (anio/mes/dia): ");
    if (DateTime.TryParse(Console.ReadLine(),out DateTime fechaNac))
    {
        listaEmpleados[i].FechaNac=fechaNac;
    }
    //estado civil
    System.Console.WriteLine("Ingrese estado civil: ");
    listaEmpleados[i].EstadoCivil=Console.ReadLine()??"";
    
    //Ingreso a la empresa
    System.Console.WriteLine("Ingrese fecha de ingreso(anio/mes/dia): ");
    if (DateTime.TryParse(Console.ReadLine(),out DateTime fechaIngreso))
    {
        listaEmpleados[i].FIngreso=fechaIngreso;
    }

    //sueldo Basico
    Console.Write("Ingrese el sueldo básico: ");
    if (double.TryParse(Console.ReadLine(), out double sueldo))
    {
        listaEmpleados[i].SueldoBasico = sueldo;
    }

    ////cargos
    System.Console.WriteLine("Seleccione el cargo:");
    System.Console.WriteLine("1.Auxiliar \n 2.Administrativo \n 3.Especialista \n 4.Ingeniero\n 5.Directivo");
    
    if (int.TryParse(Console.ReadLine(), out int opcion)){
        listaEmpleados[i].Cargos=(Cargos)opcion;
    }
    
}
//d
double total=0;
    foreach (Empleado empleado in listaEmpleados)
    {
        double salarioEmpleado =empleado.CalcularSalario();
        total +=salarioEmpleado;
    }
    System.Console.WriteLine($"El monto total es ${total}");

//e
Empleado empleadoJubilado=listaEmpleados[0];

foreach (Empleado emple in listaEmpleados)
{
    if (emple.aniosJubilarse() < empleadoJubilado.aniosJubilarse())
    {
        empleadoJubilado=emple;
    }
}
System.Console.WriteLine("---Empleado mas Proximo a jubilarse------");
System.Console.WriteLine($"Nombre y Apellido:{empleadoJubilado.Nombre},{empleadoJubilado.Apellido}");
System.Console.WriteLine($"Cargo:{empleadoJubilado.Cargos}");

System.Console.WriteLine($"Edad del empleado:{empleadoJubilado.edadEmpleado()} anios");
System.Console.WriteLine($"Antiguedad :{empleadoJubilado.CalcularAntiguedad()} anios");
System.Console.WriteLine($"Faltan {empleadoJubilado.aniosJubilarse()} anios para jubilarse");
