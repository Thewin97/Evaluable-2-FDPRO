class Entrenamiento{
    private double Distancia, Tiempo;

    public Entrenamiento(double Distancia,double Tiempo)
    {
        this.Distancia = Distancia;
        this.Tiempo = Tiempo;
        Console.WriteLine("!Entrenamiento guardado con éxito¡");
    }

    public Entrenamiento() {}
    public double GetDistancia()
    {
        return Distancia;
    }
    public double GetTiempo()
    {
        return Tiempo;
    }
    public void SetDistancia(double Distancia)
    {
        this.Distancia = Distancia;
    }
    public void SetTiempo(double Tiempo)
    {
        this.Tiempo = Tiempo;
    }

}