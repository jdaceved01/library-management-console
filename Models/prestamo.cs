public class Prestamo
{
    public int Id { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime? FechaDevolucion { get; set; }
    public EstadoPrestamo Estado { get; set; }

    public Prestamo()
    {
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    public Prestamo(int id, DateTime fechaPrestamo, DateTime fechaLimite)
    {
        Id = id;
        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    public bool EstaVencido()
    {
        return DateTime.Now > FechaLimite && Estado == EstadoPrestamo.Activo;
    }

    public int DiasTranscurridos()
    {
        return (DateTime.Now - FechaPrestamo).Days;
    }

    public string ResumenCorto()
    {
        return $"Prestamo {Id} - Estado: {Estado}";
    }

    public string DetalleCompleto()
    {
        return $"ID: {Id}, Estado: {Estado}, FechaPrestamo: {FechaPrestamo}, FechaLimite: {FechaLimite}, FechaDevolucion: {FechaDevolucion}";
    }

    public override string ToString()
    {
        return ResumenCorto();
    }
}
