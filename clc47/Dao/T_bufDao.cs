using System.Collections.Generic;
using System.Data.SQLite;

namespace calc
{
    class T_bufDao : BaseDao
    {
        #region カラム名定義
        private static string pk => "PROG_ID";
        private static string cnts => "CntS";
        private static string cntm => "CntM";
        private static string cntl => "CntL";
        private static string cntxl => "CntXL";
        private static string cntxxl => "CntXXL";
        #endregion

        #region SQL定義
        private static string TABLE => "T_grid_buf";
        private static string SELECT => $@"SELECT * FROM {TABLE} WHERE {pk} = :{pk}";
        private static string SELECTALL => $@"SELECT * FROM {TABLE}";
        private static string UPDATE => $@"UPDATE {TABLE} SET
            {cnts} = :{cnts},
            {cntm} = :{cntm},
            {cntl} = :{cntl},
            {cntxl} = :{cntxl},
            {cntxxl} = :{cntxxl}
            WHERE {pk} = :{pk}";
        #endregion

        /// <summary>コンストラクタ</summary>
        public T_bufDao(DbConnect connect) : base(connect) { }
        public SQLiteDataReader Select(string pk_)
        {
            SetCommandText(SELECT);
            SetParameter(pk, pk_);
            return ExecuteReader();
        }
        public SQLiteDataReader SelectAll()
        {
            SetCommandText(SELECTALL);
            return ExecuteReader();
        }
        public SQLiteDataReader Update(T_bufDto dto)
        {
            SetCommandText(UPDATE);
            SetParameter(pk, dto.pk);
            SetParameter(cnts, dto.cnts);
            SetParameter(cntm, dto.cntm);
            SetParameter(cntl, dto.cntl);
            SetParameter(cntxl, dto.cntxl);
            SetParameter(cntxxl, dto.cntxxl);
            return ExecuteReader();
        }
        public T_bufDto List(SQLiteDataReader reader)
        {
            return new T_bufDto
            {
                pk = reader.GetString(1),
                name = reader.GetString(2),
                upper = reader.GetDouble(3),
                bufs = reader.GetDouble(4),
                bufm = reader.GetDouble(5),
                bufl = reader.GetDouble(6),
                bufxl = reader.GetDouble(7),
                bufxxl = reader.GetDouble(8),
                slvs = reader.GetInt32(9),
                slvm = reader.GetInt32(10),
                slvl = reader.GetInt32(11),
                slvxl = reader.GetInt32(12),
                slvxxl = reader.GetInt32(13),
                cnts = reader.GetInt32(14),
                cntm = reader.GetInt32(15),
                cntl = reader.GetInt32(16),
                cntxl = reader.GetInt32(17),
                cntxxl = reader.GetInt32(18)
            };
        }
        public List<T_bufDto> ListAll(SQLiteDataReader reader)
        {
            List<T_bufDto> list = new List<T_bufDto>();
            while (reader.Read())
            {
                T_bufDto dto = List(reader);
                list.Add(dto);
            }
            return list;
        }
        public T_bufDto ListTmp(SQLiteDataReader reader)
        {
            T_bufDto dto = new T_bufDto();
            while (reader.Read())
            {
                dto = List(reader);
            }
            return dto;
        }
    }
}
