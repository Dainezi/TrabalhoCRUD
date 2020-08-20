using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCRUD.Context;
using TrabalhoCRUD.Context.Models;

namespace TrabalhoCRUD.Metodo
{
    class Inserir
    {

        public static void InserirCD()
        {

            var context = new DistribuicaoContext();

            Console.WriteLine("Você selecionou a opção de Inserir Centro de Distribuicão");
            Console.WriteLine("Informe Razão Social (Nome): ");
            var razao = Console.ReadLine();

            Console.WriteLine("Informe CNPJ: ");
            var cnpj = Console.ReadLine();

            Console.WriteLine("Informe Endereco: ");
            var endereco = Console.ReadLine();

            Console.WriteLine("Informe Telefone: ");
            var telefone = Console.ReadLine();

            Console.WriteLine("Informe Tipo de CD (Ramo): ");
            var tipo = Console.ReadLine();


            var centrosdt = new CentroDistribuicao
            {
                RazaoSocial = razao,
                Cnpj = cnpj,
                Endereco = endereco,
                Telefone = telefone,
                Tipo = tipo

                //ainda precisaria validar pra ver se este cd já existe antes de inseri-lo
            };

            context.CentrosDistribuicao.Add(centrosdt);
            context.SaveChanges();
        }
        public static void InserirPatrimonio()
        {

            var context = new DistribuicaoContext();

            Console.WriteLine("Você selecionou a opção de Inserir Patrimônio");
            Console.WriteLine("Informe o equipamento: ");
            var equipamento = Console.ReadLine();

            Console.WriteLine("Informe o responsável: ");
            var responsavel = Console.ReadLine();

            Console.WriteLine("Informe o setor pertencente: ");
            var setor = Console.ReadLine();

            Console.WriteLine("Informe em qual CD ele está localizado: ");
            var id_CD = Convert.ToInt32(Console.ReadLine());

            var patrimonios = new Patrimonio
            {
                Equipamento = equipamento,
                Responsavel = responsavel,
                Setor = setor,
                IdCentroDistribuicao = id_CD

                //ainda precisaria validar pra ver se este patrimonio já existe naquele cd antes de inseri-lo
                //ou se ja existe alguem responsavel
            };

            context.Patrimonios.Add(patrimonios);
            context.SaveChanges();
        }



        public static void InserirFuncionario()
        {

            var context = new DistribuicaoContext();

            Console.WriteLine("Você selecionou a opção de Inserir Funcionário");
            Console.WriteLine("Informe Nome: ");
            var nomeF = Console.ReadLine();

            Console.WriteLine("Informe RG: ");
            var rgF = Console.ReadLine();

            Console.WriteLine("Informe CPF: ");
            var cpf = Console.ReadLine();

            Console.WriteLine("Informe Data de Nascimento: ");
            var data = Console.ReadLine();

            Console.WriteLine("Informe Endereço: ");
            var endereco = Console.ReadLine();

            Console.WriteLine("Informe Telefone: ");
            var telefone = Console.ReadLine();

            Console.WriteLine("Informe Função: ");
            var funcao = Console.ReadLine();

            Console.WriteLine("Informe o CD a qual pertence: ");
            var id_CD = Convert.ToInt32(Console.ReadLine());

            var funcionario = new Funcionario
            {
                Nome = nomeF,
                Rg = rgF,
                Cpf = cpf,
                DataNascimento = data,
                Endereco = endereco,
                Telefone = telefone,
                Funcao = funcao,
                IdCentroDistribuicao = id_CD
                //ainda precisaria validar pra ver se este funcionario já esta neste cd antes de inseri-lo
            };

            context.Funcionarios.Add(funcionario);
            context.SaveChanges();

        }
    }
}