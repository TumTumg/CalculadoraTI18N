using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Calculadora
    {
       
        //Variaveis globais
        private double num1;
        private double num2;
        //Metodo construtor -> Instância as variaveis na memoria do computador
        public Calculadora(double num1)
        {
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
        }//Fim do metodo construtor

        //Métodos modificadores = get e set
        public double ConsultarNum1 
        {
        get { return this.num1; }
        set { this.num1 = value;}

        }//Fim do modificador

        public double ConsultarNum2 
        { 
          get { return this.num2; } 
          set { this.num2 = value;} 
        }

        //Operações
        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;
        }

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            { 
            return ConsultarNum1 / ConsultarNum2;
            {
        }
    }//Fim da classe
}//Fim do projeto
