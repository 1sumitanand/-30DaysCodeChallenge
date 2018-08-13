using FactoryPattern.ConcreteProduct;

namespace FactoryPattern.ConcreteCreator
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Experience());
            Pages.Add(new Skills());
        }
    }
}
