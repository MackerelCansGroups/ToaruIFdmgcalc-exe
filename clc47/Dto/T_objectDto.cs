using System;

namespace calc
{
    class T_objectDto
    {
        public T_objectDto() {
            pk = "";
            name = "";
            val = 0;
            chk = false;
        }
        /// <summary>主キー</summary>
        public virtual string pk { get; set; }
        /// <summary>名称</summary>
        public virtual string name { get; set; }
        /// <summary>設定値</summary>
        public virtual double val { get; set; }
        /// <summary>チェックオン/オフ</summary>
        public virtual Boolean chk { get; set; }
    }
}
