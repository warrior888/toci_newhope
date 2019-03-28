using System.Collections.Generic;

namespace Halkidiki.Common.Interfaces
{
    public interface IImageEntity<TImage>
        where TImage : IImage
    {
        string ImageDescription { get; set; }

        List<TImage> Iamges { get; set; }
    }
}