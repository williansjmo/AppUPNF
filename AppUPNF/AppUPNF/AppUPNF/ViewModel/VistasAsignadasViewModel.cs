using AppUPNF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppUPNF.ViewModel
{
    public class VistasAsignadasViewModel : BaseViewModel
    {
        public VistasAsignadasViewModel()
        {
            GetvistasAsignadaskAsync();
        }

        ObservableCollection<VistasAsignadas> vistasAsignadas;
        public ObservableCollection<VistasAsignadas> VistasAsignadas
        {
            get => vistasAsignadas;
            set => SetValue(ref vistasAsignadas, value);
        }

        void GetvistasAsignadaskAsync()
        {
            vistasAsignadas.Add(
                new VistasAsignadas
                {
                    NIdentificacion = 87651790,
                    TipoIdentificacion = "C.C",
                    NSolicitud = 87665475,
                    Solicitante = "Freddy Hernandez",
                    Estado = "En Analisis"
                });

        }
    }
}
