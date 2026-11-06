using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set;}

        public Funcionario(string? nome, string cargo, decimal salarioInicial)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salarioInicial;
        }
        public void AumentarSalario(decimal porcentagemAumento)
        {
            Salario += Salario * (porcentagemAumento / 100m);
        }
        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário atual é igual a: {Salario}");
        }
    }
 }
