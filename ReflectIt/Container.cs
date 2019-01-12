﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    public class Container
    {

        public ContainerBuilder For<TSource>()
        {
            return For(typeof(TSource));
        }


        public ContainerBuilder For(Type sourceType)
        {
            return new ContainerBuilder(this, sourceType);
        }


        public void Use<T1>()
        {
            throw new NotImplementedException();
        }


        public object Resolve<T1>()
        {
            throw new NotImplementedException();
        }


        public class ContainerBuilder
        {
            public ContainerBuilder(Container container, Type sourceType)
            {
                _container = container;
                _sourceType = sourceType;
            }

            Container _container;
            Type _sourceType;
        }

    }
}
