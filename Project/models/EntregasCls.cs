using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Windows;

namespace StockFlow.Models
{
    public class EntregasCls
    {
        public string? SKU { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public int? Quantidade { get; set; }
        public double Preco { get; set; }
        public string? Status { get; set; }

        public static List<EntregasCls> CarregarDados(string path)
        {
            var lista = new List<EntregasCls>();

            try
            {
                Workbook workbook = new Workbook(path);
                Worksheet worksheet = workbook.Worksheets[0];
                Cells cells = worksheet.Cells;

                int maxLinha = cells.MaxDataRow;

                for (int i = 1; i <= maxLinha; i++)
                {
                    var c0 = cells[i, 0];
                    var c1 = cells[i, 1];
                    var c2 = cells[i, 2];
                    var c3 = cells[i, 3];
                    var c4 = cells[i, 4];
                    var c5 = cells[i, 5];
                    var c6 = cells[i, 6];

                    int valorConvertido = Convert.ToInt32(c3.Value);
                    double precoConvertido = Convert.ToDouble(c5.Value);

                    var item = new EntregasCls
                    {
                        SKU = c0.Value?.ToString(),
                        Nome = c1?.Value?.ToString() ?? "Não Foi entregue",
                        Categoria = c2.Value?.ToString(),
                        Quantidade = valorConvertido,
                        Preco = precoConvertido,
                        Status = "Em Estoque"
                    };

                    lista.Add(item);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string title = "ERRO";
                MessageBoxButton buttons = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;

                MessageBoxResult result = MessageBox.Show(message, title, buttons, icon);
            }

            return lista;
        }
    }
}