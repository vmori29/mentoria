using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Validation;

namespace Contrato
{
    class contrato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CEP da empresa");
            string CepEmp = Console.ReadLine();
            ViaCEP via = new ViaCEP();
            string enderecoJson = via.GetEnderecoJson(CepEmp);
            var enderecoEmp = via.GetEndereco(CepEmp);

            Console.WriteLine("Digite o cnpj da empresa");
            string cnpjEmp = Console.ReadLine();
            string cnpjValid = null;
            if(new CNPJValidator().IsValid(cnpjEmp)){
                cnpjValid = cnpjEmp;
            };

            Console.WriteLine("Digite o seu RG");
            string rg = Console.ReadLine();

            Console.WriteLine("Digite o seu cpf");
            string cpf = Console.ReadLine();
            string cpfValid = null;
            if (new CPFValidator().IsValid(cpf))
            {
                cpfValid = cpf;
            };

            DateTime data = DateTime.Now;

            Console.WriteLine("Digite o CEP da empresa");
            string CepFun = Console.ReadLine();
            ViaCEP viaCep = new ViaCEP();
            string enderJson = via.GetEnderecoJson(CepFun);
            var enderecoFun = via.GetEndereco(CepFun);

            var contrato = new
            {
                
                Empresa = new
                {
                cep = CepEmp,
                logradouro = enderecoEmp.Logradouro,
                bairro = enderecoEmp.Bairro,
                localidade = enderecoEmp.Localidade,
                UF = enderecoEmp.UF,
                numero = "1135",
                RazaoSocial = "FIAP",
                cnpjEmp = cnpjValid 
                },
                Funcionario = new
                {
                nome = "Mario",
                Cargo = "Estagiario",
                Salario = 2000.10,
                SalarioEXT = "Dois mil reais e dez centavos",
                Nacionalidade = "Angolano",
                EstCiv = "Casado",
                RG = rg,
                CPF = cpfValid,
                cep = CepFun,
                logradouro = enderecoFun.Logradouro,
                bairro = enderecoFun.Bairro,
                localidade = enderecoFun.Localidade,
                UF = enderecoFun.UF,
                numero = "1135"

                },
                Testemunha = new
                {
                    nome = "Jorel",
                    RG = "84.390.411 - 1"
                },
                Inicio = data.ToString("M"),

            };

            string documento = $@"                            CONTRATO INDIVIDUAL DE TRABALHO TEMPORÁRIO

EMPREGADOR: {contrato.Empresa.RazaoSocial}, com sede à {contrato.Empresa.logradouro}, {contrato.Empresa.numero}, {contrato.Empresa.bairro}, CEP {contrato.Empresa.cep}, {contrato.Empresa.localidade}, {contrato.Empresa.UF}, inscrita no CNPJ sob nº {contrato.Empresa.cnpjEmp};

EMPREGADO: {contrato.Funcionario.nome}, {contrato.Funcionario.Nacionalidade}, {contrato.Funcionario.EstCiv}, portador da cédula de identidade R.G. nº {contrato.Funcionario.RG} e CPF/MF nº {contrato.Funcionario.CPF}, residente e domiciliado na {contrato.Funcionario.logradouro}, {contrato.Funcionario.numero}, {contrato.Funcionario.bairro}, CEP {contrato.Funcionario.cep}, {contrato.Funcionario.localidade}, {contrato.Funcionario.UF}.

Pelo presente instrumento particular de contrato individual de trabalho, fica justo e contratado o seguinte:

Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de {contrato.Inicio} e assinatura deste instrumento, seus trabalhos exercendo a função de {contrato.Funcionario.Cargo}, prestando pessoalmente o labor diário no período compreendido entre 9 horas às 18 horas, e intervalo de 1 hora para almoço;

Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo prestado a compensação de horário semanal;

Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a título de salário a importância de {contrato.Funcionario.Salario} ({contrato.Funcionario.SalarioEXT}), com os descontos previstos por lei;

Cláusula 4ª - Estará o EMPREGADO subordinado a legislação vigente no que diz respeito aos descontos de faltas e demais sanções disciplinares contidas na Consolidação das Leis do Trabalho.

Cláusula 5ª - O prazo de duração do contrato é de 2 (dois) anos, contados a partir da assinatura pelos contratantes;

Cláusula 6ª - O EMPREGADO obedecerá o regulamento interno da empresa, e filosofia de trabalho da mesma.

Como prova do acordado, assinam instrumento, afirmado e respeitando seu teor por inteiro, e firmam conjuntamente a este duas testemunhas, comprovando as razões descritas.

{contrato.Empresa.localidade}, {contrato.Inicio}


_______________________________________________________
{contrato.Empresa}

_______________________________________________________
{contrato.Funcionario.nome}

_______________________________________________________
({contrato.Testemunha.nome}, {contrato.Testemunha.RG},Testemunha)

_______________________________________________________
({contrato.Testemunha.nome}, {contrato.Testemunha.RG},Testemunha)";

        Console.WriteLine(documento);
            Console.ReadKey();
        }

        
    }
}