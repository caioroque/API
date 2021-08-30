using System.Collections.Generic;
using System.Linq;
using API.Models;
using APIAula.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]   
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: /api/produto/create
        [Route("create")]
        [HttpPost]
        public Produto Create(Produto produto){

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        }
        //POST: /api/produto/list
        [Route("list")]
        [HttpGet]
        public List<Produto> list() => _context.Produtos.ToList();


        [Route("update")]
        [HttpPost]
        //POST: /api/produto/delete
        public Produto Update(Produto produto){
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return produto;
        }

        [Route("delete")]
        [HttpPost]
        //POST: /api/produto/delete
        public Produto Delete(Produto produto){
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return produto;
        }
    }
}
