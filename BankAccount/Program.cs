using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount.Resources;
using BankAccount.Exceptions;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using BankAccount.Extensions;

namespace BankAccount
{
    class Program
    {
        readonly ChequingAccount chequing = new ChequingAccount(5, 1.00);
        readonly SavingsAccount savings = new SavingsAccount(5, 1.00);
        readonly GlobalSavingsAccount global = new GlobalSavingsAccount(5, 1.00);
         static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            bool errmenu = true;
            do
            {
                try
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append("Please select your account type:\n");
                    builder.Append("A: Savings\n");
                    builder.Append("B: Checking\n");
                    builder.Append("C: GlobalSavings\n");
                    builder.Append("Q: Quit");
                    Console.WriteLine(builder.ToString());
                    string input = Console.ReadLine().ToUpper();
                    switch (input)
                    {
                        case "A":
                            SavingsMenu();
                            break;
                        case "B":
                            ChequingMenu();
                            break;
                        case "C":
                            GlobalSavingsMenu();
                            break;
                        case "Q":
                            Environment.Exit(0);
                            break;
                        default:
                            throw new IllegalMainMenuOptionException("Unknown option \"" + input + "\"");
                    }
                    errmenu = false;
                }
                catch (IllegalMainMenuOptionException ex)
                {
                    Console.WriteLine(ex.Message);
                    errmenu = true;
                }
            } while (errmenu);
            
            
        }
        public static void SavingsMenu()
        {
            bool errmenu = true;
            do
            {
                try
                {
                    SavingsAccount savings = new SavingsAccount(5, 1.00);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Savings Menu\n");
                    sb.Append("A. Deposit\n");
                    sb.Append("B. Withdrawal\n");
                    sb.Append("C. Close + Report\n");
                    sb.Append("R. Return to Bank Menu\n");
                    Console.WriteLine(sb.ToString());
                    string sinput = Console.ReadLine().ToUpper();
                    switch (sinput)
                    {
                        case "A":
                            bool depositerror = true;
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Please enter the deposit amount:");
                                    string deposit = Console.ReadLine();
                                    bool validdeposit = Double.TryParse(deposit, out double depositvalue);

                                    if (validdeposit)
                                    {
                                        savings.MakeDeposit(depositvalue);
                                    }
                                    else
                                    {
                                        throw new NumberValueException("\"" + deposit + "\" is not a numeric value.");
                                    }
                                    depositerror = false;
                                }
                                catch (NumberValueException nex)
                                {
                                    Console.WriteLine(nex.Message);
                                    depositerror = true;
                                }
                            } while (depositerror);
                            break;
                        case "B":
                            bool withdrawalerror = true;
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Please enter the withdrawal amount:");
                                    string withdrawal = Console.ReadLine();
                                    bool validwithdrawal = Double.TryParse(withdrawal, out double withdrawalvalue);

                                    if (validwithdrawal)
                                    {
                                        savings.MakeDeposit(withdrawalvalue);
                                    }
                                    else
                                    {
                                        throw new NumberValueException("\"" + withdrawal + "\" is not a numeric value.");
                                    }
                                    withdrawalerror = false;
                                }
                                catch (NumberValueException nex)
                                {
                                    Console.WriteLine(nex.Message);
                                    withdrawalerror = true;
                                }
                            } while (withdrawalerror);
                            break;
                        case "C":
                            savings.CloseAndReport();
                            break;
                        case "R":
                            MainMenu();
                            break;
                        default:
                            throw new IllegalSavingsMenuOptionException("Unkown option \"" + sinput + "\"");
                    }
                }
                catch (IllegalSavingsMenuOptionException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            } while (errmenu);
        }
        public static void ChequingMenu()
        {
            bool errmenu = true;
            do
            {
                try
                {
                    ChequingAccount chequing = new ChequingAccount(5, 1.00);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Chequing Menu\n");
                    sb.Append("A. Deposit\n");
                    sb.Append("B. Withdrawal\n");
                    sb.Append("C. Close + Report\n");
                    sb.Append("R. Return to Bank Menu\n");
                    Console.WriteLine(sb.ToString());
                    string sinput = Console.ReadLine().ToUpper();
                    switch (sinput)
                    {
                        case "A":
                            bool depositerror = true;
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Please enter the deposit amount:");
                                    string deposit = Console.ReadLine();
                                    bool validdeposit = Double.TryParse(deposit, out double depositvalue);

                                    if (validdeposit)
                                    {
                                        chequing.MakeDeposit(depositvalue);
                                    }
                                    else
                                    {
                                        throw new NumberValueException("\"" + deposit + "\" is not a numeric value.");
                                    }
                                    depositerror = false;
                                }
                                catch (NumberValueException nex)
                                {
                                    Console.WriteLine(nex.Message);
                                    depositerror = true;
                                }
                            } while (depositerror);
                            break;
                        case "B":
                            bool withdrawalerror = true;
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Please enter the withdrawal amount:");
                                    string withdrawal = Console.ReadLine();
                                    bool validwithdrawal = Double.TryParse(withdrawal, out double withdrawalvalue);

                                    if (validwithdrawal)
                                    {
                                        chequing.MakeDeposit(withdrawalvalue);
                                    }
                                    else
                                    {
                                        throw new NumberValueException("\"" + withdrawal + "\" is not a numeric value.");
                                    }
                                    withdrawalerror = false;
                                }
                                catch (NumberValueException nex)
                                {
                                    Console.WriteLine(nex.Message);
                                    withdrawalerror = true;
                                }
                            } while (withdrawalerror);
                            break;
                        case "C":
                            chequing.CloseAndReport();
                            break;
                        case "R":
                            MainMenu();
                            break;
                        default:
                            throw new IllegalSavingsMenuOptionException("Unkown option \"" + sinput + "\"");
                    }
                    errmenu = false;
                }
                catch (IllegalSavingsMenuOptionException ex)
                {
                    Console.WriteLine(ex.Message);
                    errmenu = true;
                }
            } while (errmenu);
            
        }
        public static void GlobalSavingsMenu()
        {
            try
            {
                GlobalSavingsAccount global = new GlobalSavingsAccount(5, 1.00);
                StringBuilder sb = new StringBuilder();
                sb.Append("Global Savings Menu\n");
                sb.Append("A. Deposit\n");
                sb.Append("B. Withdrawal\n");
                sb.Append("C. Close + Report\n");
                sb.Append("D. Report Balance in USD");
                sb.Append("R. Return to Bank Menu\n");
                Console.WriteLine(sb.ToString());
                string sinput = Console.ReadLine().ToUpper();
                switch (sinput)
                {
                    case "A":
                        bool depositerror = true;
                        do
                        {
                            try
                            {

                                Console.WriteLine("Please enter the deposit amount:");
                                string deposit = Console.ReadLine();
                                bool validdeposit = Double.TryParse(deposit, out double depositvalue);

                                if (validdeposit)
                                {
                                    global.MakeDeposit(depositvalue);
                                }
                                else
                                {
                                    throw new NumberValueException("\"" + deposit + "\" is not a numeric value.");
                                }
                                depositerror = false;
                            }
                            catch (NumberValueException nex)
                            {
                                Console.WriteLine(nex.Message);
                                depositerror = true;
                            }
                        } while (depositerror);
                        break;
                    case "B":
                        bool withdrawalerror = true;
                        do
                        {
                            try
                            {

                                Console.WriteLine("Please enter the withdrawal amount:");
                                string withdrawal = Console.ReadLine();
                                bool validwithdrawal = Double.TryParse(withdrawal, out double withdrawalvalue);

                                if (validwithdrawal)
                                {
                                    global.MakeDeposit(withdrawalvalue);
                                }
                                else
                                {
                                    throw new NumberValueException("\"" + withdrawal + "\" is not a numeric value.");
                                }
                                withdrawalerror = false;
                            }
                            catch (NumberValueException nex)
                            {
                                Console.WriteLine(nex.Message);
                                withdrawalerror = true;
                            }
                        } while (withdrawalerror);
                        break;
                    case "C":
                        global.CloseAndReport();
                        break;
                    case "D":
                        Console.WriteLine(global.GetPercentageChange());
                        break;
                    case "R":
                        MainMenu();
                        break;
                    default:
                        throw new IllegalSavingsMenuOptionException("Unkown option \"" + sinput + "\"");
                }
            }
            catch (IllegalSavingsMenuOptionException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
