﻿using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {
        protected ContactRepository ContactRepository { get; private set; }

        public ContactController()
        {
            ContactRepository = new ContactRepository();
        }


        public Contact[] Get()
        {
            return ContactRepository.GetAllContacts();
        }
    }
}
