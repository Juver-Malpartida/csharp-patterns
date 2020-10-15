using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern
{
    public interface IProduct
    {
        string Operation();
    }

    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "Result from ConcreteProduct1";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "Result from ConcreteProduct2";
        }
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            string result = product.Operation();
            return result;
        }
    }

    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    class Client
    {
        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client calling... " + creator.SomeOperation());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.ClientCode(new ConcreteCreator1());

            client.ClientCode(new ConcreteCreator2());

            Console.ReadLine();
        }
    }
}
