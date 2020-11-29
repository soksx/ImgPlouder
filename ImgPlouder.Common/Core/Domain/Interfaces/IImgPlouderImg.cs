using System;
namespace ImgPlouder.Common.Core.Domain.Interfaces
{
    public interface IImgurImage
    {
        /// <summary>
        ///     OPTIONAL, the deletehash, if you're logged in as the image owner.
        /// </summary>
        string DeleteHash { get; set; }
        /// <summary>
        ///     The direct link to the the image. (Note: if fetching an animated GIF that was over 20MB in original size, a .gif
        ///     thumbnail will be returned)
        /// </summary>
        string Link { get; set; }
    }
}
