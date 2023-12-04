using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Aviones
    {
        [Key]
        public BigInteger idNumero_avion { get; set; }
        public string? modelo { get; set; }
        public int peso { get; set; }
        public int capacidad { get; set; }
    }
}
