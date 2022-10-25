using Caelum.Stella.CSharp.Vault;
using System.Diagnostics;
using System.Globalization;

namespace Dinheiro
{
    class Program
    {
        static void Main(String[] args)
        {
            float[] array = new float[5];
            Console.WriteLine("Digite o valor dos 5 produtos");
            for (int i = 0; i < array.Length; i++) { 
            array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Money money = array[i];
                Debug.WriteLine(money);
            }

            Money total = array[1] + array[2] + array[0] + array[3]+ array[4];
            Debug.WriteLine("O total eh: " + total);

            Money totalEUR = total / 5.30;
            Money euro = new Money(Currency.EUR, totalEUR);

            Debug.WriteLine("O total convertido em euros eh: " + euro);

            Money totalUS = new Money(Currency.USD,total / 5.32);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine("O total convertido em dolares eh: " + totalUS);




        }
    }
}
