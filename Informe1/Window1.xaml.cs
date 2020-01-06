using System.Windows;

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

            ClientesCrystalReportsViewer.Owner = this;
            ClientesPaisCrystalReportsViewer.Owner = this;
            PedidosClientesCrystalReportsViewer.Owner = this;
            DistribucionSexoCrystalReportsViewer.Owner = this;
            PedidosEnviadosCrystalReportsViewer.Owner = this;

            CrystalReport1 informeClientes = new CrystalReport1();
            CrystalReport2 informeClientesPais = new CrystalReport2();
            CrystalReport3 informePedidosClientes = new CrystalReport3();
            CrystalReport4 informeDistribucionSexo = new CrystalReport4();
            CrystalReport5 informePedidosEnviados = new CrystalReport5();

            informeClientes.SetDatabaseLogon("administrador", "admin123.");
            informeClientesPais.SetDatabaseLogon("administrador", "admin123.");
            informePedidosClientes.SetDatabaseLogon("administrador", "admin123.");
            informeDistribucionSexo.SetDatabaseLogon("administrador", "admin123.");
            informePedidosEnviados.SetDatabaseLogon("administrador", "admin123.");

            ClientesCrystalReportsViewer.ViewerCore.ReportSource = informeClientes;
            ClientesPaisCrystalReportsViewer.ViewerCore.ReportSource = informeClientesPais;
            PedidosClientesCrystalReportsViewer.ViewerCore.ReportSource = informePedidosClientes;
            DistribucionSexoCrystalReportsViewer.ViewerCore.ReportSource = informeDistribucionSexo;
            PedidosEnviadosCrystalReportsViewer.ViewerCore.ReportSource = informePedidosEnviados;
        }
    }
}
