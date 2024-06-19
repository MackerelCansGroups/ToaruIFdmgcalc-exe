using System;
using System.Linq;
using System.Data;
using System.Data.SQLite;

namespace calc
{
    /// <summary>
    /// DAOの基底クラス
    /// </summary>
    public abstract class BaseDao : IDisposable
    {
        /// <summary>データベースとの接続</summary>
        private DbConnect Connection { get; }

        /// <summary>コマンドオブジェクト</summary>
        private SQLiteCommand command = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="connection">データベースとの接続</param>
        public BaseDao(DbConnect connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// リソースを開放する。
        /// </summary>
        public void Dispose()
        {
            // コマンドオブジェクトが生きているなら閉じる
            if (command != null)
            {
                command.Dispose();
                command = null;
            }
        }

        /// <summary>
        /// 検索系のSQLを実行し、結果を返す。
        /// </summary>
        /// <returns>検索結果を格納する<see cref="SQLiteDataReader"/></returns>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない</exception>
        protected SQLiteDataReader ExecuteReader()
        {
            CheckCommand();
            return command.ExecuteReader();
        }

        /// <summary>
        /// 検索系のSQLを直接実行し、結果を返す。
        /// </summary>
        /// <param name="sql">実行するSQL</param>
        /// <returns>検索結果を格納する<see cref="SQLiteDataReader"/></returns>
        protected SQLiteDataReader ExecuteReader(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection.Connection))
            {
                return cmd.ExecuteReader();
            }
        }

        /// <summary>
        /// 更新系のSQLを実行する。
        /// </summary>
        /// <returns>影響を受けた行数</returns>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない</exception>
        protected int Execute()
        {
            CheckCommand();
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// 更新系のSQLを直接実行する。
        /// </summary>
        /// <param name="sql">実行するSQL</param>
        /// <returns>影響を受けた行数</returns>
        protected int Execute(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection.Connection))
            {
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 検索系のSQLを実行し、単一の結果を返す。
        /// </summary>
        /// <returns>SQLの実行結果の先頭行・先頭列の値</returns>
        protected object ExecuteScalar()
        {
            CheckCommand();
            return command.ExecuteScalar();
        }

        /// <summary>
        /// 検索系のSQLを直接実行し、単一の結果を返す。
        /// </summary>
        /// <param name="sql">実行するSQL</param>
        /// <returns>SQLの実行結果の先頭行・先頭列の値</returns>
        protected object ExecuteScalar(string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection.Connection))
            {
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 実行するSQLを設定する。<br/>
        /// 既に実行済みの場合、以前に設定したSQLは破棄される。
        /// </summary>
        /// <param name="commandText">実行するSQL</param>
        protected void SetCommandText(string commandText)
        {
            if (command != null)
            {
                command.Dispose();
            }
            command = new SQLiteCommand(commandText, Connection.Connection);
        }

        /// <summary>
        /// 設定済みのSQLに整数のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, int value)
        {
            CheckCommand();
            command.Parameters.Add(name, DbType.Int32).Value = value;
        }

        /// <summary>
        /// 設定済みのSQLに整数のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, int? value)
        {
            if (value.HasValue)
            {
                SetParameter(name, value.Value);
            }
            else
            {
                SetParameterNull(name);
            }
        }

        /// <summary>
        /// 設定済みのSQLに長整数型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, long value)
        {
            CheckCommand();
            command.Parameters.Add(name, DbType.Int64).Value = value;
        }

        /// <summary>
        /// 設定済みのSQLに長整数型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, long? value)
        {
            if (value.HasValue)
            {
                SetParameter(name, value.Value);
            }
            else
            {
                SetParameterNull(name);
            }
        }

        /// <summary>
        /// 設定済みのSQLに浮動小数点型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, double value)
        {
            CheckCommand();
            command.Parameters.Add(name, DbType.Double).Value = value;
        }

        /// <summary>
        /// 設定済みのSQLに浮動小数点型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, double? value)
        {
            if (value.HasValue)
            {
                SetParameter(name, value.Value);
            }
            else
            {
                SetParameterNull(name);
            }
        }

        /// <summary>
        /// 設定済みのSQLにdecimal型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, decimal value)
        {
            CheckCommand();
            command.Parameters.Add(name, DbType.Decimal).Value = value;
        }

        /// <summary>
        /// 設定済みのSQLにdecimal型のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータ名</param>
        /// <param name="value">パラメータの値</param>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>を実行していない場合</exception>
        protected void SetParameter(string name, decimal? value)
        {
            if (value.HasValue)
            {
                SetParameter(name, value.Value);
            }
            else
            {
                SetParameterNull(name);
            }
        }

        /// <summary>
        /// 設定済みのSQLに文字列のパラメータを設定する。
        /// </summary>
        /// <param name="name">パラメータの名前</param>
        /// <param name="value">パラメータの値</param>
        protected void SetParameter(string name, string value)
        {
            CheckCommand();
            command.Parameters.Add(name, DbType.String).Value = value;
        }

        /// <summary>
        /// 設定済みのSQLのパラメータにnullを設定する。
        /// </summary>
        /// <param name="name">パラメータの名前</param>
        protected void SetParameterNull(string name)
        {
            CheckCommand();
            command.Parameters.AddWithValue(name, null);
        }

        /// <summary>
        /// <see cref="SetCommandText(string)"/>が実行済みかどうかをチェックする。
        /// </summary>
        /// <exception cref="InvalidOperationException"><see cref="SetCommandText(string)"/>が実行されていない</exception>
        private void CheckCommand()
        {
            if (command == null)
            {
                throw new InvalidOperationException("コマンドテキストが設定されていません。");
            }
        }

        /// <summary>
        /// 実行SQLの取得
        /// </summary>
        /// <returns>実行SQL</returns>
        protected string ExcecSQL()
        {
            // SQL文の取得
            string sql = command.CommandText;
            // パラメータ情報の取得
            foreach (var param in command.Parameters.OfType<SQLiteParameter>())
            {
                // パラメータ
                string name = param.ParameterName;
                // 設定値
                string val = param.Value == null ? "NULL" : param.Value.ToString();
                if (param.DbType == DbType.String && param.Value != null)
                {
                    val = $"'{val}'";
                }
                // パラメータ情報の置き換え
                sql = sql.Replace($":{name}", val);
            }
            // 戻り値セット
            return sql;
        }
    }
}
