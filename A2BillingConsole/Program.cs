using A2BillingService;
using A2BillingService.Data;
using A2BillingService.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Timers;

namespace A2BillingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to A2Billing Console. Press any key to continue!");
                var c = Console.ReadKey().Key;
                var service = new CcSipBuddiesService();
                var cardService = new CcCardService();
                var sipAdditionalservice = new SipAdditionService();
                var sipA2Billingservice = new A2BillingSIPService();
                do
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("-- 1. List Sip Accounts in table                                    --");
                    Console.WriteLine("-- 2. Check md5secret of SIP Account                                --");
                    Console.WriteLine("-- 3. Generate md5secret from string                                --");
                    Console.WriteLine("-- 4. Generate and md5secret for SIP Account                        --");
                    Console.WriteLine("-- 5. Generate and md5secret for all SIP Accounts                   --");
                    Console.WriteLine("-- 6. Generate and md5password for Card                             --");
                    Console.WriteLine("-- 7. Generate and md5password for all Cards                        --");
                    Console.WriteLine("-- 8. Generate and md5secret in sip_additional.conf                 --");
                    Console.WriteLine("-- 9. Import transport TCP to SIP Account                           --");
                    Console.WriteLine("-- 10. Set timer to auto update md5secret and password card         --");
                    Console.WriteLine("-- 11. Exit                                                         --");
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.Write("Please choose your option: ");
                    var input = Console.ReadLine();
                    Console.WriteLine("");
                    try
                    {
                        int choice = Int32.Parse(input);
                        if(choice < 1 || choice > 11)
                        {
                            Console.WriteLine("Please select the correct option!");
                        }
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("-- List Sip Accounts in table                                       --");
                                var listAccount = service.ListCcSipBuddies();
                                foreach(var account in listAccount)
                                {
                                    Console.WriteLine(service.ToString(account));
                                }
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 2:
                                Console.WriteLine("-- Check md5secret of SIP Account                                   --");
                                Console.Write("Account Code : ");
                                var accountCheckInput = Console.ReadLine();
                                var checkResult = service.CheckMD5Secret(accountCheckInput.Trim());
                                Console.WriteLine(checkResult);
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 3:
                                Console.WriteLine("-- Generate md5secret from string                                   --");
                                Console.Write("String : ");
                                var stringGenerateInput = Console.ReadLine();
                                var generateStringResult = service.GenerateMD5FromString(stringGenerateInput.Trim());
                                Console.WriteLine("=> "+generateStringResult);
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 4:
                                Console.WriteLine("-- Generate and md5secret for SIP Account                           --");
                                Console.Write("Account Code : ");
                                var accountGenerateInput = Console.ReadLine();
                                var generateResult = service.GenerateMD5SecretForAccount(accountGenerateInput.Trim());
                                if (generateResult == null)
                                {
                                    Console.WriteLine("Not found! Account Code is not exist!");
                                    break;
                                }
                                Console.WriteLine(service.ToString(generateResult));
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 5:
                                Console.WriteLine("-- Generate and md5secret for all SIP Accounts                      --");
                                var allUserResult = service.GenerateMD5SecretForAllAccounts();
                                foreach (var account in allUserResult)
                                {
                                    Console.WriteLine(service.ToString(account));
                                }
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 6:
                                Console.WriteLine("-- Generate and md5password for Card                                --");
                                Console.Write("Account Code : ");
                                var accountCodeGeneratePassword = Console.ReadLine();
                                var generatePasswordResult = cardService.GenerateMD5PasswordForAccount(accountCodeGeneratePassword.Trim());
                                if (generatePasswordResult == null)
                                {
                                    Console.WriteLine("Not found! Account Code is not exist!");
                                    break;
                                }
                                Console.WriteLine(cardService.ToString(generatePasswordResult));
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 7:
                                Console.WriteLine("-- Generate and md5password for all Cards                           --");
                                var generatePasswordAllCard = cardService.GenerateMD5PasswordForAllAccounts();
                                foreach (var account in generatePasswordAllCard)
                                {
                                    Console.WriteLine(cardService.ToString(account));
                                }
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 8:
                                Console.WriteLine("-- Generate and md5secret in sip_additional.conf                    --");
                                var fileLine = sipAdditionalservice.ReadAndExec();
                                Console.WriteLine(fileLine);
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 9:
                                Console.WriteLine("-- Import transport TCP to SIP Account                              --");
                                var a2billingExec = sipA2Billingservice.ReadAndExec();
                                Console.WriteLine(a2billingExec);
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                            case 10:
                                Console.WriteLine("-- Set timer to auto update md5secret and password card             --");
                                var serviceRootConfig = new ServiceRootConfig();
                                var timeInterval = serviceRootConfig.TimerConfig().TimeLoop;
                                Console.WriteLine("Timer interval = " + timeInterval);
                                Timer timer = new Timer();
                                timer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
                                timer.Interval = timeInterval;
                                timer.Enabled = true;
                                if (Console.Read() == 'q') { timer.Dispose(); } ;
                                Console.WriteLine("----------------------------------------------------------------------");
                                break;
                        }
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Please select the correct option!");
                    }
                    Console.WriteLine("Press any key to continue. Press ESC to exit.");
                    c = Console.ReadKey().Key;
                    Console.Clear();
                } while (c != ConsoleKey.Escape);
                Console.WriteLine("_");
                Console.WriteLine("Thank you!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void OnTimerEvent(object source, ElapsedEventArgs e)
        {
            var service = new CcSipBuddiesService();
            Console.WriteLine("-- Generate and md5secret for all SIP Accounts                      --");
            var allUserResult = service.GenerateMD5SecretForAllAccounts();
            foreach (var account in allUserResult)
            {
                Console.WriteLine(service.ToString(account));
            }
            Console.WriteLine("-- Generate and md5password for all Cards                           --");
            var cardService = new CcCardService();
            var generatePasswordAllCard = cardService.GenerateMD5PasswordForAllAccounts();
            foreach (var account in generatePasswordAllCard)
            {
                Console.WriteLine(cardService.ToString(account));
            }
            Console.WriteLine("Press \'q\' to quit the sample.");
        }
    }
}
