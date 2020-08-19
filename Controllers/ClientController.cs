using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TestMappingEfCore.Data;
using TestMappingEfCore.Models;
using TestMappingEfCore.Models.Converter;
using TestMappingEfCore.Models.DonneeDAO;
using TestMappingEfCore.Models.MetierDBO;
using TestMappingEfCore.Repository;
using TestMappingEfCore.Repository.Impl;
using TestMappingEfCore.Services;
using TestMappingEfCore.Services.Impl;

namespace TestMappingEfCore.Controllers
{
    /// <summary>
    /// Controller du client : gestion des routes, reception des requetes http et redirection vers le service concerné
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        IClientService clientService;
        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        //Pour les tests unitaires
        public static ClientController getClientController()
        {
            return new ClientController(ClientServiceImpl.getClientServiceImpl());
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<ClientDTO> GetById(int id)
        {
            ClientDTO clientDTO = new ClientDTO();
            try
            {
                if (ModelState.IsValid)
                {
                    return   clientService.GetById(id);
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to get client. Try again, and if the problem persists see your system administrator.");
            }
            return View(clientDTO);
        }

        [HttpPost]
        public ActionResult<ClientDTO> Create(ClientDTO client)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return clientService.Create(client);

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
        public ActionResult<ClientDTO> Update(ClientDTO client)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return clientService.Update(client);

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
        public ActionResult<ClientDTO> Delete(int id)
        {
            ClientDTO client = new ClientDTO();
            try
            {
                if (ModelState.IsValid)
                {
                    
                    return clientService.Delete(id);

                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(client);
        }
    }
}
