﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.Repository;

namespace WebDeveloper.Areas.Personnel.Controllers
{
    public class PasswordController : PersonBaseController<Password>
    {
        public PasswordController(IRepository<Password> repository): base(repository)
        {
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}