using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DI
{

    public interface IFoo { }
    public interface IBar { }

    public class Foo : IFoo
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public  IBar _barService { get; set; }

        public Foo(IBar barService)
        {
            this._barService = barService;
        }

        public Foo(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Bar: IBar { }

    public class DIOverride
    {

        public void Override()
        {
            var container = new UnityContainer();
            var foo = container.Resolve<IFoo>(new ParameterOverride("id", 1));
            foo = container.Resolve<IFoo>(new ParameterOverrides{ { "id", 1 }, { "name", "billa"} });

            foo = container.Resolve<IFoo>(new DependencyOverride<IBar>(new Bar()));

            foo = container.Resolve<IFoo>(new PropertyOverride("_barService",new Bar()));
    }
}
}
