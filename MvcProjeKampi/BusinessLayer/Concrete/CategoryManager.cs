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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;
      

        public CategoryManager(ICategoryDal cat)
        {
            _category = cat;
        }
        public void CategoryAdd(Category category)
        {
            _category.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _category.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _category.Update(category);
        }

        public Category GetByID(int id)
        {
            return _category.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _category.List();
        }

        public List<Category> GetList(string p)
        {
            throw new NotImplementedException();
        }
    }
}
