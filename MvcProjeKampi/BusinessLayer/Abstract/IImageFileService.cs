using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IImageFileService
    {
        List<ImageFile> GetList();
        List<ImageFile> GetList(string p);
        void ImageFileAdd(ImageFile ımageFile);
        ImageFile GetByID(int id);
        void ImageFileDelete(ImageFile ımageFile);
        void ImageFileUpdate(ImageFile ımageFile);
    }
}
