namespace MontaditosAMS.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.WindowsAzure.MobileServices;
    using dbo;

    public class MontaditosService : IMontaditosService
    {
        public async Task<List<Montaditos>> GetMontaditosAsync()
        {
            using (MobileServiceClient client = new MobileServiceClient("<AMSURL>", "<AMSKEY>"))
            {
                var result = await client.GetTable<Montaditos>().ToListAsync();

                return result;
            }
        }
    }
}
