using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_EVDOKIMOV
{
    // NewUser("Ivanov", "123", "Ivan", 86981234020);

    class Program
    {
        static void Main(string[] args)
        {

            InServer("123", 86981234020);
            Console.ReadLine();
        }



        private static void NewUser( string name , string pas , string sur , UInt64 phon) 
        {
            ApIServercs apI = new ApIServercs();

            try
            {
                Console.WriteLine(apI.Registr(new Model.RegistrRequest_
                {
                    first_name = name,
                    password = pas,
                    phone = phon,
                    surname = sur
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void InServer(string pas, UInt64 phon)
        {
            ApIServercs apI = new ApIServercs();

            try
            {
                Console.WriteLine(apI.InApi(new Model.InApiRequist
                {
                    password = pas,
                    phone = phon,
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
