using ElevenNote.Models;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {

        public IHttpActionResult Get()
        {
            CategoryService categoryService = new CategoryService();
            var category = categoryService.GetCategory();
            return Ok(category);
        }


        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new CategoryService();

            if (!service.CreateCategory(category))
                return InternalServerError();

            return Ok();

        }



    }
}
