using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication3.Modelo
{
    public class Pilotos
    {
        [Key]
        public BigInteger idNumero_licencia {  get; set; }
        public string restricciones { get; set; }
        public int salario { get; set; }
        public string turno { get; set; }
    }
}
