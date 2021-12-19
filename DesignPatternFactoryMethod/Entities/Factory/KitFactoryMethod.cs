using DesignPatternFactoryMethod.Entities.Enum;

namespace DesignPatternFactoryMethod.Entities.Factory
{
    //faz o papel do participante Creator
    public abstract class KitFactoryMethod
    {
        public abstract kitUpgrade CreateKitUpgrade(KitType kitType, string name);
    }
}
