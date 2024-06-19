using System;

namespace calc
{
    class T_resultDto
    {
        public T_resultDto()
        {
            header = "";
            fesm = 0;
            fesl = 0;
        }
        /// <summary>ヘッダー</summary>
        public virtual string header { get; set; }
        /// <summary>設定値</summary>
        public virtual int fesm { get; set; }
        public virtual int fesl { get; set; }
        /// <summary>計算結果</summary>
        public virtual string output_atk { get; set; }
        public virtual string output_def { get; set; }
        public virtual string output_dmg { get; set; }
        public virtual string output_dmgcri { get; set; }
        public virtual string output_anti { get; set; }
    }
}
