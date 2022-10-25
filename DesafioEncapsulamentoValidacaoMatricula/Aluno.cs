using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEncapsulamentoValidacaoMatricula
{
    public class Aluno
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

        public int Matricula;
        public int matricula
        {
            get { return Matricula; }
            set {
                if (value <= 0)
                {
                    Console.WriteLine("O valor da matrícula não pode ser menor que zero!!");
                    Console.WriteLine();
                    return;
                } 
                else
                {
                    Matricula = value;
                }
            }
        }
   }
}
