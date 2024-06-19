using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace calc
{
    class T_objectDao : BaseDao
    {
        #region カラム名定義
        private static string pk => "PROG_ID";
        private static string name => "Name";
        private static string val => "Val";
        private static string chk => "Checked";
        #endregion

        #region SQL定義
        private static string SELECT_TXT => $@"SELECT * FROM T_txt";
        private static string SELECT_IDX => $@"SELECT * FROM T_pulldownIndex";
        private static string SELECT_CHK => $@"SELECT * FROM (
            SELECT * FROM T_chk
            UNION SELECT * FROM T_chk_senzai1
            UNION SELECT * FROM T_chk_senzai2
            )";
        private static string SELECT_COM_LK => $@"SELECT * FROM T_pulldown WHERE {pk} LIKE :{pk}";
        private static string SELECT_COM_LKEQ => $@"SELECT * FROM T_pulldown WHERE {pk} LIKE :{pk} AND {name} = :{name}";
        private static string UPDATE_TXT => $@"UPDATE T_txt SET {val} = :{val} WHERE {pk} = :{pk}";
        private static string UPDATE_IDX => $@"UPDATE T_pulldownIndex SET {val} = :{val} WHERE {pk} = :{pk}";
        private static string UPDATE_CHK => $@"UPDATE T_chk         SET {chk} = :{chk} WHERE {pk} = :{pk};
                                               UPDATE T_chk_senzai1 SET {chk} = :{chk} WHERE {pk} = :{pk};
                                               UPDATE T_chk_senzai2 SET {chk} = :{chk} WHERE {pk} = :{pk};";
        #endregion

        /// <summary>コンストラクタ</summary>
        /// <param" >DB接続</param>
        public T_objectDao(DbConnect connect) : base(connect) { }
        public SQLiteDataReader SelectTxt()
        {
            SetCommandText(SELECT_TXT);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectChk()
        {
            SetCommandText(SELECT_CHK);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectIdx()
        {
            SetCommandText(SELECT_IDX);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectComLK(string pk_)
        {
            SetCommandText(SELECT_COM_LK);
            SetParameter(pk, pk_ + "%");
            return ExecuteReader();
        }
        public SQLiteDataReader SelectComLKEQ(string pk_, string name_)
        {
            SetCommandText(SELECT_COM_LKEQ);
            SetParameter(pk, pk_ + "%");
            SetParameter(name, name_);
            return ExecuteReader();
        }
        public SQLiteDataReader UpdateTxt(T_objectDto dto)
        {
            SetCommandText(UPDATE_TXT);
            SetParameter(pk, dto.pk);
            SetParameter(val, dto.val);
            return ExecuteReader();
        }
        public SQLiteDataReader UpdateChk(T_objectDto dto)
        {
            SetCommandText(UPDATE_CHK);
            SetParameter(pk, dto.pk);
            SetParameter(chk, dto.chk.ToString().ToLower());
            return ExecuteReader();
        }
        public SQLiteDataReader UpdateIdx(T_objectDto dto)
        {
            SetCommandText(UPDATE_IDX);
            SetParameter(pk, dto.pk);
            SetParameter(val, dto.val);
            return ExecuteReader();
        }
        public List<T_objectDto> List(SQLiteDataReader reader)
        {
            List<T_objectDto> list = new List<T_objectDto>();
            while (reader.Read())
            {
                T_objectDto dto = new T_objectDto
                {
                    pk = reader.GetString(1),
                    name = reader.GetString(2),
                    val = reader.GetDouble(3)
                };
                list.Add(dto);
            }
            return list;
        }
        public List<T_objectDto> ListChk(SQLiteDataReader reader)
        {
            List<T_objectDto> list = new List<T_objectDto>();
            while (reader.Read())
            {
                T_objectDto dto = new T_objectDto
                {
                    pk = reader.GetString(1),
                    name = reader.GetString(2),
                    val = reader.GetDouble(3),
                    chk = reader.GetString(4).ToLower() == "true" ? true : false
                };
                list.Add(dto);
            }
            return list;
        }
        public List<String> ListLK(SQLiteDataReader reader)
        {
            List<String> list = new List<String>();
            foreach (T_objectDto i in List(reader)) list.Add(i.name);
            return list;
        }
        public double ListLKEQ(SQLiteDataReader reader)
        {
            return List(reader)[0].val;
        }
    }
}
