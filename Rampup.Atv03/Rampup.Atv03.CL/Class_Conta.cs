using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv02.Construtor.CL
{
    class Conta
    {
        int NumConta { get; set; }
        string NomeTitular { get; set; }
        int CPF { get; set; }
        int TipoDeConta { get; set; }
        float Saldo { get; set; }

        public Conta(int NumConta, string NomeTitular, int CPF, int TipoDeConta)
        {
            Conta conta = new Conta();
            this.NumConta = NumConta;
            this.NomeTitular = NomeTitular;
            this.CPF = CPF;
            this.TipoDeConta = TipoDeConta;
            this.Saldo = 0;
            
        }

        public void CreditTransaction(Conta conta, float Value, int index)
        {
            conta[index].Saldo = conta.Saldo + Value;
        }
        public void DebitTransaction(Conta conta, float Value)
        {
            conta.Saldo = conta.Saldo - Value;
        }
        public float Consultar_Saldo(Conta conta)
        {

        }
    }
    public class ArrayList : Conta
}
