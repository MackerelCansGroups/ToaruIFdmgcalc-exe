using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace calc
{
    class T_spDao : BaseDao
    {
        #region カラム名定義
        private static string pk => "PROG_ID";
        private static string name => "Name";
        #endregion

        #region SQL定義
        private static string SELECT => $@"SELECT * FROM T_pulldown_sp1 WHERE {name} = :{name}";
        private static string SELECT2 => $@"SELECT * FROM T_pulldown_sp2 WHERE {name} = :{name}";
        private static string SELECTALL => $@"SELECT * FROM T_pulldown_sp1";
        private static string SELECTALL2 => $@"SELECT * FROM T_pulldown_sp2";
        #endregion

        /// <summary>コンストラクタ</summary>
        public T_spDao(DbConnect connect) : base(connect) { }
        public SQLiteDataReader Select(string name_)
        {
            SetCommandText(SELECT);
            SetParameter(name, name_);
            return ExecuteReader();
        }
        public SQLiteDataReader Select2(string name_)
        {
            SetCommandText(SELECT2);
            SetParameter(name, name_);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectAll()
        {
            SetCommandText(SELECTALL);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectAll2()
        {
            SetCommandText(SELECTALL2);
            return ExecuteReader();
        }
        public T_spDto List(SQLiteDataReader reader)
        {
            return new T_spDto
            {
                pk = reader.GetString(1),
                name = reader.GetString(2),
                buf = reader.GetString(3),
                slv = reader.GetInt32(4)
            };
        }
        public T_spDto List_tokkou(SQLiteDataReader reader)
        {
            return new T_spDto
            {
                pk = reader.GetString(1),
                name = reader.GetString(2),
                buf = reader.GetString(3)
            };
        }
        public T_spDto ListTmp(SQLiteDataReader reader)
        {
            T_spDto dto = new T_spDto();
            while (reader.Read())
            {
                dto = List(reader);
            }
            return dto;
        }
        public T_spDto List_tokkouTmp(SQLiteDataReader reader)
        {
            T_spDto dto = new T_spDto();
            while (reader.Read())
            {
                dto = List_tokkou(reader);
            }
            return dto;
        }
        public List<String> ListPull(SQLiteDataReader reader)
        {
            List<String> list = new List<String>();
            while (reader.Read()) list.Add(List_tokkou(reader).name);
            return list;
        }
    }
}
