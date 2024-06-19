using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using System;

namespace calc
{
    class Logic
    {
        public double Calculate1(string str)
            => double.Parse((new System.Data.DataTable()).Compute(str, "").ToString());

        public int tryStr(string str)
        {
            int i = 0;
            bool result = int.TryParse(str, out i);
            if (result) return i;
            return 0;
        }
        public double tryStr2(string str)
        {
            double i = 0;
            bool result = double.TryParse(str, out i);
            if (result) return i;
            return 0;
        }

        public List<T_resultDto> Loadfes()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_resultDao dao = new T_resultDao(conn))
            using (SQLiteDataReader reader = dao.Select())
            {
                try
                {
                    return dao.List(reader);
                }
                catch
                {
                    return new List<T_resultDto> { };
                }
            }
        }

        public T_bufDto Loadbuf(string pk)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_bufDao dao = new T_bufDao(conn))
            using (SQLiteDataReader reader = dao.Select(pk))
            {
                try
                {
                    return dao.ListTmp(reader);
                    
                }
                catch
                {
                    return new T_bufDto();
                }
            }
        }

        public List<T_bufDto> LoadbufAll()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_bufDao dao = new T_bufDao(conn))
            using (SQLiteDataReader reader = dao.SelectAll())
            {
                try
                {
                    return dao.ListAll(reader);
                }
                catch
                {
                    return new List<T_bufDto> { };
                }
            }
        }

        public void UpdateBuf(List<T_bufDto> dto)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_bufDao dao = new T_bufDao(conn))
            {
                try
                {
                    conn.BeginTransaction();
                    foreach (T_bufDto i in dto) dao.Update(i);
                    conn.Commit();
                }
                catch
                {
                    conn.Rollback();
                }
            }
        }

        public void UpdateTxt(List<T_objectDto> dto)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            {
                try
                {
                    conn.BeginTransaction();
                    foreach (T_objectDto i in dto) dao.UpdateTxt(i);
                    conn.Commit();
                }
                catch
                {
                    conn.Rollback();
                }
            }
        }

        public void UpdateChk(List<T_objectDto> dto)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            {
                try
                {
                    conn.BeginTransaction();
                    foreach (T_objectDto i in dto) dao.UpdateChk(i);
                    conn.Commit();
                }
                catch
                {
                    conn.Rollback();
                }
            }
        }

        public void UpdateIdx(List<T_objectDto> dto)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            {
                try
                {
                    conn.BeginTransaction();
                    foreach (T_objectDto i in dto) dao.UpdateIdx(i);
                    conn.Commit();
                }
                catch
                {
                    conn.Rollback();
                }
            }
        }

        public List<T_objectDto> Loadtxtall()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            using (SQLiteDataReader reader = dao.SelectTxt())
            {
                try
                {
                    return dao.List(reader);
                }
                catch
                {
                    return new List<T_objectDto> { };
                }
            }
        }

        public List<T_objectDto> Loadidxall()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            using (SQLiteDataReader reader = dao.SelectIdx())
            {
                try
                {
                    return dao.List(reader);
                }
                catch
                {
                    return new List<T_objectDto> { };
                }
            }
        }

        public List<String> Loadpulldown(string pk)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            using (SQLiteDataReader reader = dao.SelectComLK(pk))
            {
                try
                {
                    return dao.ListLK(reader);
                }
                catch
                {
                    return new List<String> { };
                }
            }
        }

        public double LoadpulldownVal(string pk, string name)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            using (SQLiteDataReader reader = dao.SelectComLKEQ(pk, name))
            {
                try
                {
                    return dao.ListLKEQ(reader);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public List<T_objectDto> Loadchkall()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_objectDao dao = new T_objectDao(conn))
            using (SQLiteDataReader reader = dao.SelectChk())
            {
                try
                {
                    return dao.ListChk(reader);
                }
                catch
                {
                    return new List<T_objectDto> { };
                }
            }
        }

        public T_spDto Loadsp1(string name)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_spDao dao = new T_spDao(conn))
            using (SQLiteDataReader reader = dao.Select(name))
            {
                try
                {
                    return dao.ListTmp(reader);
                }
                catch
                {
                    return new T_spDto();
                }
            }
        }

        public T_spDto Loadsp2(string name)
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_spDao dao = new T_spDao(conn))
            using (SQLiteDataReader reader = dao.Select2(name))
            {
                try
                {
                    return dao.List_tokkouTmp(reader);
                }
                catch
                {
                    return new T_spDto();
                }
            }
        }

        public List<String> Loadsp1pull()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_spDao dao = new T_spDao(conn))
            using (SQLiteDataReader reader = dao.SelectAll())
            {
                try
                {
                    return dao.ListPull(reader);
                }
                catch
                {
                    return new List<String> { };
                }
            }
        }

        public List<String> Loadsp2pull()
        {
            using (DbConnect conn = new DbConnect(ConfigurationManager.AppSettings["DatabasePath"]))
            using (T_spDao dao = new T_spDao(conn))
            using (SQLiteDataReader reader = dao.SelectAll2())
            {
                try
                {
                    return dao.ListPull(reader);
                }
                catch
                {
                    return new List<String> { };
                }
            }
        }
    }
}
