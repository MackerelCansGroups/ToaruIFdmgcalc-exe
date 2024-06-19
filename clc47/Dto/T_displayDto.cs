using System;
using System.Collections.Generic;

namespace calc
{
    class T_displayDto
    {
        /// <summary>画面値および、DB設定値に関するDTO</summary>
        // textBox(画面値)
        public virtual int slv { get; set; }
        public virtual int atkA { get; set; }
        public virtual int atkB { get; set; }
        public virtual int def { get; set; }
        public virtual int hp { get; set; }
        public virtual int maxhp { get; set; }
        public virtual double atkBonus { get; set; }
        public virtual double chrBonus { get; set; }
        public virtual double realdmg { get; set; }
        // comboBox(DB値)
        public virtual double colorBuf { get; set; }
        public virtual double superBuf { get; set; }
        public virtual double partyBuf { get; set; }
        // comboBox(画面値)
        public virtual string sp1 { get; set; }
        public virtual string sp2 { get; set; }
        // trackBar(画面値)
        public virtual int num { get; set; }
        // checkBox(DB値)
        public virtual double matchBuf { get; set; }
        public virtual double pm { get; set; }
        public virtual double pl { get; set; }
        public virtual double fuku { get; set; }
        public virtual double shien { get; set; }
        public virtual double fesm { get; set; }
        public virtual double fesl { get; set; }
        public virtual double vec { get; set; }
        public virtual double vecm { get; set; }
        public virtual double vecl { get; set; }
        public virtual double lnk { get; set; }
        public virtual double anas { get; set; }
        public virtual double anam { get; set; }
        public virtual double breakBuf { get; set; }
        public virtual List<T_bufDto> buflist { get; set; }
        public virtual List<T_resultDto> feslist { get; set; }
        public virtual List<T_objectDto> txt { get; set; }
        public virtual List<T_objectDto> chk { get; set; }
        public virtual List<T_objectDto> idx { get; set; }
    }
}
