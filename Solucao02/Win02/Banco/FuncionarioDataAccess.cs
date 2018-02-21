using System;
using System.Data;
using System.Data.SqlServerCe;

namespace Win02.Banco {
    class FuncionarioDataAccess {
        public static DataTable pegarFuncionario() {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\Marcos Antônio\Documents\Curso de Windows Forms com C#\Solucao02\Win02\Banco\banco.sdf");

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", con);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }
    }
}
