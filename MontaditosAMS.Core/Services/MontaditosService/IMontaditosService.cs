namespace MontaditosAMS.Core.Services
{
    using dbo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   
    public interface IMontaditosService
    {
        Task<List<Montaditos>> GetMontaditosAsync();
    }
}
