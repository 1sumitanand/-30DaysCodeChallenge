using FactoryPattern.ConcreteProduct;

namespace FactoryPattern.ConcreteCreator
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Bibliography());
            Pages.Add(new Summary());
        }
    }
}
