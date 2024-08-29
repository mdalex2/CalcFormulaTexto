using Microsoft.CodeAnalysis.CSharp.Scripting;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string formula = "(PrecioBase * 0.9M)/1.21M + Impuesto";

        decimal precioBase = 100M;

        decimal impuesto = 20M;



        formula = formula.Replace("PrecioBase", precioBase.ToString());

        formula = formula.Replace("Impuesto", impuesto.ToString());



        try

        {

            var result = await CSharpScript.EvaluateAsync<decimal>(formula);

            Console.WriteLine("Resultado: " + result);

        }

        catch (Exception ex)

        {

            Console.WriteLine("Error al evaluar la fórmula: " + ex.Message);

        }
    }
}