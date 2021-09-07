using System;
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
        public IActionResult Create([FromBody] Produto produto){

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }
        //POST: /api/produto/list
        [Route("list")]
        [HttpGet]
        public IActionResult list() => Ok(_context.Produtos.ToList());


        [Route("update")]
        [HttpPost]
        //POST: /api/produto/delete
        public IActionResult Update(Produto produto){
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok();
        }

        [Route("getbyid/{id}")]
        [HttpGet]
        //POST: /api/produto/getbyid
        public IActionResult GetById([FromRoute] int id){
            //buscar um objeto pela chave primaria
            Produto produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        //Deletar por Id
        /*
        [Route("delete")]
        [HttpPost]
        //POST: /api/produto/delete
        public Produto Delete(Produto produto){
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return produto;
        }*/

        [Route("delete/{name}")]
        [HttpDelete]
        //POST: /api/produto/delete
        public IActionResult Delete(string name){
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Nome == name);
            if (produto == null)
            {
                return NotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(_context.Produtos.ToList());
        }
    }
}
