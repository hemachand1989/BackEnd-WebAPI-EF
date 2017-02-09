using MerchantWebAPI.BusinessServices.Interfaces;
using MerchantWebAPI.DAL;
using MerchantWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerchantWebAPI.BusinessServices
{
    public class MerchantService : IMerchantService
    {
        private readonly MerchantContext merchantContext;
        public MerchantService()
        {
            merchantContext = new MerchantContext();
        }
        public Merchant GetMerchantDetailsById(int id)
        {
            return merchantContext.Merchants.Where(x => x.merchant_id == id).SingleOrDefault();
        }

        public IEnumerable<Merchant> GetMerchantsDetailsByStatus(MerchantStatus status)
        {
            return merchantContext.Merchants.Where(x => x.status == status).ToList();
        }

        public IEnumerable<Merchant> GetAllMerchantDetails()
        {
            return merchantContext.Merchants.ToList();
        }

        public void CreateMerchantDetails(Merchant merchant)
        {
            merchantContext.Merchants.Add(merchant);
            merchantContext.SaveChanges();
        }

        public void UpdateMerchantDetails(int id,Merchant updatedMerchant)
        {
            var merchant = merchantContext.Merchants.Where(x => x.merchant_id == id).SingleOrDefault();
            if (merchant != null)
            {
                merchantContext.Entry(merchant).CurrentValues.SetValues(updatedMerchant);
                merchantContext.SaveChanges();
            }
        }

        public void DeleteMerchantDetailsById(int Id)
        {
            var merchant = merchantContext.Merchants.Where(x => x.merchant_id == Id).SingleOrDefault();
            if (merchant != null)
            {
                merchantContext.Merchants.Remove(merchant);
                merchantContext.SaveChanges();
            }
        }
    }
}