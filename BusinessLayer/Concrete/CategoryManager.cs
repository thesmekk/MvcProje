﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void CategoryDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void CategoryUpdate(Category p)
        {
            _categoryDal.Update(p);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


    }
}
