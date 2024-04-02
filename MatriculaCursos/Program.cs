using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja começar o programa [S-Sim, N-Não]");
            string resp = Console.ReadLine();

            while (resp == "S")
            {

                Console.WriteLine("Digite o curso que você está interessado [D-Desenvolvimento, A-Administração, M-Mecatrônica, E-Edificações]: ");
                string curso = Console.ReadLine();

                switch (curso)
                {
                    case "D":
                        int contD = 0;
                        while (contD <= 5)
                        {
                            Console.WriteLine("Deseja cadastrar sua matrícula [S-Sim ou N-Não]? ");
                            string M = Console.ReadLine();

                            if (M == "S")
                            {
                                Console.WriteLine("O aluno foi cadastrado em Desenvolvimento.");
                                contD++;
                            }
                            else
                            {
                                Console.Write("O aluno não foi cadastrado em Desenvolvimento.");
                            }
                        }
                        while (contD > 5)
                        {
                            Console.WriteLine("Não há mais vagas disponiveis para Desenvolvimento.");
                        }
                        break;

                    case "A":
                        int contA = 0;
                        while (contA <= 5)
                        {
                            Console.WriteLine("Deseja cadastrar sua matrícula [S-Sim ou N-Não]? ");
                            string M = Console.ReadLine();

                            if (M == "S")
                            {
                                contA++;
                                Console.WriteLine("O aluno foi cadastrado em Administração.");
                            }
                            else
                            {
                                Console.Write("O aluno não foi cadastrado em Administração.");
                            }
                        }
                        while (contA > 5)
                        {
                            Console.WriteLine("Não há mais vagas disponiveis para Administrção.");
                        }
                        break;

                    case "M":
                        int contM = 0;
                        while (contM <= 5)
                        {
                            Console.WriteLine("Deseja cadastrar sua matrícula [S-Sim ou N-Não]? ");
                            string M = Console.ReadLine();

                            if (M == "S")
                            {
                                contM++;
                                Console.WriteLine("O aluno foi cadastrado em Mecatrônica.");
                            }
                            else
                            {
                                Console.Write("O aluno não foi cadastrado em Mecatrônica.");
                            }
                        }
                        while (contM > 5)
                        {
                            Console.WriteLine("Não há mais vagas disponiveis para Mecatrônica.");
                        }
                        break;

                    case "E":
                        int contE = 0;
                        while (contE <= 5)
                        {
                            Console.WriteLine("Deseja cadastrar sua matrícula [S-Sim ou N-Não]? ");
                            string M = Console.ReadLine();

                            if (M == "S")
                            {
                                contE++;
                                Console.WriteLine("O aluno foi cadastrado em Edificações.");
                            }
                            else
                            {
                                Console.Write("O aluno não foi cadastrado em Edificações.");
                            }
                        }
                        while (contE > 5)
                        {
                            Console.WriteLine("Não há mais vagas disponiveis para Edificações.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                    break;

                Console.WriteLine("Foram cadastrados" + contD + "Alunos em Desenvolvimento");
                Console.WriteLine("Foram cadastrados" + contA + "Alunos em Administração");
                Console.WriteLine("Foram cadastrados" + contM + "Alunos em Mecatrônica");
                Console.WriteLine("Foram cadastrados" + contE + "Alunos em Edificações");

                }

                Console.WriteLine("Deseja continuar [S-Sim, N-Não]? ");
                resp = Console.ReadLine();
            }
        }
    }
}
