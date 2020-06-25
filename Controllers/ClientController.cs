using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Data;
using TestMappingEfCore.Models;
using TestMappingEfCore.Repository;
using TestMappingEfCore.Repository.Impl;

namespace TestMappingEfCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        ClientRepository clientRepository;
        public ClientController(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Client> GetById(int key)
        {
            Client client = new Client();
            try
            {
                if (ModelState.IsValid)
                {
                    client = clientRepository.GetById(key).Result; ;
                    return client;

                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to get client. Try again, and if the problem persists see your system administrator.");
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult<Client> Create(Client client)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return clientRepository.Create(client).Result;

                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(client);
        }

        [HttpPut]
        public ActionResult<Client> Update(Client client)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return clientRepository.Update(client.key,client).Result;

                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(client);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Client> Delete(int key)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    return clientRepository.Delete(key).Result;

                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }           
        }
    }
}
