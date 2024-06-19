using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace calc
{
    /// <summary>
    /// データベースとの接続を管理するクラス。
    /// </summary>
    public class DbConnect : IDisposable
    {
        /// <summary>
        /// DB接続
        /// </summary>
        internal SQLiteConnection Connection { get; }

        /// <summary>
        /// トランザクション
        /// </summary>
        private SQLiteTransaction trans = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dbFileName">データベースファイル名</param>
        public DbConnect(string dbFileName)
        {
            // 接続文字列作成
            string connStr = $"Data Source={dbFileName}";

            // DB接続
            Connection = new SQLiteConnection(connStr);
            Connection.Open();
        }

        /// <summary>
        /// トランザクションを開始する。<br/>
        /// 既にトランザクションが開始されている場合は何もしない。
        /// </summary>
        public void BeginTransaction()
        {
            if (trans == null)
            {
                trans = Connection.BeginTransaction();
            }
        }

        /// <summary>
        /// トランザクションをコミットする。<br/>
        /// トランザクションが開始されていない場合は何もしない。
        /// </summary>
        public void Commit()
        {
            if(trans != null)
            {
                trans.Commit();
                trans.Dispose();
                trans = null;
            }
        }

        /// <summary>
        /// トランザクションをロールバックする。<br/>
        /// トランザクションが開始されていない場合は何もしない。
        /// </summary>
        public void Rollback()
        {
            if(trans != null)
            {
                trans.Rollback();
                trans.Dispose();
                trans = null;
            }
        }

        /// <summary>
        /// データベースとの接続をクローズしリソースを開放する
        /// </summary>
        public void Dispose()
        {
            // トランザクションが有効な場合はロールバックする
            if(trans != null)
            {
                trans.Rollback();
                trans.Dispose();
            }
            // データベースとの接続を閉じる
            Connection.Close();
        }
    }
}
