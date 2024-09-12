﻿using Crud.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Repositorio
{
    internal class TimeRepository
    {
        public SimuladorBD bd { get; set; }

        public TimeRepository(SimuladorBD bdPreenchido) 
        {
            bd = bdPreenchido;
        }
        public void Adicionar(Time time) {
            
            bd.Times.Add(time);
        }
        public void Remover(Time time) 
        {
        bd.Times.Remove(time);
        }
        public void Editar() 
        { 
        
        }
        public List<Time> Listar() 
        {
        return bd.Times.ToList();
        }

    }
}
