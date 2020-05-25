using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterGeneratorLibrary
{
    using System;

    [Serializable]
    public class GeneratorException : Exception //Собственный класс исключений, наследник Exception
    {
        public GeneratorException() { }
        public GeneratorException(string message) : base(message) { }
        public GeneratorException(string message, Exception inner) : base(message, inner) { }
        protected GeneratorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
