﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sNumeroTarjeta, string sNumeroPIN)
        {
            double sSaldo;
            string numero;
            transaccion nuevaTransaccion = new transaccion(sNumeroTarjeta);
            if (sNumeroTarjeta == "123456" && sNumeroPIN == "654321")
            {
                numero = nuevaTransaccion.getNumTarjeta();
                sSaldo = nuevaTransaccion.getSaldo();
                return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
            }
            else
            {
                // Si el numero de pin o de tarjeta no corresponde, entonces se
                // procede a mostrar un mensaje de error
                ViewBag.Error = "Error en número de tarjeta o número de PIN. Verifique";
                return View();
            }
        }

    }
}