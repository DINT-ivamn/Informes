using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Informe1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            /*
            ClientesCrystalReportsViewer.Owner = this;
            CrystalReport1 informeClientes = new CrystalReport1();
            informeClientes.SetDatabaseLogon("administrador", "admin123.");
            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informeClientes;
            ClientesPaisCrystalReportsViewer.Owner = this;
            CrystalReport2 informeClientesPais = new CrystalReport2();
            informeClientesPais.SetDatabaseLogon("administrador", "admin123.");
            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informeClientesPais;
            PedidosClientesCrystalReportsViewer.Owner = this;
            CrystalReport3 informePedidosClientes = new CrystalReport3();
            informePedidosClientes.SetDatabaseLogon("administrador", "admin123.");
            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informePedidosClientes;
            DistribucionSexoCrystalReportsViewer.Owner = this;
            CrystalReport4 informeDistribucionSexo = new CrystalReport4();
            informeDistribucionSexo.SetDatabaseLogon("administrador", "admin123.");
            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informeDistribucionSexo;
            */
            PedidosEnviadosCrystalReportsViewer.Owner = this;
            CrystalReport5 informePedidosEnviados = new CrystalReport5();
            informePedidosEnviados.SetDatabaseLogon("administrador", "admin123.");
            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informePedidosEnviados;
        }
    }
}
