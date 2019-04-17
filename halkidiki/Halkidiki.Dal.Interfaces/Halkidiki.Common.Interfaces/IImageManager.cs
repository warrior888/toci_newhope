namespace Halkidiki.Common.Interfaces
{
    public interface IImageManager<TImageSearchEngine, TImageEntity>
        where TImageEntity : IImageEntity<IImage>
    {
        TImageEntity GetImages(TImageEntity entity);
    }
}