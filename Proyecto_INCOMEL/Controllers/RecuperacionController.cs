using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_INCOMEL.Controllers
{
    public class RecuperacionController : Controller
    {
        string urlDomain = "https://localhost:44329/";
        // GET: Recuperacion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Correo)
        {
            if (!string.IsNullOrEmpty(Correo))
            {
                SendEmail(Correo);
                ViewBag.Resultado = "Se envio un correo electronico a la dirección: " + Correo;
            }
            else
            {
                ViewBag.Resultado = "El campo es requerido";
            }
            
            return View();
        }

        public ActionResult Recovery (string contra) {
            if (!string.IsNullOrEmpty(contra))
            {
                ViewBag.Resultado = "Nueva contraseña asignada";
            }
            else
            {
                ViewBag.Resultado = "El campo es requerido";
            }

            return View();
        }

        private void SendEmail(string EmailDestino)
        {
            string EmailOrigen = "correoparadesarrollo12@gmail.com";
            string Contraseña = "Correoparadesarrollar123456";
            string url = urlDomain + "Recuperacion/Recovery";
            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, "Recuperación de contraseña",
                "<p>Correo para recuperación de contraseña</p><br>" +
                "<a href='" + url + "'>Click para recuperar</a>");

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            //oSmtpClient.Host = "smtp.gmail.com";
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();
        }
    }
}