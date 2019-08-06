using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverterForm
{
    public interface IFileConverter
    {
        string InputFileFormat { get; }
        string OutputFileFormat { get; }
        object Convert(object input);
    }
}
