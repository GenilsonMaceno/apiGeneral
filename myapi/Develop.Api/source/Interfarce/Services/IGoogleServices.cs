using source.Models.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace source.Interfarce.Services
{
    public interface IGoogleServices
    {
        Task<Google> GetURIAthorize();
    }
}