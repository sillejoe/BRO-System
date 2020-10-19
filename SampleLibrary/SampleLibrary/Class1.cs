using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace SampleLibrary
{
    public class InputValidation
    {
        public bool DateValid(string DATE)
        {

            try
            {
                Convert.ToDateTime(DATE);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool Null(string textbox)
        {
            if (textbox == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LengthCheck1(string textbox, int length)
        {
            if (textbox.Length == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LengthCheck2(string textbox, int length)
        {
            if (textbox.Length <= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CharCheck(string textbox, string cont)
        {
            if (textbox.Contains(cont))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CharCheck2(string textbox, string cont)
        {
            if (textbox.StartsWith(cont))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}
