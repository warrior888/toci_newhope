namespace Halkidiki.Common.Interfaces
{
    public interface ICacheManager<TCacheEngine, TCacheEntity> where TCacheEntity : ICacheEntity
    {
        bool Store(TCacheEntity entity);

        TCacheEntity Get();

        TCacheEntity Refresh();
    }
}