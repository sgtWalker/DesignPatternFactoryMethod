using DesignPatternFactoryMethod.Entities.Enum;

namespace DesignPatternFactoryMethod.Entities.Factory
{
    //faz o papel do participante Concrete Creator
    public class KitFactory : KitFactoryMethod
    {
        public override kitUpgrade CreateKitUpgrade(KitType kitType, string name)
        {
            switch (kitType)
            {
                case KitType.AMD:
                    return new KitAmd(kitType, name);
                case KitType.INTEL:
                    return new KitIntel(kitType, name);
                default:
                    return null;
            }
        }
    }
}
