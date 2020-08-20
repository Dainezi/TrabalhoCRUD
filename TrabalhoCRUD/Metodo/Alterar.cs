using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCRUD.Context;
using TrabalhoCRUD.Context.Models;

namespace TrabalhoCRUD.Metodo
{
    public class Alterar
    {
        public static void AlterarFuncionario()
        {

            bool validacao;
            int auxNum = 0;

            var context = new DistribuicaoContext();

            var idFuncAlterar = 0;

            var funcionarios = context.Funcionarios;

            Console.WriteLine("\nQual o Id do funcionario que você deseja alterar os dados.");
            idFuncAlterar = Convert.ToInt32(Console.ReadLine());

            do
            {
                validacao = false;
                foreach (var f in funcionarios)
                {
                    if (idFuncAlterar != f.Id)
                    {
                        validacao = true;
                        Console.WriteLine("Número inválido!!! \n Informe um novo número: ");
                        auxNum = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } while (validacao == true);



            var func = context.Funcionarios.FirstOrDefault(q => q.Id == idFuncAlterar);
            if (func != null)
            {
                Console.WriteLine($"Digite os novos dados do funcionário {func.Id}:");


                Console.WriteLine("Informe Nome: ");
                var nomeF = Console.ReadLine();
                func.Nome = nomeF;

                Console.WriteLine("Informe RG: ");
                var rgF = Console.ReadLine();
                func.Rg = rgF;

                Console.WriteLine("Informe CPF: ");
                var cpf = Console.ReadLine();
                func.Cpf = cpf;

                Console.WriteLine("Informe Data de Nascimento: ");
                var dataNasc = Console.ReadLine();
                func.DataNascimento = dataNasc;

                Console.WriteLine("Informe Endereço: ");
                var endereco = Console.ReadLine();
                func.Endereco = endereco;

                Console.WriteLine("Informe Telefone: ");
                var telefone = Console.ReadLine();
                func.Telefone = telefone;

                Console.WriteLine("Informe Função: ");
                var funcao = Console.ReadLine();
                func.Funcao = funcao;

                Console.WriteLine("Informe o CD a qual pertence: ");
                var id_CD = Convert.ToInt32(Console.ReadLine());
                func.IdCentroDistribuicao = id_CD;


                context.SaveChanges();

            }
        }



        public static void AlterarPatrimonio()
        {
            bool validacao;
            int auxNum = 0;

            var context = new DistribuicaoContext();

            var idPatAlterar = 0;

            var patrimonios = context.Patrimonios;

            Console.WriteLine("\nQual o Id do patrimonio que você deseja alterar os dados.");
            idPatAlterar = Convert.ToInt32(Console.ReadLine());

            do
            {
                validacao = false;
                foreach (var p in patrimonios)
                {
                    if (idPatAlterar != p.Id)
                    {
                        validacao = true;
                        Console.WriteLine("Número inválido!!! \n Informe um novo número: ");
                        auxNum = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } while (validacao == true);



            var pat = context.Patrimonios.FirstOrDefault(q => q.Id == idPatAlterar);
            if (pat != null)
            {
                Console.WriteLine($"Digite os novos dados do patrimonio {pat.Id}:");
                Console.WriteLine("Informe o equipamento: ");
                var equipamento = Console.ReadLine();
                pat.Equipamento = equipamento;

                Console.WriteLine("Informe o responsável: ");
                var responsavel = Console.ReadLine();
                pat.Responsavel = responsavel;

                Console.WriteLine("Informe o setor pertencente: ");
                var setor = Console.ReadLine();
                pat.Setor = setor;

                Console.WriteLine("Informe em qual CD ele está localizado: ");
                var id_CD = Convert.ToInt32(Console.ReadLine());
                pat.IdCentroDistribuicao = id_CD;

                context.SaveChanges();


            }
        }

        public static void AlterarCD()
        {

            bool validacao;
            int auxNum = 0;


            var context = new DistribuicaoContext();

            var idCDAlterar = 0;

            var centrosdistribuicao = context.CentrosDistribuicao;

            Console.WriteLine("\nQual o Id do centro de distribuição que você deseja alterar os dados.");
            idCDAlterar = Convert.ToInt32(Console.ReadLine());

            do
            {
                validacao = false;
                foreach (var centro in centrosdistribuicao)
                {
                    if (idCDAlterar != centro.Id)
                    {
                        validacao = true;
                        Console.WriteLine("Número inválido!!! \n Informe um novo número: ");
                        auxNum = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } while (validacao == true);



            var cent = context.CentrosDistribuicao.FirstOrDefault(q => q.Id == idCDAlterar);
            if (cent != null)
            {
                Console.WriteLine($"Digite os novos dados do centro de distribuição {cent.Id}:");
                Console.WriteLine("Informe Razão Social (Nome): ");
                var razao = Console.ReadLine();
                cent.RazaoSocial = razao;

                Console.WriteLine("Informe CNPJ: ");
                var cnpj = Console.ReadLine();
                cent.Cnpj = cnpj;

                Console.WriteLine("Informe Endereco: ");
                var endereco = Console.ReadLine();
                cent.Endereco = endereco;

                Console.WriteLine("Informe Telefone: ");
                var telefone = Console.ReadLine();
                cent.Telefone = telefone;

                Console.WriteLine("Informe Tipo de CD (Ramo): ");
                var tipo = Console.ReadLine();
                cent.Tipo = tipo;

                context.SaveChanges();

            }
        }
    }
}








