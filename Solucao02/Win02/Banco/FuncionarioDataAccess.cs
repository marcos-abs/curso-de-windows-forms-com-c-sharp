using System;
using System.Data;
using System.Data.SqlServerCe;
using Win02.Modelo;

namespace Win02.Banco {
    class FuncionarioDataAccess {
        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Marcos Antônio\Documents\Curso de Windows Forms com C#\Solucao02\Win02\Banco\banco.sdf");

        public static DataTable pegarFuncionario() {

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }

        public static bool SalvarFuncionario(Funcionario funcionario) {
            string sql = "INSERT INTO [Funcionario] (Nome, Email, Salario, Sexo, TipoContrato, DataCadastro) VALUES (@Nome, @Email, @Salario, @Sexo, @TipoContrato, @DataCadastro)";
            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@Nome", funcionario.Nome);
            comando.Parameters.Add("@Email", funcionario.Email);
            comando.Parameters.Add("@Salario", funcionario.Salario);
            comando.Parameters.Add("@Sexo", funcionario.Sexo);
            comando.Parameters.Add("@TipoContrato", funcionario.TipoContrato);
            comando.Parameters.Add("@DataCadastro", funcionario.DataCadastro);

            con.Open();

            if (comando.ExecuteNonQuery() > 0) {
                con.Close();
                return true;
            } else {
                con.Close();
                return false;
            }

        }
    }
}
