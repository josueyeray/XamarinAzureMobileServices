using Cirrious.MvvmCross.ViewModels;
using dbo;
using MontaditosAMS.Core.Services;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MontaditosAMS.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMontaditosService montaditosService;
        private IList<Montaditos> montaditos;

        public FirstViewModel(IMontaditosService montaditosService)
        {
            this.montaditosService = montaditosService;

            Task.Run(async () =>
            {
                Montaditos = await this.montaditosService.GetMontaditosAsync();
            });
        }

        public IList<Montaditos> Montaditos
        {
            get { return this.montaditos; }
            set
            {
                this.montaditos = value;
                RaisePropertyChanged();
            }
        }
    }
}
