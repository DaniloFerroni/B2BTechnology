using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace B2BSolution.Financeiro.Formulario.Util
{
    public class Arquivo
    {
        public void GerarPdf<T>(List<T> listaPagamento, string nomeVendedor, DateTime dataMesPagamento, TipoPdf tipoPdf)
        {
            var pagamento = listaPagamento.FirstOrDefault();
            if (pagamento == null) return;

            const string caminho = @"C:\B2B Tecnology PDF";
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);

            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(string.Format(@"{0}\{1}_{2}.pdf", caminho, nomeVendedor, dataMesPagamento.ToString("MMyyyy")), FileMode.Create));
            doc.Open();

            var corpoEmail = CorpoEmail();
            var data = dataMesPagamento.ToString("Y");
            corpoEmail = corpoEmail.Replace("[InformacaoBody]", TipoPdf.Comissao == tipoPdf ?
                                                        InformacaoBodyComissao() :
                                                        InformacaoBodyPagamento());
            corpoEmail = corpoEmail.Replace("[mes]", data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1));
            corpoEmail = corpoEmail.Replace("[tabela]", TipoPdf.Comissao == tipoPdf ? TabelaComissao() : TabelaPagamento());
            corpoEmail = corpoEmail.Replace("[canal]", nomeVendedor);
            corpoEmail = corpoEmail.Replace("[body]", TipoPdf.Comissao == tipoPdf ? 
                                                        BodyTabelaComissao(listaPagamento.Cast<DadosComissao>().ToList()) :
                                                        BodyTabelaPagamento(listaPagamento.Cast<Pagamento>().ToList()));
            corpoEmail = corpoEmail.Replace("[foot]", TipoPdf.Comissao == tipoPdf ? 
                                                        FooterTabelaComissao(listaPagamento.Cast<DadosComissao>().ToList()) : 
                                                        FooterTabelaPagamento(listaPagamento.Cast<Pagamento>().ToList()));

            var hw = new HTMLWorker(doc);
            hw.Parse(new StringReader(corpoEmail));

            doc.Close();
        }

        //public void GerarPdf(List<DadosComissao> listaPagamento, string nomeVendedor, DateTime dataMesPagamento)
        //{
        //    var pagamento = listaPagamento.FirstOrDefault();
        //    if (pagamento == null) return;

        //    const string caminho = @"C:\B2B Tecnology PDF";
        //    if (!Directory.Exists(caminho))
        //        Directory.CreateDirectory(caminho);

        //    var doc = new Document();
        //    PdfWriter.GetInstance(doc, new FileStream(string.Format(@"{0}\{1}_{2}.pdf", caminho, nomeVendedor, dataMesPagamento.ToString("MMyyyy")), FileMode.Create));
        //    doc.Open();

        //    var corpoEmail = CorpoEmail();
        //    var data = dataMesPagamento.ToString("Y");
        //    corpoEmail = corpoEmail.Replace("[mes]", data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1));
        //    corpoEmail = corpoEmail.Replace("[tabela]", TabelaComissao());
        //    corpoEmail = corpoEmail.Replace("[canal]", nomeVendedor);
        //    corpoEmail = corpoEmail.Replace("[body]", BodyTabelaComissao(listaPagamento));
        //    corpoEmail = corpoEmail.Replace("[foot]", FooterTabelaComissao(listaPagamento));

        //    var hw = new HTMLWorker(doc);
        //    hw.Parse(new StringReader(corpoEmail));

        //    doc.Close();
        //}

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
                 .AppendLine("B2B TECHNOLOGY SERVIÇOS DE TELECOMUNICAÇÕES<br/>")
                 .AppendLine("CNPJ: 22.206.715/0001-38<br/>")
                 .AppendLine("RUA AMPARO, 315/319 - Sala 33 – BAETA NEVES – 09751-350 – SÃO BERNARDO DO CAMPO<br/>")
                 .AppendLine("E-mail: financeiro@b2btechnology.com.br<br/>")
                 .AppendLine("</b>")
                 .AppendLine("</p>")
                 .AppendLine("</div>")
                 .AppendLine("<br />")
                 .AppendLine("<br />")
                 .AppendLine("[InformacaoBody]")
                 .AppendLine("<div style='border-top: 3px solid #000;'>")
                 .AppendLine("</div>")
                 .AppendLine("<br/>")
                 .AppendLine("<br/>")
                 .AppendLine("<br/>")
                 .AppendLine("[tabela]")
                 .AppendLine("<br/>")
                 .AppendLine("Salientamos que neste momento não há necessidade de emissão de nota fiscal.")
                 .AppendLine("</div>")
                 .AppendLine("</body>")
                 .AppendLine("</html>");
            
            return htmlText.ToString();
        }

        private static string InformacaoBodyComissao()
        {
            var html = new StringBuilder()
                .AppendLine("<div style='border-top: 3px solid #000;'>")
                .AppendLine("COMISSÃO REFERENTE À ARRECADAÇÃO DE: <b>[mes]</b>")
                .AppendLine("</div>")
                .AppendLine("<div style='border-top: 3px solid #000;'>")
                .AppendLine("CANAL: <b>[canal]</b>")
                .AppendLine("</div>");

            return html.ToString();
        }

        private static string InformacaoBodyPagamento()
        {
            var html = new StringBuilder()
                .AppendLine("<div style='border-top: 3px solid #000;'>")
                .AppendLine("Resumo de Pagamento dos Clientes.")
                .AppendLine("</div>")
                .AppendLine("<div style='border-top: 3px solid #000;'>")
                .AppendLine("Cliente: <b>[canal]</b>")
                .AppendLine("</div>");

            return html.ToString();
        }

        private static string BodyTabelaComissao(List<DadosComissao> listaPagamento)
        {
            var tbody = new StringBuilder();
            listaPagamento.ForEach(p =>
            tbody.AppendFormat("	<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                , p.NomeCliente
                , Convert.ToDecimal(p.ValorPagar).ToString("C")
                , (Convert.ToDecimal(p.ValorPagar) - (Convert.ToDecimal(p.ValorPagar) * 0.06m)).ToString("C")
                , Convert.ToDecimal(p.Comissao).ToString("C")
                ));

            return tbody.ToString();
        }

        private static string FooterTabelaComissao(List<DadosComissao> listaPagamento)
        {
            return string.Format("<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                , "Total: "
                , listaPagamento.Sum(p => Convert.ToDecimal(p.ValorPagar)).ToString("C")
                , listaPagamento.Sum(p => Convert.ToDecimal(p.ValorPagar) - (Convert.ToDecimal(p.ValorPagar) * 0.06m)).ToString("C")
                , listaPagamento.Sum(p => Convert.ToDecimal(p.Comissao)).ToString("C"));
        }

        private static string TabelaComissao()
        {
            var html = new StringBuilder()
                .AppendLine("<table border='1'>")
                .AppendLine("<thead>")
                .AppendLine("<tr>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Empresa</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Faturamento Bruto</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Faturamento Líquido</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Comissão à Pagar</b>")
                .AppendLine("</th>")
                .AppendLine("</tr>")
                .AppendLine("</thead>")
                .AppendLine("<tbody>")
                .AppendLine("[body]")
                .AppendLine("</tbody>")
                .AppendLine("<tfoot>")
                .AppendLine("[foot]")
                .AppendLine("</tfoot>")
                .AppendLine("</table>");

            return html.ToString();
        }

        private static string TabelaPagamento()
        {
            var html = new StringBuilder()
                .AppendLine("<table border='1'>")
                .AppendLine("<thead>")
                .AppendLine("<tr>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Nome</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Data Pagamento</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Valor Pago</b>")
                .AppendLine("</th>")
                .AppendLine("<th style='width: 200px; text-align: center;'>")
                .AppendLine("<b>Pago</b>")
                .AppendLine("</th>")
                .AppendLine("</tr>")
                .AppendLine("</thead>")
                .AppendLine("<tbody>")
                .AppendLine("[body]")
                .AppendLine("</tbody>")
                .AppendLine("<tfoot>")
                .AppendLine("[foot]")
                .AppendLine("</tfoot>")
                .AppendLine("</table>");

            return html.ToString();
        }

        private static string BodyTabelaPagamento(List<Pagamento> listaPagamento)
        {
            var tbody = new StringBuilder();
            listaPagamento.ForEach(p =>
            tbody.AppendFormat("	<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                , p.Contrato.Cliente.Nome
                , p.DataPagamento.ToString("Y")
                , p.ValorPago.ToString("C")
                , p.Pago ? "Sim" : "Não"
                ));

            return tbody.ToString();
        }

        private static string FooterTabelaPagamento(List<Pagamento> listaPagamento)
        {
            return string.Format("<tr><td>{0}</th><td>{1}</th><td>{2}</th><td>{3}</th></tr>"
                , "Total: "
                , ""
                , listaPagamento.Sum(p => p.ValorPago).ToString("C")
                , "");
        }
    }
}
