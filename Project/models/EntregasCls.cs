using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFlow.Models
{
    class EntregasCls
    {
        public int NumeroChamado { get; set; }
        public DateTime DataEntrega { get; set; }
        public string? NomeCliente { get; set; }
        public string? Equipamento { get; set; }
        public string? Cidade { get; set; }
        public string? Vendedor { get; set; }
        public string? Observacoes { get; set; }


        public string CarregarDados()
        {
            Workbook workbook = new Workbook("Dados.ods");
            var wks = workbook.Worksheets[0];

            int maxRow = wks.Cells.MaxDataRow;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= maxRow; i++)
            {
                var cellValue = wks.Cells[i, 0].Value;
                sb.AppendLine(cellValue?.ToString());
            }

            return sb.ToString();


        }


    }
}
