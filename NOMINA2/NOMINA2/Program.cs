using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMINA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            decimal VALORHORA, numeroHORAS, salarioMinimo, salario;
            PedirDatos(out nombre, out VALORHORA, out numeroHORAS, out salarioMinimo);
            salario = CalcularSalario(numeroHORAS, VALORHORA);
            MostrarResultado(nombre, salarioMinimo, salario);
        }
        static void PedirDatos(out string nombre, out decimal VALORHORA, out decimal numeroHORAS, out decimal salarioMinimo);
            {
                console.Write("Ingrese Nombre....:");
                Nombre = Console.ReadLine();

                console.Write("Ingrese Valor Hora....:");
                VALORHORA = covert.ToDecimal(Console.ReadLine());

                console.Write("Ingrese Numero de horas trabajadas....:");
                numeroHORAS = covert.ToDecimal(Console.ReadLine());

                console.Write("Ingrese salario minimo....:");
                salarioMinimo = covert.ToDecimal(Console.ReadLine());
            }
    static decimal CalcularSalario(decimal numeroHORAS, decimal VALORHORA)
    {
        return numeroHORAS * VALORHORA;
    }
    static void MostrarResultado(string nombre, decimal salarioMinimo, decimal salario);
            {
            console.WriteLine("Nombre.....:{0}", nombre);
             if (salario > salarioMinimo)
            {
        console.WriteLine("salario.....: ${0:N2}", salario);
        }
Console.ReadKey();  
        }
    }
}