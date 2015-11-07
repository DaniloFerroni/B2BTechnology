using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Formulario.Entidade;

namespace B2BSolution.Financeiro.Formulario.Util
{
    public static class Extencion
    {

        public static Endereco BuscarCep(this Endereco endereco, string cep)
        {
            var caminhoXml = string.Format("http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=xml", cep);
            var xml = XDocument.Load(caminhoXml);
            var xmlSerializer = new XmlSerializer(typeof(webservicecep));
            var serviceCep = (webservicecep)xmlSerializer.Deserialize(xml.CreateReader());

            return new Endereco
            {
                Rua = string.Format("{0} {1}", serviceCep.tipo_logradouro, serviceCep.logradouro),
                Bairro = serviceCep.bairro,
                Cidade = serviceCep.cidade,
                Estado = serviceCep.uf,
                Cep = cep,
            };
        }

        public static DateTime PrimeiroDiaMes(this string dataSelecionada)
        {
            var textoDataBase = string.Concat("01-", dataSelecionada);
            return Convert.ToDateTime(textoDataBase);
        }

        public static DateTime UltimoDiaMes(this string dataSelecionada)
        {
            var textoDataBase = string.Concat("01-", dataSelecionada);
            var dataBase = Convert.ToDateTime(textoDataBase);
            dataBase = dataBase.AddMonths(1);
            dataBase = dataBase.AddDays(-1);

            return dataBase;
        }

        public static string RemoverMascara(this string texto)
        {
            return texto
                .Replace(".", "")
                .Replace("-", "")
                .Replace("/", "")
                .Replace(",", "")
                .Replace("(", "")
                .Replace(")", "")
                .Trim();
        }

        public static string MascaraCnpj(this string texto)
        {
            //11.111.111/1111/11
            var cnpj = string.Format("{0}.{1}.{2}/{3}-{4}"
                , texto.Substring(0, 2)
                , texto.Substring(2, 3)
                , texto.Substring(5, 3)
                , texto.Substring(8, 4)
                , texto.Substring(12, 2)
                );
            return cnpj;
        }

        public static string MascaraCpf(this string texto)
        {
            //111.111.111.11
            var cpf = string.Format("{0}.{1}.{2}-{3}"
                , texto.Substring(0, 3)
                , texto.Substring(3, 3)
                , texto.Substring(6, 3)
                , texto.Substring(9, 2)
                );
            return cpf;
        }

    }
}
