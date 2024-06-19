using System.Collections.Generic;
using System.Data.SQLite;

namespace calc
{
    class T_resultDao : BaseDao
    {
        #region SQL定義
        private static string SELECT => $@"SELECT * FROM T_grid_result";
        #endregion

        /// <summary>コンストラクタ</summary>
        /// <param">DB接続</param>
        public T_resultDao(DbConnect connect) : base(connect) { }
        public SQLiteDataReader Select()
        {
            SetCommandText(SELECT);
            return ExecuteReader();
        }
        public List<T_resultDto> List(SQLiteDataReader reader)
        {
            List<T_resultDto> list = new List<T_resultDto>();
            while (reader.Read())
            {
                T_resultDto dto = new T_resultDto
                {
                    header = reader.GetString(1),
                    fesm = reader.GetInt32(2),
                    fesl = reader.GetInt32(3)
                };
                list.Add(dto);
            }
            return list;
        }
    }
}
