using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraTDD
    {
        private List<string> listaHistorico;
        private readonly string Data;
        public CalculadoraTDD(string data)
        {
            data = data;
            listaHistorico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            listaHistorico.Insert(0, "Resultado: " + (num1 + num2) + "Data : " + Data);
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            listaHistorico.Insert(0, "Resultado: " + (num1 - num2) + "Data : " + Data);
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            listaHistorico.Insert(0, "Resultado: " + (num1 * num2) + "Data : " + Data);
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            listaHistorico.Insert(0, "Resultado: " + (num1 / num2) + "Data : " + Data);
            return num1 / num2;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}