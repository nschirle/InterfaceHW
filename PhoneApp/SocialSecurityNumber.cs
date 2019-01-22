using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneApp
{
    class SocialSecurityNumber : IFormatter
    {
        private int GroupOne { get; set; }
        private int GroupTwo { get; set; }
        private int GroupThree { get; set; }
        private string FormattedSsn { get; set; }
        public void Format()
        {
            var SB = new StringBuilder();
            SB.Append(GroupOne);
            SB.Append("-");
            SB.Append(GroupTwo);
            SB.Append("-");
            SB.Append(GroupThree);
            FormattedSsn = SB.ToString();
        }

        public override string ToString()
        {
            if (FormattedSsn == null)
                Format();


            return FormattedSsn;
        }


        public SocialSecurityNumber(string ssn)
        {
            if (ssn.Length != 9)
            {
                return;
            }
            else
            {
                GroupOne = Convert.ToInt32(ssn.Substring(0, 3));
                GroupTwo = Convert.ToInt32(ssn.Substring(3, 2));
                GroupThree = Convert.ToInt32(ssn.Substring(ssn.Length - 4));
            }
        }
    }
}
