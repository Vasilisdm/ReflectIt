using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    public class Container
    {
        public Container For<T>()
        {
            return this;
        }

        public object Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public void Use<T>()
        {
            throw new NotImplementedException();
        }
    }
}
