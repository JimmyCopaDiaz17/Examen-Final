using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Pilotos_avion
    {
        [Key]
        public BigInteger idNumero_licencia { get; set; }
        [Key]
        public BigInteger? Numero_avion { get; set; }
    }
}
