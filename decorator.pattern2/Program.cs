using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator.pattern2
{
    interface IComponent
    {
        string Process();
    }

    class Client
    {
        public void Execute(IComponent component)
        {
            Console.WriteLine(component.Process());
        }
    }

    class ConcreteComponent : IComponent
    {
        public string Process()
        {
            return "Concrete component";
        }
    }

    abstract class DecoratorComponentBase : IComponent
    {
        private IComponent component;
        public DecoratorComponentBase(IComponent component)
        {
            this.component = component;
        }

        public virtual string Process()
        {
            return component.Process();
        }
    }

    internal class DecoratorComponentA : DecoratorComponentBase
    {
        public DecoratorComponentA(IComponent component) : base(component)
        {

        }

        public override string Process()
        {
            return base.Process() + " Component A";
        }
    }

    internal class DecoratorComponentB : DecoratorComponentBase
    {
        public DecoratorComponentB(IComponent component) : base(component)
        {

        }

        public override string Process()
        {
            return base.Process() + " Component B";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            IComponent concreteComponent = new ConcreteComponent();
            concreteComponent = new DecoratorComponentA(concreteComponent);
            concreteComponent = new DecoratorComponentB(concreteComponent);

            client.Execute(concreteComponent);

            Console.ReadLine();
        }
    }
}
