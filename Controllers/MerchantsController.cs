using MerchantWebAPI.BusinessServices;
using MerchantWebAPI.BusinessServices.Interfaces;
using MerchantWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MerchantWebAPI.Controllers
{
    public class MerchantsController : ApiController
    {
        private readonly IMerchantService _merchantService;
        // Constructor Injection
        public MerchantsController():this(new MerchantService())
        {

        }
        public MerchantsController(IMerchantService merchantService)
        {
            _merchantService = merchantService;
        }
        
        // Get All Merchants
        public IEnumerable<Merchant> Get()
        {
            return _merchantService.GetAllMerchantDetails();
        }

        // Get Merchant by Id
        public Merchant Get(int id)
        {
            return _merchantService.GetMerchantDetailsById(id);
        }

        // Get All Merchants by Status
        public IEnumerable<Merchant> Get(string status)
        {
            var merchantStatus = status == "active" ? MerchantStatus.active : MerchantStatus.Inactive;
            return _merchantService.GetMerchantsDetailsByStatus(merchantStatus);
        }

        // POST -- Create Merchant
        public void Post([FromBody]Merchant value)
        {
            _merchantService.CreateMerchantDetails(value);
        }

        // PUT -- Update Merchant
        public void Put(int id, [FromBody]Merchant merchant)
        {
            _merchantService.UpdateMerchantDetails(id, merchant);
        }

        // DELETE -- Delete Merchant
        public void Delete(int id)
        {
            _merchantService.DeleteMerchantDetailsById(id);
        }

    }
}
