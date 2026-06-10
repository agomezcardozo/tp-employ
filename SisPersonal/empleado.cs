namespace EspacioSistema;
public enum Cargos
{
    auxiliar=1,
    administrativo=2,
    especialista=3,
    ingeniero=4,
    directivo=5

}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private string estadoCivil;
    private DateTime fIngreso;
    private double sueldoBasico;
    private Cargos cargos;
    
    //Propiedades
    public string Nombre {get => nombre; set=>nombre=value;}
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public DateTime FIngreso { get => fIngreso; set => fIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargos { get => cargos; set => cargos = value; }//porque es internal?, debia poner publico a enum Cargos
    public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    //metodos

    public int CalcularAntiguedad()
    {
        int anioActual=DateTime.Today.Year;

        int antiguedad=anioActual-fIngreso.Year;

        return antiguedad;
    }

    
    public int edadEmpleado()
    {

        int anioActual=DateTime.Today.Year;
        int edad=anioActual - fechaNac.Year;

        if (DateTime.Today< fechaNac.AddYears(edad))
        {
            edad --;
        }

        return edad;
    }

    public int aniosJubilarse()
    {
        int aniosJ= 65-this.edadEmpleado();
       if (aniosJ <0)
       {
            return 0;
       }
        return aniosJ;
    }

    //ejercicio 2b
    //metodo de calcular salario
    public double CalcularSalario()
    {
        double adicional=0;
    
        int anios=this.CalcularAntiguedad();
        //antiguedad
        if (anios<=20)
        {
            adicional=sueldoBasico*(anios*0.01);
        }else 
        {
            adicional=sueldoBasico*0.25;
        }
        //cargo
        if (this.Cargos==Cargos.ingeniero || this.Cargos==Cargos.especialista)
        {
            adicional=adicional*1.50;
        }
        //estado civil
        if (estadoCivil== "casado")
        {
            adicional+=150000;
        }
        return sueldoBasico+ adicional;
    }
}