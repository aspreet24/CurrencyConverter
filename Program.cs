using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string FirstCurreny,SecondCurrency;
            int chooseFirst,chooseSecond;
            double convertinUSD=default,convertinother=default,amount=default;
            var Currencynames = new HashSet<string> { "USD", "CAD", "EUR", "AUD", "CNY","GBP","MXN","KRW","INR","BRL" };
            var userresp= new HashSet<string> {"YES","Y","NO","N"};
            string answer;

          do{
              
            Console.WriteLine("Choose the currency \n USD \n CAD \n EUR \n AUD \n CNY \n GBP \n MXN \n KRW \n INR \n BRL");
            string FirstCurreny = Console.ReadLine();

           
            do{ 
                if(FirstCurreny=="USD")
                {
                
                    Console.WriteLine("Please Enter Amount");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount;                                        
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");

                }else if(FirstCurreny=="CAD"){
                        
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    

                }else if(FirstCurreny=="CAD"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }else if(FirstCurreny=="EUR"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");  

                }else if(FirstCurreny=="AUD"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }else if(FirstCurreny=="CNY"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }else if(FirstCurreny=="GBP"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }else if(FirstCurreny=="MXN"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                   Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                
                }else if(FirstCurreny=="KRW"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }else if(FirstCurreny=="INR"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                
                }else if(FirstCurreny=="BRL"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.83;
                   Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }
            }while(!Currencynames.Contains(FirstCurreny));

           //Taking Second String 
            Console.WriteLine("Choose the second currency to convert in \n USD \n CAD \n EUR \n AUD \n CNY \n GBP \n MXN \n KRW \n INR \n BRL");
            string SecondCurrency = Console.ReadLine();
            
            if(SecondCurrency=="USD")
            {   
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
                
            }else if(SecondCurrency=="CAD"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
                
            }else if(SecondCurrency=="CAD"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="EUR"){
                convertinother = convertinUSD * 0.82;
                Console.WriteLine("Amount converted in  {0}  Euro",convertinother);
            }else if(SecondCurrency=="AUD"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="CNY"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="GBP"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="MXN"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="KRW"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="INR"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="BRL"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }
        do{
        Console.WriteLine("if you want to continue please type Y and if not type N");
        answer =Console.ReadLine();
        }while(!userresp.Contains(answer));
        


        }while(userresp.Contains(answer));
        }
    }
}
