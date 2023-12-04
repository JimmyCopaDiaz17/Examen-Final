using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Hangares
    {
        [Key]
        public BigInteger idNumero_hangar { get; set; }
        public int capacidad { get; set; }
        public string? localizacion { get; set; }
    }
}
