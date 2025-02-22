class Cuenta
{
    private string? Correo, Clave;
    private List<Entrenamiento> Entrenamientos;

    public Cuenta(String? Correo, String? Clave)
    {
        this.Correo = Correo;
        this.Clave = Clave;
        Entrenamientos = new List<Entrenamiento>();
    }

    public Cuenta(){ Entrenamientos = new List<Entrenamiento>(); }

public void VaciarEntrenamientos()
{
            Entrenamientos.Clear();
            Console.WriteLine("Lista borrada.");
}

public void ListarEntrenamientos() 
    {
        int count = 0;
        foreach (var item in Entrenamientos)
        {      
            count++;      
            Console.WriteLine(count+"- "+item.GetDistancia()+" metros en "+item.GetTiempo()+" minutos.");            
        }
    }
public void RegistrarEntrenamiento() 
    {
        Console.WriteLine("Introduce la distancia (en metros)");
        double Distancia = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el tiempo (en minutos)");
        double Tiempo = double.Parse(Console.ReadLine());
        this.Entrenamientos.Add(new Entrenamiento(Distancia,Tiempo));        
    }

    public string? GetCorreo()
    {
        return Correo;
    }

    public string? GetClave()
    {
        return Clave;
    }

    public void SetClave(string Clave)
    {
        this.Clave = Clave;
    }

    public void SetCorreo(String Correo)
    {
        this.Correo = Correo;
    }
    
}