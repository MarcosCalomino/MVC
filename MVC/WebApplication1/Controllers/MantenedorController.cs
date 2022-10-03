using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Datos;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //LA VISTA MOSTRARÄ UNA LISTA DE CONTACTOS
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA VISTA
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _ContactoDatos.Guardar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
                else            
                return View();
        }

        public IActionResult Editar(int IdContacto)
        {
           
            var oContacto = _ContactoDatos.Obtener(IdContacto);
            return View(oContacto);
        }
        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            var rta = _ContactoDatos.Editar(oContacto);

            if(rta)
            return RedirectToAction("Listar");
            else
            return View(oContacto);
        }

        public IActionResult Eliminar(int IdContacto)
        {

            var oContacto = _ContactoDatos.Obtener(IdContacto);
            return View(oContacto);
        }
        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            var rta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (rta)
                return RedirectToAction("Listar");
            else
                return View(oContacto);
        }
    }
}
