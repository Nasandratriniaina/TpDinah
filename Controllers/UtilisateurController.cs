using AppDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDotNet.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Utilisateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjoutUtilisateur(Utilisateur utilisateur)
        {
            Utilisateur user= new Utilisateur(utilisateur.name,utilisateur.lastname,utilisateur.cin);
            DBConnection.AjoutUser(user);
            return Content("Ajout utlisateur réussi");
        }
    }
}