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
    public class ContentManager : IContentService
    {
        IContentDal _content;
        public ContentManager(IContentDal con)
        {
            _content = con;
        }
        public void ContentAdd(Content content)
        {
            _content.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            _content.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _content.Update(content);
        }

        public Content GetByID(int id)
        {
            return _content.Get(x => x.ContentID == id);
        }

        public List<Content> GetList()
        {
            return _content.List();
        }

        public List<Content> GetList(string p)
        {
            return _content.List(x=>x.ContentValue.Contains(p));
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _content.List(x => x.HeadingID == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _content.List(x => x.WriterID == id);
        }
    }
}
