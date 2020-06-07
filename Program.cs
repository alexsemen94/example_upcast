using System;

namespace UpCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Translate(new BaseTranslate());
            Translate(new RussianTranslate());
            Translate(new ItalianTranslate());


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            BaseCalculus calc1 = new Type1Calculus();

            Calculus(calc1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Calculus(new Type2Calculus());
        }

        static void Translate(BaseTranslate lang)
        {
            lang.Translate();
        }

        static void Calculus(BaseCalculus calculus)
        {
            calculus.Run();
        }
    }

    class BaseTranslate
    {
        public virtual void Translate()
        {
            Console.WriteLine("Hello!");
        }
    }

    class RussianTranslate: BaseTranslate
    {
        protected void TranslateWithCalculus()
        {
            var sum = 5 + 5;
            Console.WriteLine($"Привет, всем {sum}");
        }

        public override void Translate()
        {
            TranslateWithCalculus();
        }
    }

    class ItalianTranslate: BaseTranslate
    {
        public override void Translate()
        {
            Console.WriteLine("Buongiorno");
        }
    }


    #region Abstract
    public abstract class BaseCalculus
    {
        protected void Start()
        {
            Console.WriteLine("Start");
        }

        protected abstract void Do();

        protected void End()
        {
            Console.WriteLine("End");
        }

        public void Run()
        {
            Start();
            Do();
            End();
        }
    }

    public class Type1Calculus : BaseCalculus
    {
        protected override void Do()
        {
            Console.WriteLine($"Calculus: {5 + 5}");
        }
    }

    public class Type2Calculus : BaseCalculus
    {
        protected override void Do()
        {
            Console.WriteLine($"Calculus: {5 * 5}");
        }
    }

    #endregion

}
