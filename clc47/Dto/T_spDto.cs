using System;

namespace calc
{
    class T_spDto
    {
        public T_spDto()
        {
            pk = "";
            name = "";
            buf = "";
            slv = 0;
        }
        /// <summary>主キー</summary>
        public virtual string pk { get; set; }
        /// <summary>名称</summary>
        public virtual string name { get; set; }
        /// <summary>倍率</summary>
        public virtual string buf { get; set; }
        /// <summary>必殺係数</summary>
        public virtual int slv { get; set; }
    }
}