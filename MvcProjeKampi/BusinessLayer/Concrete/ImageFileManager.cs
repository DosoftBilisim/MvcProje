using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class ImageFileManager : IImageFileService
    {
        IImageFileDal _image;
        public ImageFileManager(IImageFileDal image)
        {
            _image = image;
        }
        public void ImageFileAdd(ImageFile image)
        {
            _image.Insert(image);
        }

        public void ImageFileDelete(ImageFile image)
        {
            _image.Delete(image);
        }

        public void ImageFileUpdate(ImageFile image)
        {
            _image.Update(image);
        }

        public ImageFile GetByID(int id)
        {
            return _image.Get(x => x.ImageID == id);
        }

        public List<ImageFile> GetList()
        {
            return _image.List();
        }

        public List<ImageFile> GetList(string p)
        {
            throw new NotImplementedException();
        }
    }
}
