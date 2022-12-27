using System;
using System.Runtime.CompilerServices;

namespace Solid_Principle
{
    abstract class cloud
    {
        public abstract void MachineLearning();

       
    }

    interface ITranslatable
    {
        public void Translate();
    }

    class AWS : cloud, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Aws Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("AWS Translate");
        }
    }

    class Azure : cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");

        }


    }


    class Google : cloud, ITranslatable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Google Machine Learning");
        }

        public void Translate()
        {
            Console.WriteLine("Google Translate");
        }
    }


    internal class Program
    {
        //Liskov Substitution Principle, ortak bir referanstan türeyen nesnelerin
        //hiçbir şeyi bozulmadan, patlamadan. çatlamadan birbirleriyle değiştirilebilmesi gerektiğini
        //yani birbirlerinin yerine geçebilmesi gerektiğini öneren bir prensibtir.

        static void Main(string[] args)
        {
            cloud cloud = new AWS();
            cloud.MachineLearning();
            (cloud as ITranslatable)?.Translate();
            Console.WriteLine();

            cloud = new Google();
            cloud.MachineLearning();
            (cloud as ITranslatable)?.Translate();
            Console.WriteLine();

            cloud = new Azure();
            cloud.MachineLearning();
            (cloud as ITranslatable)?.Translate();



        }
    }
}
