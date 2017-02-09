using MerchantWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantWebAPI.BusinessServices.Interfaces
{
    public interface IMerchantService
    {
        Merchant GetMerchantDetailsById(int id);

        IEnumerable<Merchant> GetMerchantsDetailsByStatus(MerchantStatus status);

        IEnumerable<Merchant> GetAllMerchantDetails();

        void CreateMerchantDetails(Merchant merchant);

        void UpdateMerchantDetails(int id,Merchant updatedMerchant);

        void DeleteMerchantDetailsById(int Id);
    }
}
