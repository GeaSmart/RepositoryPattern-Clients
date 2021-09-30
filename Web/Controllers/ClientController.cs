using AutoMapper;
using DAL.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientService service;
        private readonly IMapper mapper;

        public ClientController(IClientService service,IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(Get());
        }
                
        [Route("Get")]
        public IEnumerable<IClientModel> Get()
        {
            return service.GetAllAsync().Result;
        }

        [HttpGet("AddEdit")]
        [Route("AddEdit/{id:int}")]
        public async Task<IActionResult> AddEdit(int id = 0)
        {
            var cliente = service.GetAsync(id).Result;
            return View(cliente);
        }

        [HttpPost("AddEdit")]
        public async Task<IActionResult> AddEdit([FromForm] ClientModel client)
        {
            if (ModelState.IsValid)
            {
                IClientModel cliente = new ClientModel();
                if (client.Id == 0)
                    cliente = await service.CreateClientAsync(mapper.Map<IClientModel>(client));

                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }
    }
}
