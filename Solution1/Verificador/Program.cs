using Caelum.Stella.CSharp.Validation;

namespace Verificador
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            string cpf = "86288366757";
            ValidarCPF(cpf);

            string cnpj = "51241758000152";
            ValidarCNPJ(cnpj);

            string titulo = "041372570132";
            ValidarTitulo(titulo);
        }
        static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Console.WriteLine("cpf valido");
            }
            else
            {
                Console.WriteLine("cpf invalido");
            }
        }

        static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Console.WriteLine("CNPJ valido");
            }
            else
            {
                Console.WriteLine("CNPJ invalido");
            }
        }

        static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Console.WriteLine("Titulo valido");
            }
            else
            {
                Console.WriteLine("Titulo invalido");
            }

        }
    }
}

