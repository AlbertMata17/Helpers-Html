using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Helpers.Models;

namespace Helpers.Controllers
{
    public class DatosController : Controller
    {
        // GET: Datos
        public ActionResult Formulario()
        {
            Datos lista = new Datos();

            List<Checkbox> listado = new List<Checkbox>();
            listado.Add(new Checkbox() { IdHobby = 1, NombreHobby = "Nadar", seleccionado = false });
            listado.Add(new Checkbox() { IdHobby = 2, NombreHobby = "Leer", seleccionado = false });
            listado.Add(new Checkbox() { IdHobby = 3, NombreHobby = "Escuchar Musica", seleccionado = false });
            listado.Add(new Checkbox() { IdHobby = 4, NombreHobby = "Correr en el parque", seleccionado = false });
            lista.Hobbys = listado;
            
            return View(lista);
        }
        [HttpPost]
        public ActionResult Formulario(Datos usuario)
        {
            


            if (ModelState.IsValid) {
                StringBuilder sb = new StringBuilder();
                foreach (var item in usuario.Hobbys)
                {
                    if (item.seleccionado)
                    {
                        sb.Append(item.NombreHobby + ",");
                    }
                }
                TempData["hobbys"] =sb;
                return RedirectToAction("Usuario", usuario);

            }
            else
            {
                return View(usuario);
            }
        }
        public ActionResult Usuario(Datos user)
        {
            if (TempData["hobbys"]!=null)
            {
                ViewBag.mensaje = TempData["hobbys"].ToString();
            }

           
            return View(user);
        }
       
    }
}