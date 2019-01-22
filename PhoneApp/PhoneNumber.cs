using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PhoneApp 
{
    class PhoneNumber : IFormatter
    {

        private int AreaCode { get; set; }
        private int ExchangePrefix { get; set; }
        private int Number { get; set; }
        private string FormattedPhoneNumber { get; set; }

        public void Format()
        {
            var SB = new StringBuilder();
            SB.Append("(");
            SB.Append(AreaCode);
            SB.Append(")-");
            SB.Append(ExchangePrefix);
            SB.Append("-");
            SB.Append(Number);
            FormattedPhoneNumber = SB.ToString();
        }

        public override string ToString()
        {
            if (FormattedPhoneNumber == null)
                Format();
            

            return FormattedPhoneNumber;
        }

        public PhoneNumber(string number)
        {
            if (number.Length != 10)
            {
                return;
            }
            else
            { 
            AreaCode = Convert.ToInt32(number.Substring(0, 3));
            ExchangePrefix = Convert.ToInt32(number.Substring(3, 3));
            Number = Convert.ToInt32(number.Substring(number.Length - 4));
            }
        }

        
    }
}
