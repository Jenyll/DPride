using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dpride.API.Data;
using dpride.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dpride.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this.context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return this.context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "ex de post";
        }
    }
}

