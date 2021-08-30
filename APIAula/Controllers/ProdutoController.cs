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

        [Route("create")]
        [HttpPost]
        public Produto Create(Produto produto){

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        [Route("list")]
        [HttpGet]
        public List<Produto> list() => _context.Produtos.ToList();
    }
}