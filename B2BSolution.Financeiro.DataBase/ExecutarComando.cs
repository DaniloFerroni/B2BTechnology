using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.DataBase
{
    public class ExecutarComando<T> where T : class, new()
    {
        private readonly static string stringConexao = @"Password=#b2b2015financeiro;Persist Security Info=True;User ID=b2btecnology;Initial Catalog=B2BSolution;Data Source=DANILO-PC\SQLEXPRESS;MultipleActiveResultSets=true;";
        //private readonly static string stringConexao = @"Password=#b2b2015financeiro;Persist Security Info=True;User ID=b2btecnology;Initial Catalog=B2BSolution;Data Source=WIN-NHN652PK405\SQLEXPRESS";

        public static bool ExecutarComandoSemRetorno(string procedure, List<SqlParameter> parametros)
        {
            try
            {
                using (var conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    using (var comando = new SqlCommand(procedure, conexao))
                    {
                        if (parametros != null && parametros.Count > 0)
                            comando.Parameters.AddRange(parametros.ToArray());

                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ExecutarComandoSemRetorno: {0}", ex.Message));
            }
        }

        public static int ExecutarComandoInsert(string procedure, List<SqlParameter> parametros)
        {
            try
            {
                int identity;

                using (var conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    using (var comando = new SqlCommand(procedure, conexao))
                    {
                        if (parametros != null && parametros.Count > 0)
                            comando.Parameters.AddRange(parametros.ToArray());

                        comando.CommandType = CommandType.StoredProcedure;
                        identity = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }

                return identity;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ExecutarComandoInsert: {0}", ex.Message));
            }
        }

        public static T RetornarEntidade(string procedure, List<SqlParameter> parametros)
        {
            try
            {
                var classePropriedade = Activator.CreateInstance<T>();
                var propriedades = classePropriedade.GetType().GetProperties();

                using (var conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    using (var comando = new SqlCommand(procedure, conexao))
                    {
                        if (parametros != null && parametros.Count > 0)
                            comando.Parameters.AddRange(parametros.ToArray());

                        comando.CommandType = CommandType.StoredProcedure;
                        using (var select = comando.ExecuteReader())
                        {
                            if (select.Read())
                            {
                                classePropriedade = GravarPropriedade(propriedades, classePropriedade, @select);
                            }
                        }
                    }
                }

                return classePropriedade;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("RetornarEntidade: {0}", ex.Message));
            }
        }

        public static List<T> RetornarListaTipada(string procedure, List<SqlParameter> parametros)
        {
            try
            {
                var classePropriedade = Activator.CreateInstance<T>();
                var propriedades = classePropriedade.GetType().GetProperties();
                var lista = new List<T>();

                using (var conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    using (var comando = new SqlCommand(procedure, conexao))
                    {
                        if (parametros != null && parametros.Count > 0)
                            comando.Parameters.AddRange(parametros.ToArray());

                        comando.CommandType = CommandType.StoredProcedure;
                        using (var select = comando.ExecuteReader())
                        {
                            while (select.Read())
                            {
                                lista.Add(classePropriedade = GravarPropriedade(propriedades, classePropriedade, @select));
                            }
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("RetornarListaTipada: {0}", ex.Message));
            }
        }

        //private static T GravarPropriedade(IEnumerable<PropertyInfo> propriedades, T classePropriedade, SqlDataReader @select)
        //{
        //    if (classePropriedade == null)
        //        throw new ArgumentNullException("classePropriedade");

        //    classePropriedade = new T();

        //    foreach (var propriedade in propriedades)
        //    {
        //        var atributoGenerico = (Atributo)propriedade.GetCustomAttributes(typeof(Atributo), false)[0];
        //        if ("".Equals(@select[atributoGenerico.NomeAtributo].ToString())) continue;

        //        if (propriedade.PropertyType.IsClass && !("System").Equals(propriedade.PropertyType.Namespace))
        //        {
        //            var novaClasse = Activator.CreateInstance(Type.GetType(string.Format("{0}, {1}", propriedade.PropertyType.FullName, propriedade.PropertyType.Namespace)));
        //            foreach (var propriedadeSubClasse in novaClasse.GetType().GetProperties())
        //            {
        //                var atributoSubClasse = (Atributo)propriedadeSubClasse.GetCustomAttributes(typeof(Atributo), false)[0];
        //                var valor = @select[atributoSubClasse.NomeAtributo];
        //                var te = Convert.ChangeType(valor, propriedadeSubClasse.PropertyType);
        //                propriedadeSubClasse.SetValue(novaClasse, te, null);
        //            }
        //            propriedade.SetValue(classePropriedade, novaClasse, null);   
        //        }
        //        else
        //        {
        //            propriedade.SetValue(classePropriedade, @select[atributoGenerico.NomeAtributo], null);   
        //        }
        //    }

        //    return classePropriedade;
        //}

        private static T GravarPropriedade(IEnumerable<PropertyInfo> propriedades, T classePropriedade, SqlDataReader @select)
        {
            if (classePropriedade == null)
                throw new ArgumentNullException("classePropriedade");

            classePropriedade = new T();

            CarregarPropriedades(propriedades, classePropriedade, @select);

            return classePropriedade;
        }

        private static void CarregarPropriedades<T>(IEnumerable<PropertyInfo> propriedades, T classePropriedade, SqlDataReader @select)
        {
            foreach (var propriedade in propriedades)
            {
                var atributoGenerico = (Atributo) propriedade.GetCustomAttributes(typeof (Atributo), false)[0];
                if ("".Equals(@select[atributoGenerico.NomeAtributo].ToString())) continue;

                if (propriedade.PropertyType.IsClass && !("System").Equals(propriedade.PropertyType.Namespace))
                {
                    var novaClasse = Activator.CreateInstance(Type.GetType(string.Format("{0}, {1}", propriedade.PropertyType.FullName,propriedade.PropertyType.Namespace)));
                    CarregarPropriedades(novaClasse.GetType().GetProperties(), novaClasse, @select);
                    propriedade.SetValue(classePropriedade, novaClasse, null);
                }
                else
                {
                    propriedade.SetValue(classePropriedade, @select[atributoGenerico.NomeAtributo], null);
                }
            }
        }
    }
}
