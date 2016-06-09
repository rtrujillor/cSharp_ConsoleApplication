using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StringParser
    {
        private bool isInitialized; 

        public StringParser()
        {
            isInitialized = true;
        }

        public bool getIsInitialized()
        {
            return this.isInitialized;
        }

        public string Truncate(string value, int lenght)
        {
            return value?.Substring(0, Math.Min(value.Length, lenght));
        }

        public string AdjustWith(string value, int lenght)
        {
            return value?.Substring(0, Math.Min(value.Length, lenght)).PadRight(lenght);
        }

    }
}
