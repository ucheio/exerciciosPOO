using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Veiculo
    {
        public int Velocidade{ get; private set; }

        public void alterarVelocidade(int novaVelocidade)
        {
            if (novaVelocidade > 0 || novaVelocidade < 200)
            {
                Velocidade = novaVelocidade;
            }
            else
            {
                Console.WriteLine("Velocidade inválida");
            }
        }
    }
}