using System;

namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepGoing = true;

            while(KeepGoing == true)
            {
                Console.WriteLine("please enter a number for the follwoing choices:");
                Console.WriteLine("0 to exit");
                Console.WriteLine("1 for Phone Number Formatting");
                Console.WriteLine("2 for SSN Formatting");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Input phone number:");
                        var PhoneNumber = Console.ReadLine();
                        if(PhoneNumber.Length != 10)
                        {
                            Console.WriteLine("Please enter a valid Phone number!");
                                break;
                        }
                        var phone = new PhoneNumber(PhoneNumber);
                        var formattedNumber = GetRecordType(phone);
                        Console.WriteLine($"the phone number formatted: {formattedNumber}");
                        break;

                    case 2:
                        Console.WriteLine("Input Social Security Number:");
                        var ssn = Console.ReadLine();
                        if (ssn.Length != 9)
                        {
                            Console.WriteLine("Please enter a valid SSN!");
                            break;
                        }
                        var ssnInput = new SocialSecurityNumber(ssn);
                        var formattedSsn = GetRecordType(ssnInput);
                        Console.WriteLine($"the phone number formatted: {formattedSsn}");
                        break;
                    case 0:
                        KeepGoing = false;
                        break;
                }
            }
        }

        private static string GetRecordType(IFormatter number)
        {
            number.Format();
            string returnNumber = number.ToString();
            return returnNumber;
        }

    }
}
