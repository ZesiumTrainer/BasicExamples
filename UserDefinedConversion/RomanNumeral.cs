using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExamples.UserDefinedConversion
{
    public class RomanNumeral
    {
        #region Fields
        private int value;
        #endregion Fields

        #region Constructors
        public RomanNumeral(int value)
        {
            this.value = value;
        }
        #endregion Constructors

        #region Conversion operators
        //Implicit conversion from int to RomanNumeral
        static public implicit operator RomanNumeral(int value)
        {
            return new RomanNumeral(value);
        }
        //Explicit conversion from RomanNumeral to int
        static public explicit operator int(RomanNumeral numeral)
        {
            return numeral.value;
        }
        //Explicit conversion from RomanNumeral to string
        static public explicit operator string(RomanNumeral numeral)
        {
            return "The RomanNumeral value is " + numeral.value.ToString();
        }
        #endregion Conversion operators

        #region Methods
        public override string ToString()
        {
            return value.ToString();
        }
        #endregion Methods
    }
}
