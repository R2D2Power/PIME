using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PIME
{
    /// <summary>
    /// Lógica de interacción para PageMonitor.xaml
    /// </summary>
    public partial class PageMonitor : Page
    {
        public PageMonitor()
        {
            InitializeComponent();
            int vrmsAVal = 4345;
            

            VrmsAtxt.Text = Convert.ToString(vrmsAVal);
            VrmsBtxt.Text = Convert.ToString(vrmsAVal);
            VrmsCtxt.Text = Convert.ToString(vrmsAVal);
            VrmsABCtxt.Text = Convert.ToString(vrmsAVal);
            IrmsAtxt.Text = Convert.ToString(vrmsAVal);
            IrmsBtxt.Text = Convert.ToString(vrmsAVal);
            IrmsCtxt.Text = Convert.ToString(vrmsAVal);
            IrmsABCtxt.Text = Convert.ToString(vrmsAVal);
            PActiveAtxt.Text = Convert.ToString(vrmsAVal);
            PActiveBtxt.Text = Convert.ToString(vrmsAVal);
            PActiveCtxt.Text = Convert.ToString(vrmsAVal);
            PActiveABCtxt.Text = Convert.ToString(vrmsAVal);
            CosfiAtxt.Text = Convert.ToString(vrmsAVal);
            CosfiBtxt.Text = Convert.ToString(vrmsAVal);
            CosfiCtxt.Text = Convert.ToString(vrmsAVal);
            CosfiABCtxt.Text = Convert.ToString(vrmsAVal);


        }
    }
}
