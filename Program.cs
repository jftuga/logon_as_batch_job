using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logon_as_batch_job
{
    class Program
    {
        const string PgmName = "logon_as_batch_job";
        const string PgmVersion = "1.0";
        const string PgmUrl = "https://github.com/jftuga/logon_as_batch_job";
        static void Usage()
        {
            Console.WriteLine("");
            Console.WriteLine("{0} v{1}", PgmName, PgmVersion);
            Console.WriteLine("{0}", PgmUrl);
            Console.WriteLine("");
            Console.WriteLine("Usage:");
            Console.WriteLine("{0}.exe DomainName\\UserName", PgmName);
            Console.WriteLine("");
            Console.WriteLine("This program must be run with the 'Run As Administrator' context.");
            Console.WriteLine("");
        }
        static void GrantUserLogonAsBatchJob(string userName)
        {
            try
            {
                LsaWrapper lsaUtility = new LsaWrapper();

                lsaUtility.SetRight(userName, "SeBatchLogonRight");

                //Console.WriteLine("Logon as batch job right is granted successfully to " + userName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                return;
            }
            string userName;
            userName = args[0];
            GrantUserLogonAsBatchJob(userName);
        }
    }
}
