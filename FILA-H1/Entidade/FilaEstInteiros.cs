using System;
using System.Collections.Generic;
using System.Text;


namespace FILA_H1.Entidade
{
    public class GerenciadorFilaAtendimento
    {
        private Queue<int> _filaAtendimento;
        private int _proximoNumeroParaGerar = 1;

        public FilaAtendimento()
        {
            _filaAtendimento = new Queue<int>();
        }

        public int GerarSenha()
        {
            _filaAtendimento.Enqueue(_proximoNumeroParaGerar);

            Console.WriteLine("Senha gerada.");

            return _proximoNumeroParaGerar++;
        }

        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _filaAtendimento.Dequeue();

            Console.WriteLine($"Próxima senha: {proximoNumeroDaFila}");
        }

        public void MostrarFila()
        {
            Console.Write("Senhas da Fila: ");

            foreach (var senha in _filaAtendimento)
            {
                Console.Write(senha + " ");
            }

            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            _filaAtendimento.Clear();
        }
    }
}