using Caelum.Stella.CSharp.Http;
using System.Diagnostics;

namespace CEP 
{
    class CEP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CEP");
            String cep = Console.ReadLine();

            //string url = "https://viacep.com.br/ws/" + cep + "/json/";
            //string resultado = new HttpClient().GetStringAsync(url).Result;
            //Console.WriteLine(resultado);

            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Console.WriteLine(enderecoJson);

            //Exibe o CEP em forma de XML
            //string enderecoXml = viaCEP.GetEnderecoXml(cep);
            //Console.WriteLine(enderecoXml);

            //Exibe o CEP via Json assincrono
            //var async = viaCEP.GetEnderecoJsonAsync(cep);
            //Console.WriteLine(async.Result);

            //Exibe apenas o endereco
            var endereco = viaCEP.GetEndereco(cep);
            Console.WriteLine(String.Format("Logradouro: {0} , Bairro: {1}",endereco.Logradouro,endereco.Bairro));
        }
    }
}

