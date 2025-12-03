using System.Diagnostics;
using SistemaHospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();
try
{
    Pessoa p1 = new Pessoa(nome: "vitor", sobrenome: "maciel");
    Pessoa p2 = new Pessoa(nome: "Marcela", sobrenome: "Cassandra");
    
    hospedes.Add(p1);
    hospedes.Add(p2);
    
    

    Suite suite = new Suite(tipoSuite: "Master Class", capacidade: 2, valorDiaria: 300);



    Reserva reservas = new Reserva(diasReservados: 4);

    reservas.CadastrarSuite(suite);
    reservas.CadastrarHospedes(hospedes);

    Console.WriteLine("------------------PAINEL-----------------------");

    Console.WriteLine($"Nome Suite: {suite.TipoSuite}");
    Console.WriteLine($"Capacidade do Quarto: {suite.Capacidade} Pessoa(s)");
    Console.WriteLine($"Quantidade de Hospedes: {reservas.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Nome dos Hospede(s): {p1.NomeCompleto} | {p2.NomeCompleto}");
    Console.WriteLine($"Total a pagar: {reservas.CalcularValorDiaria():C}");
    Console.WriteLine("------------------------------------------------");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


