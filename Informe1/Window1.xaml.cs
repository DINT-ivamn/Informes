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
            Informe1Viewer.Owner = this;
            Informe2Viewer.Owner = this;
            Informe3Viewer.Owner = this;
            Informe4Viewer.Owner = this;
            Informe5Viewer.Owner = this;

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

            Informe1Viewer.ViewerCore.ReportSource = informeClientes;
            Informe2Viewer.ViewerCore.ReportSource = informeClientesPais;
            Informe3Viewer.ViewerCore.ReportSource = informePedidosClientes;
            Informe4Viewer.ViewerCore.ReportSource = informeDistribucionSexo;
            Informe5Viewer.ViewerCore.ReportSource = informePedidosEnviados;   
        }
    }
}
