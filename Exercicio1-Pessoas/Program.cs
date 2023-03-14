using Exercicio1_Pessoas;

internal class Program
{
    private static void Main(string[] args)
    {
        PJuridica pessoaJuri = new PJuridica();
        PFisica pessoa = new PFisica();

        pessoaJuri.Nome = "Dondic";
        pessoaJuri.email = "Dondic25@gmail.com";
        pessoaJuri.endereco = "Rua alberto chagas";
        pessoaJuri.nomefantasia = "Dirceu Ltda";
        pessoaJuri.cnpj = "42.6655456.565646/000156-55";
        pessoaJuri.telefone1 = 5569726866;
        pessoaJuri.telefone2 = 6644965695;

        pessoa.Nome = "Juliano";
        pessoa.email = "centena.rio@gmail.com";
        pessoa.endereco = "Rua alberto Barbatana";
        pessoa.cpf = "468.598.568-00";
        pessoa.telefone1 = 5569726866;
        pessoa.telefone2 = 6644965695;

        Console.WriteLine(pessoa.ToString());
        Console.WriteLine(pessoaJuri.ToString());


    }
}