using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.CLS
{
    class AppManager : ApplicationContext
    {
        public AppManager()
        {
            if (Splash())
            {
                GUI.Principal f = new GUI.Principal();
                f.ShowDialog();
            }
        }

        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return Resultado;
        }

    }
}
