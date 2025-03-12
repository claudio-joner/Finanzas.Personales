using Finanzas.Personales.Consola.Dominio.Enum;

namespace Finanzas.Personales.Consola.Dominio
{
    public class Movimiento
    {
        public int IdMovimiento { get; internal set; }
        public EnumTipo TipoMovimiento { get; internal set; }
        public EnumMotivo Motivo { get; internal set; }
        public double Monto { get; internal set; }
        public string Descripcion { get; internal set; }
        public DateTime FechaCharga { get; internal set; }
        public bool Estado { get; internal set; }

        public Movimiento()
        {
            IdMovimiento = 0;
            TipoMovimiento = 0;
            Motivo = 0;
            Monto = 0;
            Descripcion = string.Empty;
            FechaCharga = DateTime.Now;
            Estado = true;            
        }

        public Movimiento(int id,EnumTipo tipo, EnumMotivo motivo, double monto,string descrip)
        {
            IdMovimiento = id;
            TipoMovimiento = tipo;
            Motivo = motivo; 
            Monto = monto;
            Descripcion = descrip;
            FechaCharga = DateTime.Now;
            Estado = true;

        }

        public override string ToString()
        {
            return $"TipoMovimiento = {TipoMovimiento} |Motivo = {Motivo} |Monto = {Monto} |Descripcion: {Descripcion}|" +
                $"Fecha carga:{FechaCharga.ToString("dd/MM/yyyy")}";

        }
    }
}