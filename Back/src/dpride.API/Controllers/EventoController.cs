﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dpride.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dpride.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{

            new Evento(){
            EventoId = 1,
            Tema = "Angular",
            Local = "BH",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            },

            new Evento(){
            EventoId = 3,
            Tema = "Angular",
            Local = "SP",
            QtdPessoas = 500,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "ex de post";
        }
    }
}

