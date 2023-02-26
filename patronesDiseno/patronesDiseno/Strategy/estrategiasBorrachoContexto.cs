using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Strategy
{
    internal class estrategiasBorrachoContexto
    {
        private IBorracho oBorracho;

        public estrategiasBorrachoContexto()
        {
            //Por defecto
            this.oBorracho = new EstrategiaOjitos();
        }

        public void establecerConquistaOjitos()
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistaCerveza()
        {
            this.oBorracho = new invitarCervaza();
        }

        public void conquistar()
        {
            this.oBorracho.conquistar();
        }
    }
}
