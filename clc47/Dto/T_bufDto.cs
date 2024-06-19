using System;

namespace calc
{
    class T_bufDto
    {
        public T_bufDto()
        {
            pk = "";
            name = "";
            upper = 0;
            bufs = 0;
            bufm = 0;
            bufl = 0;
            bufxl = 0;
            bufxxl = 0;
            slvs = 0;
            slvm = 0;
            slvl = 0;
            slvxl = 0;
            slvxxl = 0;
            cnts = 0;
            cntm = 0;
            cntl = 0;
            cntxl = 0;
            cntxxl = 0;
        }
        /// <summary>主キー</summary>
        public virtual string pk { get; set; }
        /// <summary>名称</summary>
        public virtual string name { get; set; }
        /// <summary>上限</summary>
        public virtual double upper { get; set; }
        /// <summary>倍率：小/中/大/特大/超特大</summary>
        public virtual double bufs { get; set; }
        public virtual double bufm { get; set; }
        public virtual double bufl { get; set; }
        public virtual double bufxl { get; set; }
        public virtual double bufxxl { get; set; }
        /// <summary>係数：小/中/大/特大/超特大</summary>
        public virtual int slvs { get; set; }
        public virtual int slvm { get; set; }
        public virtual int slvl { get; set; }
        public virtual int slvxl { get; set; }
        public virtual int slvxxl { get; set; }
        /// <summary>個数：小/中/大/特大/超特大</summary>
        public virtual int cnts { get; set; }
        public virtual int cntm { get; set; }
        public virtual int cntl { get; set; }
        public virtual int cntxl { get; set; }
        public virtual int cntxxl { get; set; }
    }
}