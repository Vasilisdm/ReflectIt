using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    public class Container
    {

        public Container For<TSource>()
        {
            return For(typeof(TSource));
        }


        public Container For(Type sourceType)
        {
            return this;
        }


        public void Use<T1>()
        {
            throw new NotImplementedException();
        }


        public object Resolve<T1>()
        {
            throw new NotImplementedException();
        }

    }
}
