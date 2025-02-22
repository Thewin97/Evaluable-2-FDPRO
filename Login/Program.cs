using System.Runtime.InteropServices;

class Program
{
    static List<Cuenta> Cuentas = new List<Cuenta>();
    static Cuenta? CuentaActual;
    static int opcion;
    static int OpcionLogin;
    public static void Main(string[] args)
    {
        Console.WriteLine(">>> Sistema de cuentas <<<");
        do
        {
            Thread.Sleep(1000);
            Console.WriteLine("Opciones: ");
            Console.WriteLine("1. Registrar cuenta");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                RegistrarCuenta();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("¡Hasta luego!");
            }
            else if (opcion == 2)
            {
                IniciarSesion();
            }
            else if (opcion == 4)
            {
                VerCuentas();
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }
        } while (opcion != 3);
    }

    static void IniciarSesion()
    {
        Console.WriteLine("Introduzca su Correo");
        string? Correo = Console.ReadLine();
        Console.WriteLine("Introduzca contraseña");
        string? Clave = Console.ReadLine();
        foreach (var cuentas in Cuentas)
        {
            if (cuentas.GetCorreo().Equals(Correo) && cuentas.GetClave().Equals(Clave, StringComparison.Ordinal))
            {
                CuentaActual = cuentas;
                Console.WriteLine("Iniciaste sesión");
                do
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Opciones: ");
                    Console.WriteLine("1. Registrar un entrenamiento");
                    Console.WriteLine("2. Listar entrenamientos");
                    Console.WriteLine("3. Vaciar entrenamientos");
                    Console.WriteLine("4. Cerrar sesión");
                    Console.Write("Seleccione una opción: ");
                    OpcionLogin = int.Parse(Console.ReadLine());
                    if (OpcionLogin == 1)
                    {
                        CuentaActual.RegistrarEntrenamiento();
                    }
                    else if (OpcionLogin == 2)
                    {
                        CuentaActual.ListarEntrenamientos();
                    }
                    else if (OpcionLogin == 3)
                    {
                        CuentaActual.VaciarEntrenamientos();
                    }
                    else if (OpcionLogin == 4)
                    {
                        Console.WriteLine("Cerraste sesión");
                        opcion = 1;
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida");
                    }
                } while (OpcionLogin != 4);
                return;
            }
        }
        Console.WriteLine("Correo/Clave incorrecta");
    }
    static void RegistrarCuenta()
    {
        Console.WriteLine("Introduzca su Correo");
        string? Correo = Console.ReadLine();
        foreach (var cuenta in Cuentas)
        {
            if (cuenta.GetCorreo().Equals(Correo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ya existe una cuenta con ese Correo");
                return;
            }
        }
        Console.WriteLine("Introduzca contraseña");
        string? Clave = Console.ReadLine();
        Cuentas.Add(new Cuenta(Correo, Clave));
        Console.WriteLine("Cuenta registrada con éxito.");
    }

    static void VerCuentas()
    {
        foreach (var cuenta in Cuentas)
        {
            Console.WriteLine(cuenta + " " + cuenta.GetCorreo() + " - " + cuenta.GetClave());
        }
    }
}

