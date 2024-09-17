﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using SitioWebdeMG220764.Models;

namespace SitioWebdeMG220764.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Dropdown categorias
            categorias ct = new categorias();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;

            //Dropdown empresa

            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;

            //Dropdown localidad

            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;

            //Ofertas

            ViewBag.Ofertas = obj.CargarDatos();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string OpcionesCat, string OpcionesLoc, string OpcionesEmp)
        {
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);

            //Dropdown categorias

            categorias ct = new categorias();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;

            //Dropdown empresa

            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;

            //Dropdown localidad

            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;

            //Ofertas

            ViewBag.Ofertas = obj.CargarDatos(dcat, dloc, demp);
            return View();
        }
    }
}