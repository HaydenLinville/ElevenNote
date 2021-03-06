using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Services
{
    public class CategoryService
    {

        //adding for challenge
        public bool CreateCategory(CategoryCreate model)
        {
            var entity = new Category() { CategoryName = model.CategoryName };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Categories.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //added for challenge
        public IEnumerable<CategoryListItem> GetCategory()
        { //do I need the ownerId????
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Categories.Select(e => new CategoryListItem { CategoryId = e.CategoryId, CategoryName = e.CategoryName });
                return query.ToArray();
            }

        }



    }
}
