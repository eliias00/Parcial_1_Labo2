using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AgregoProdError : Exception
    { /// <summary>
      /// Usa el constructor base para mostrar un mensaje de error 
      /// </summary>
      /// <param name="innerExcepction"></param>
        public AgregoProdError(Exception innerExcepction) : base("Error en carga de producto: ", innerExcepction)
        {
        }
    }
}
