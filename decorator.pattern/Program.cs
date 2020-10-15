using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator.pattern
{
    public interface IComponent
    {
        string Process();
    }

    public class ConcreteComponent : IComponent
    {
        public string Process()
        {
            return "Concrete Component Process...";
        }
    }

    public class Client
    {
        public void Operation(IComponent component)
        {
            Console.WriteLine(component.Process());
        }
    }

    public abstract class ComponentDecoratorBase : IComponent
    {
        private IComponent innerComponent;

        protected ComponentDecoratorBase(IComponent innerComponent)
        {
            this.innerComponent = innerComponent;
        }

        public virtual string Process()
        {
            return this.innerComponent != null ? this.innerComponent.Process() : string.Empty;
        }
    }

    public class DecoratorA : ComponentDecoratorBase
    {
        public DecoratorA(IComponent innerComponent) : base(innerComponent)
        {
        }

        public override string Process()
        {
            return $"Decorator A... {base.Process()}";
        }
    }

    public class DecoratorB : ComponentDecoratorBase
    {
        public DecoratorB(IComponent innerComponent) : base(innerComponent)
        {
        }

        public override string Process()
        {
            return "Decorator B.... " + base.Process();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            IComponent component = new ConcreteComponent();

            //client.Operation(component);

            component = new DecoratorB(new DecoratorA(component));
            client.Operation(component);

            Console.ReadLine();
        }
    }
}
