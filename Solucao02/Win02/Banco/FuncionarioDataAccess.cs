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

        public static bool AtualizarFuncionario(Funcionario funcionario) {
            string sql = "UPDATE [Funcionario] SET Nome = @Nome, Email = @Email, Salario = @Salario, Sexo = @Sexo, TipoContrato = @TipoContrato, DataAtualizacao = @DataAtualizacao WHERE Id = @Id";
            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@Id", funcionario.Id);
            comando.Parameters.Add("@Nome", funcionario.Nome);
            comando.Parameters.Add("@Email", funcionario.Email);
            comando.Parameters.Add("@Salario", funcionario.Salario);
            comando.Parameters.Add("@Sexo", funcionario.Sexo);
            comando.Parameters.Add("@TipoContrato", funcionario.TipoContrato);
            comando.Parameters.Add("@DataAtualizacao", funcionario.DataAtualizacao);

            con.Open();

            if (comando.ExecuteNonQuery() > 0) {
                con.Close();
                return true;
            } else {
                con.Close();
                return false;
            }
        }

        public static Funcionario PegarFuncionario(int id) {
            string sql = "SELECT * FROM [Funcionario] WHERE Id = @id";

            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@id", id);

            con.Open();
            SqlCeDataReader resposta = comando.ExecuteReader();
            Funcionario funcionario = new Funcionario();
            while (resposta.Read()) {
                funcionario.Id = resposta.GetInt32(0);
                funcionario.Nome = resposta.GetString(1);
                funcionario.Email = resposta.GetString(2);
                funcionario.Salario = resposta.GetDecimal(3);
                funcionario.Sexo = resposta.GetString(4);
                funcionario.TipoContrato = resposta.GetString(5);
                funcionario.DataCadastro = resposta.GetDateTime(6);
                // if (resposta.IsDBNull(7)) {
                //funcionario.DataAtualizacao = null;
                //} else {
                if (! resposta.IsDBNull(7)) { // pog
                    funcionario.DataAtualizacao = resposta.GetDateTime(7);
                }
            }
            con.Close();

            return funcionario;
        }

        public static Funcionario ExcluirFuncionario(int id) {
            string sql = "DELETE * FROM [Funcionario] WHERE Id = @id";

            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@id", id);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();

            return funcionario;
        }
    }
}
