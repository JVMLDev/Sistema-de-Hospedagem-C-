using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; } 
        public int DiasReservados { get; set; }
    
       public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (Suite == null)
            {
                throw new ArgumentException("Nenhuma Suite foi cadastrada!");
            }
            
            
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("O número de hóspedes excede a capacidade da suíte");
            }
            }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = Suite.ValorDiaria * DiasReservados;
            
            if (DiasReservados >= 10)
            {
                valor *= 0.9m;

            }
            return valor; 
        }
    }
}