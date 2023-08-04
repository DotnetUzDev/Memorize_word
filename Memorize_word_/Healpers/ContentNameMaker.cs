using System;
using System.IO;

namespace Memorize_word_.Healpers;

public class ContentNameMaker
{
    public static string GetImageName(string imageName)
    {
        FileInfo fileInfo = new FileInfo(imageName);
        return "IMG_"+Guid.NewGuid().ToString()+fileInfo.Extension;
    }
}
