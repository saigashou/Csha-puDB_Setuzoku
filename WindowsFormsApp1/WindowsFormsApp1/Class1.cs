using MySql.Data.MySqlClient;               //MySql
using System;
using System.Configuration;                 //Configuration

    class Class1
    {
        //****************************************************************
        //  DB接続管理
        //****************************************************************
        /// <summary>
        /// DBへ追加更新し条件表示を行う
        /// </summary>
        /// <param name="strSQL">SQL文</param>
        /// <param name="optDg">DataGrid</param>
        public static void pDB_Setuzoku(string strSQL, ref System.Windows.Forms.DataGridView optDg)
        {
            //接続用変数の定義(ADO.NET）
            string strConnectSQL;
            //データセット
            System.Data.DataSet SqlDS = new System.Data.DataSet();
            try
            {
                //接続の設定
                strConnectSQL = ConfigurationManager.ConnectionStrings["DB設定"].ConnectionString;
                MySqlDataAdapter SqlMSDA = new MySqlDataAdapter(strSQL, strConnectSQL);

                //データセットに格納
                SqlMSDA.Fill(SqlDS, "table");

                //データグリッドビューのデータソースを設定
                optDg.DataSource = SqlDS.Tables["table"];

                strSQL = "";

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DB内エラーです。以下を確認して下さい。" +
                    Environment.NewLine + ex.Message);
            }

        }
    }
