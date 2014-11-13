using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using Entities;
using Microsoft.Data.OData;
using Repos;

namespace Klientai.Controllers
{
   [ApiExplorerSettings(IgnoreApi = false)]
    public class KlientaiController : ODataController
    {


	    private IRepository<Klientas> repo;
 
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

	    public KlientaiController()
	    {
		    repo=new KlientaiRepo();
	    }

        // GET: odata/Klientai
        public IHttpActionResult GetKlientai(ODataQueryOptions<Klientas> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

	        var items = repo.ItemSet;
	        return Ok(items);
        }

        // GET: odata/Klientai(5)
        public IHttpActionResult GetKlientas([FromODataUri] int key, ODataQueryOptions<Klientas> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Klientas>(klientas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Klientai(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Klientas> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(klientas);

            // TODO: Save the patched entity.

            // return Updated(klientas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Klientai
        public IHttpActionResult Post(Klientas klientas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(klientas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Klientai(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Klientas> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(klientas);

            // TODO: Save the patched entity.

            // return Updated(klientas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Klientai(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
