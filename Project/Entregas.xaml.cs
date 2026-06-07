using StockFlow.Models;
using System;
using System.Collections.Generic;
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

namespace StockFlow
{
    /// <summary>
    /// Interação lógica para Entregas.xam
    /// </summary>
    public partial class Entregas : Page
    {
        public Entregas()
        {
            InitializeComponent();
            EntregasCls entregasCls = new EntregasCls();

            TextRange rctb = new TextRange(rtbdados.Document.ContentStart, rtbdados.Document.ContentEnd);

            rctb.Text = entregasCls.CarregarDados();
        }
    }
}
