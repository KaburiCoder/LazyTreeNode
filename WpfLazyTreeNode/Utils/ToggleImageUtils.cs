using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfLazyTreeNode.Utils
{
  public static class ToggleImageUtils
  {   
    static BitmapImage GetBitmapImageByFileName(string fileName)
    {
      return new BitmapImage(new Uri($"./../Images/{fileName}", UriKind.Relative));
    }

    public static (BitmapImage? opendedImage, BitmapImage? closedImage) GetExplorers(ExplorerType explorerType)
    {
      BitmapImage? opendedImage = null;
      BitmapImage? closedImage = null;

      switch (explorerType)
      {
        case ExplorerType.Drive:
          opendedImage = GetBitmapImageByFileName("opened-drive.png");
          closedImage = GetBitmapImageByFileName("closed-drive.png");
          break;
        case ExplorerType.Directory:
          opendedImage = GetBitmapImageByFileName("opened-folder.png");
          closedImage = GetBitmapImageByFileName("closed-folder.png");
          break;
        case ExplorerType.File:
          opendedImage = null;
          closedImage = GetBitmapImageByFileName("file.png");
          break;
      }

      return (opendedImage, closedImage);
    }
  }  

  public enum ExplorerType
  {
    Drive, Directory, File
  }
}
