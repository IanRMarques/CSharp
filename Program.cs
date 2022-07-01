using System;

namespace PrimeiroProjeto
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_do_Ian= new ContaCorrente("Ian", 12345, 789, 10);
            
            Console.WriteLine(
             "A conta é do " + conta_do_Ian.Titular +
              ", A agência é " + conta_do_Ian.Agencia +
             ", Numero de conta é "+ conta_do_Ian.Numero + 
             ", O saldo é "+ conta_do_Ian.Saldo);
             

             ContaCorrente conta_do_jose= new ContaCorrente("José", 54321, 298, 104);

             Console.WriteLine(
             "A conta é do " + conta_do_jose.Titular +
              ", A agência é " + conta_do_jose.Agencia +
             ", Numero de conta é "+ conta_do_jose.Numero + 
             ", O saldo é "+ conta_do_jose.Saldo);
             

             ContaCorrente conta_do_ziss= new ContaCorrente("Ziss", 1, 1, -104);
        
             Console.WriteLine(
             "A conta é do " + conta_do_ziss.Titular +
              ", A agência é " + conta_do_ziss.Agencia +
             ", Numero de conta é "+ conta_do_ziss.Numero + 
             ", O saldo é "+ conta_do_ziss.Saldo);
            
        }

    }
}