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
            
            double convertinUSD=default,convertinother=default,amount=default;
            var Currencynames = new HashSet<string> { "USD", "CAD", "EUR", "AUD", "CNY","GBP","MXN","KRW","INR","BRL" };
            var userresp= new HashSet<string> {"Y","N"};
            string answer, FirstCurreny,SecondCurrency;
        do{

                do{
                    
                    Console.WriteLine("Choose the currency \n USD \n CAD \n EUR \n AUD \n CNY \n GBP \n MXN \n KRW \n INR \n BRL");
                     FirstCurreny= Console.ReadLine().ToUpper();
                     if(!Currencynames.Contains(FirstCurreny)){
                        Console.WriteLine("doesn't exsit please check and try again");
                    }

                }while(!Currencynames.Contains(FirstCurreny));
                
                do{
                    
                     Console.WriteLine("Please Enter Amount");
                        amount = double.Parse(Console.ReadLine());
                     if(amount>=0){
                        Console.WriteLine("Amount should be positive number and Should not include any special character or string");
                    }

                }while(amount>=0);
             
                
                if(FirstCurreny=="USD")
                {
                
                    convertinUSD=amount;                                        
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");

                }else if(FirstCurreny=="CAD"){
                        
                    
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
                    convertinUSD=amount*1.21;
                    Console.WriteLine($"{amount} converted in Euro {convertinUSD}");  

                }else if(FirstCurreny=="AUD"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.77;
                    Console.WriteLine($"{amount} converted in AUD {convertinUSD}");
                    
                }else if(FirstCurreny=="CNY"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.16;
                    Console.WriteLine($"{amount} converted in CNY {convertinUSD}");
                    
                }else if(FirstCurreny=="GBP"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*1.41;
                    Console.WriteLine($"{amount} converted in GBP {convertinUSD}");
                    
                }else if(FirstCurreny=="MXN"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.051;
                   Console.WriteLine($"{amount} converted in MXN {convertinUSD}");
                
                }else if(FirstCurreny=="KRW"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.000920;
                    Console.WriteLine($"{amount} converted in KRW {convertinUSD}");
                    
                }else if(FirstCurreny=="INR"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.014;
                    Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                
                }else if(FirstCurreny=="BRL"){
                    Console.WriteLine("Please Enter Amount ");
                    amount = double.Parse(Console.ReadLine());
                    convertinUSD=amount*0.20;
                   Console.WriteLine($"{amount} converted in USD {convertinUSD}");
                    
                }
            

           //Taking Second String 
                do{
                        Console.WriteLine("Choose the second currency to convert in \n USD \n CAD \n EUR \n AUD \n CNY \n GBP \n MXN \n KRW \n INR \n BRL");
                         SecondCurrency = Console.ReadLine().ToUpper();
                        if(!Currencynames.Contains(SecondCurrency)){
                                Console.WriteLine("doesn't exsit please check and try again");
                        }
                    }while(!Currencynames.Contains(SecondCurrency)); 

            if(SecondCurrency=="USD")
            {   
                convertinother = convertinUSD;
                Console.WriteLine("Amount converted in  {0}  USD",convertinother);
                
            }else if(SecondCurrency=="CAD"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
                
            }else if(SecondCurrency=="CAD"){
                convertinother = convertinUSD * 1.21;
                Console.WriteLine("Amount converted in  {0}  CAD",convertinother);
            }else if(SecondCurrency=="EUR"){
                convertinother = convertinUSD * 0.83;
                Console.WriteLine("Amount converted in  {0}  Euro",convertinother);
            }else if(SecondCurrency=="AUD"){
                convertinother = convertinUSD * 1.30;
                Console.WriteLine("Amount converted in  {0}  AUD",convertinother);
            }else if(SecondCurrency=="CNY"){
                convertinother = convertinUSD * 6.40;
                Console.WriteLine("Amount converted in  {0}  CNY",convertinother);
            }else if(SecondCurrency=="GBP"){
                convertinother = convertinUSD * 0.71;
                Console.WriteLine("Amount converted in  {0}  GBP",convertinother);
            }else if(SecondCurrency=="MXN"){
                convertinother = convertinUSD * 19.74;
                Console.WriteLine("Amount converted in  {0}  MXN",convertinother);
            }else if(SecondCurrency=="KRW"){
                convertinother = convertinUSD * 1115.96;
                Console.WriteLine("Amount converted in  {0}  KRW",convertinother);
            }else if(SecondCurrency=="INR"){
                convertinother = convertinUSD * 73.23;
                Console.WriteLine("Amount converted in  {0}  INR",convertinother);
            }else if(SecondCurrency=="BRL"){
                convertinother = convertinUSD * 5.10;
                Console.WriteLine("Amount converted in  {0}  BRL",convertinother);
            }
        
            do{
                Console.WriteLine("if you want to continue please type Y and if not type N");
                answer =Console.ReadLine().ToUpper();
                if(!userresp.Contains(answer)){
                        Console.WriteLine("Please choose in between the Two Characters Only Y or N");
                    }
            }while(!userresp.Contains(answer));
        
        }while(answer=="Y");
        }
    }
}
