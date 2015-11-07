using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using B2BSolution.Financeiro.Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace B2BSolution.Financeiro.Negocio
{
    public class Arquivo
    {
        public void GerarPdf(List<Pagamento> listaPagamento)
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"c:\temp\teste.pdf", FileMode.Create));
            doc.Open();

            var pagamento = listaPagamento.First();

            var corpoEmail = CorpoEmail();
            corpoEmail = corpoEmail.Replace("[mes]", pagamento.DataPagamento.ToString("Y"));
            corpoEmail = corpoEmail.Replace("[canal]", pagamento.Contrato.Vendedor.Nome);
            corpoEmail = corpoEmail.Replace("[body]", BodyTabelaComissao(listaPagamento));
            corpoEmail = corpoEmail.Replace("[foot]", FooterTabelaComissao(listaPagamento));

            var hw = new iTextSharp.text.html.simpleparser.HTMLWorker(doc);
            hw.Parse(new StringReader(corpoEmail));

            doc.Close();

            //return corpoEmail;
        }

        private string CorpoEmail()
        {
            var htmlText = new StringBuilder()
                 .AppendLine("<html>")
                 .AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8' />")
                 .AppendLine("<head style='font-size: 8px;'>")
                 .AppendLine("</head>")
                 .AppendLine("<body style='font-size: 8px;'>")
                 .AppendLine("<div>")
                 .AppendLine("<div >")
                 .AppendLine(@"<img src='C:\Danilo\Projetos\GerarPDF\GerarPDF\Ass email.jpg' height='50px' width='50px' />")
                 .AppendLine("</div>")
                 .AppendLine("<div>")
                 .AppendLine("<p>")
                 .AppendLine("<b>")
                 .AppendLine("B2B TECHNOLOGY SERVIÇOS DE TELECOMUNICAÇÕES LTDA-ME<br/>")
                 .AppendLine("CNPJ: 07.848.254/0001-03<br/>")
                 .AppendLine("RUA BARRETOS, 133 – BAETA NEVES – 09751-450 – SÃO BERNARDO DO CAMPO<br/>")
                 .AppendLine("E-mail: financeiro@b2btechnology.com.br<br/>")
                 .AppendLine("</b>")
                 .AppendLine("</p>")
                 .AppendLine("</div>")
                 .AppendLine("<br />")
                 .AppendLine("<br />")
                 .AppendLine("<div style='border-top: 3px solid #000;'>")
                 .AppendLine("COMISSÃO REFERENTE À ARRECADAÇÃO DE: [mes]")
                 .AppendLine("</div>")
                 .AppendLine("<div style='border-top: 3px solid #000;'>")
                 .AppendLine("CANAL: [canal]")
                 .AppendLine("</div>")
                 .AppendLine("<div style='border-top: 3px solid #000;'>")
                 .AppendLine("</div>")
                 .AppendLine("<br/>")
                 .AppendLine("<br/>")
                 .AppendLine("<br/>")
                 .AppendLine("<table border='1'>")
                 .AppendLine("<thead>")
                 .AppendLine("<tr>")
                 .AppendLine("<th style='width: 200px;'>")
                 .AppendLine("Empresa")
                 .AppendLine("</th>")
                 .AppendLine("<th style='width: 200px;'>")
                 .AppendLine("Faturamento Bruto")
                 .AppendLine("</th>")
                 .AppendLine("<th style='width: 200px;'>")
                 .AppendLine("Faturamento Líquido")
                 .AppendLine("</th>")
                 .AppendLine("<th style='width: 200px;'>")
                 .AppendLine("Comissão a pagar")
                 .AppendLine("</th>")
                 .AppendLine("</tr>")
                 .AppendLine("</thead>")
                 .AppendLine("<tbody>")
                 .AppendLine("[body]")
                 .AppendLine("</tbody>")
                 .AppendLine("<tfoot>")
                 .AppendLine("[foot]")
                 .AppendLine("</tfoot>")
                 .AppendLine("</table>")
                 .AppendLine("<br/>")
                 .AppendLine("Salientamos que neste momento não há necessidade de emissão de nota fiscal.")
                 .AppendLine("</div>")
                 .AppendLine("</body>")
                 .AppendLine("</html>");
            
            return htmlText.ToString();
        }

        private static string BodyTabelaComissao(List<Pagamento> listaPagamento)
        {
            var tbody = new StringBuilder();
            listaPagamento.ForEach(p =>
            tbody.AppendFormat("	<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                ,p.Contrato.Cliente.Nome
                ,p.ValorPago
                ,p.ValorPago - ((p.ValorPago * p.Contrato.Vendedor.Comissao) / 100)
                ,(p.ValorPago * p.Contrato.Vendedor.Comissao) / 100)
                );

            return tbody.ToString();
        }

        private static string FooterTabelaComissao(List<Pagamento> listaPagamento)
        {
            return string.Format("<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                , "Total: "
                , listaPagamento.Sum(p => p.ValorPago)
                , listaPagamento.Sum(p => p.ValorPago - ((p.ValorPago*p.Contrato.Vendedor.Comissao)/100))
                , listaPagamento.Sum(p => ((p.ValorPago * p.Contrato.Vendedor.Comissao) / 100)));
        }
    }
}
