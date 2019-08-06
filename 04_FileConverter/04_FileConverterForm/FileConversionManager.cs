using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverterForm
{
    public class FileConversionManager : IFileConverter
    {
        private string m_outp;
        private string m_inp;

        public string InputFileFormat
        {
            get { return m_inp; }
        }

        public string OutputFileFormat
        {
            get { return m_outp; }
        }

        public object Convert(object input)
        {
            object obj = null;
            Convert(input, InputFileFormat, OutputFileFormat);
            return obj;
        }

        public static object Convert(object input, string iff, string off)
        {
            object obj = null;
            string changed = Path.ChangeExtension(input.ToString(), off);
            File.Copy(input.ToString(), changed);
            changed = "";

            return obj;
        }
    }
}
