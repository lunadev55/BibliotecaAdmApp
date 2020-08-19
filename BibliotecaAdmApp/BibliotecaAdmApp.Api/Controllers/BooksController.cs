using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BibliotecaAdmApp.Application.Books.Commands;
using BibliotecaAdmApp.Application.Books.Dto;
using BibliotecaAdmApp.Application.Books.Queries;
using System.ComponentModel;

namespace BibliotecaAdmApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ApiController
    {

        [HttpGet("create")]
        public IActionResult Create()
        {
            var status = Enum.GetValues(typeof(BibliotecaAdmApp.Core.Enums.BookStatus))
                                                    .Cast<BibliotecaAdmApp.Core.Enums.BookStatus>()
                                                    .ToList();

            SelectList statusList = new SelectList(status.OrderBy(x => x.ToString()));

            for (int i = 0; i < statusList.Count(); i++)
            {
                statusList.ElementAt(i).Value = statusList.ElementAt(i).Text;
            }

            ViewBag.Status = statusList;

            return View();

        }

        [HttpPost("post")]
        //public IActionResult CreatePost([FromForm] BibliotecaAdmApp.Application.Books.Dto.BookDto bookDto)
        public async Task<ActionResult<int>> CreatePost(CreateBookCmd cmd)
        {
            //return RedirectToAction(nameof(FindAll));
            return await Mediator.Send(cmd);
        }

 

        [HttpGet]
        public async Task<ActionResult<List<BookDto>>> FindAll()
        {
            return View(await Mediator.Send(new FindAllBooksQuery()));
            //return await Mediator.Send(new FindAllBooksQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<BookDto>> Get(int id)
        {
            return await Mediator.Send(new FindBookByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateBookCmd cmd)
        {
            return await Mediator.Send(cmd);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteBookCmd { Id = id });
        }
    }
}
