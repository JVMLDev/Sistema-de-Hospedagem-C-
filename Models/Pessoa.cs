using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                try
                {
                    _nome = value == "" ? throw new ArgumentException() : _nome = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorreto ou espaço em branco. Favor adicionar um NOME!");
                }

            }
        }
        private string _nome;
        private string _sobreNome;
        public string Sobrenome
        {
            get
            {
                return _sobreNome.ToUpper();
            }
            set
            {
                try
                {
                    _sobreNome = value == "" ? throw new ArgumentException("Valor inválido!") : _sobreNome = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorreto ou espaço em branco. Favor adicionar um SOBRENOME!");
                }

            }
        }

        public string NomeCompleto => $"{_nome} {_sobreNome}".ToUpper();

    }
}