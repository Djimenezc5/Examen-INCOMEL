using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_INCOMEL.Controllers
{
    public class PalindromoController : Controller
    {
        List<string> listaPalindormos = new List<string>();

        [Authorize]
        // GET: Palindromo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string palabra) 
        {
            if (string.IsNullOrEmpty(palabra))
            {
                ViewBag.Respuesta = "Debe ingresar un texto para validar";
            }
            else
            {
                string cadena = palabra.ToLower();
                string[] arr = cadena.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    int tam = arr.Length;
                    if (tam > 1)
                    {
                        if (PalindromaCadena(Convert.ToString(arr[i])))
                        {
                            listaPalindormos.Add(Convert.ToString(arr[i]));
                        }
                    }
                    else
                    {
                        if (Palindroma(Convert.ToString(arr[i])))
                        {
                            continue;
                        }
                    }
                }
                ViewBag.Resultado = listaPalindormos;
            }
            return View();
        }

        private Boolean PalindromaCadena(String cadena)
        {
            if (cadena.Length < 2) return true;
            if (cadena[0] == cadena[cadena.Length - 1]) return PalindromaCadena(cadena.Substring(1, cadena.Length - 2));
            return false;
        }

        private Boolean Palindroma(String cadena)
        {
            listaPalindormos.Add(cadena);
            if (cadena.Length < 2) return true;
            if (cadena[0] == cadena[cadena.Length - 1]) return Palindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
    }
}