using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

namespace DatasHoras
{
    class DatasHoras
    {
        public static void Main(String[] args)
        {
            //Ler valor do produto e imprimir o valor extenso em reais
            Debug.WriteLine("Digite o valor do produto");
            int valor = Int32.Parse(Console.ReadLine());
            String valorExtenso = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(valor);
            Debug.WriteLine(valorExtenso);

            //Informar a data atual em extenso, tempo e dia
            DateTime data = DateTime.Now;
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("D"));
            Debug.WriteLine(data.ToString("T"));
            Debug.WriteLine(data.ToString("g"));
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));


        }

    }
}