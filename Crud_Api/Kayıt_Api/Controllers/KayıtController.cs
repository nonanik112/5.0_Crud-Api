using Kayıt_Business.Abstract;
using Kayıt_Business.Concrete;
using Kayıt_Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kayıt_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KayıtController : ControllerBase
    {
        private IKayıtService _kayıtService;

        public KayıtController(IKayıtService kayıtService)
        {
            _kayıtService = kayıtService;
        }

        /// <summary>
        /// Get All Kayit
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Kayıt> Get()
        {
            return _kayıtService.GetAllKayıt();
        }

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Kayıt Get(int id)
        {
            return _kayıtService.GetKayıtById(id);
        }

        /// <summary>
        /// Create an Kayit
        /// </summary>
        /// <param name="kayıt"></param>
        /// <returns></returns>
        [HttpPost]
        public Kayıt Post([FromBody]Kayıt kayıt)
        {
            return _kayıtService.CreateKayıt(kayıt);

        }

        /// <summary>
        /// Update the Kayit
        /// </summary>
        /// <param name="kayıt"></param>
        /// <returns></returns>
        [HttpPut]
        public Kayıt Put([FromBody]Kayıt kayıt)
        {
            return _kayıtService.UpdateKayıt(kayıt);

        }

        /// <summary>
        /// Delete the Kayit
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _kayıtService.DeleteKayıt(id);

        }
    }
}
