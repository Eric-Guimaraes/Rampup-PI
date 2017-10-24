using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv02.Construtor.CL
{
    public class Conta
    {
        public int NumConta { get; set; }
        public string NomeTitular { get; set; }
        public int CPF { get; set; }
        public int TipoDeConta { get; set; }
        public float Saldo { get; set; }

        private void ArrayStarter()
        {
            List<Conta> ListaDeContas = new List<Conta>();
        }

        public Conta(string NomeTitular, int CPF, int TipoDeConta, List<Conta> ListaDeContas)
        {
            Conta aux = new Conta(NomeTitular, CPF, TipoDeConta, ListaDeContas);

            this.NumConta = (ListaDeContas.Count) - 1;
            this.NomeTitular = NomeTitular;
            this.CPF = CPF;
            this.TipoDeConta = TipoDeConta;
            this.Saldo = 0;

            ListaDeContas.Add(aux);
        }

        public void DeleteUser(List<Conta> ListaDeContas, int NumConta) 
        {
            for(int i=0; i<ListaDeContas.Count; i++)
            {
                if(ListaDeContas[i].NumConta == NumConta)
                {
                    ListaDeContas.Remove(ListaDeContas[i]);
                }
            }
        }

        public void CreditTransaction(List<Conta> ListaDeContas, float Value, int index)
        {
            Conta aux = ListaDeContas[index];
            aux.Saldo = aux.Saldo + Value;
        }
        public void DebitTransaction(Conta conta, float Value)
        {
            conta.Saldo = conta.Saldo - Value;
        }
        public float ConsultarSaldo(List<Conta> ListaDeContas, int NumConta)
        {
            int j = -1; //O valor -1 serve como retorno de erro, pois números de conta negativos não são válidos na estrutura que criei.

            for(int i=0; i< ListaDeContas.Count; i++)
            {
                if (ListaDeContas[i].NumConta == NumConta)
                {
                    j = i;
                }
            }
            return ListaDeContas[j].Saldo;
        }
    }
}