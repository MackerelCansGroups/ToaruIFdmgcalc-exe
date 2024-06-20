using System;
using System.Collections.Generic;

namespace calc
{
    class Common
    {
        /// <summary>出力</summary>
        private static Logic logic = new Logic();
        private static T_displayDto dto { get; set; }

        public List<T_resultDto> resultLst(T_displayDto dto_)
        {
            dto = dto_;
            int b = defend();
            List<T_resultDto> list = new List<T_resultDto>();
            foreach (T_resultDto i in dto.feslist)
            {
                int a = atk(i.fesm, i.fesl);
                T_resultDto r = new T_resultDto
                {
                    header = i.header,
                    fesm = i.fesm,
                    fesl = i.fesl,
                    output_dmgcri = dmg(a, b, true).ToString(),
                    output_dmg = dmg(a, b, false).ToString(),
                    output_atk = a.ToString(),
                    output_def = b.ToString(),
                    output_anti = anti(a).ToString()
                };
                list.Add(r);
            }
            return list;
        }
        private static int chkSSP(string str)
        {
            if (str.Contains("スキル")) return 1;//スキル
            if (str.Contains("必殺"))   return 2;//必殺
            return 0;//攻撃・連携
        }

        /// <summary>攻</summary>
        private int atk(int fesm_num, int fesl_num)
        {
            // A+B
            double A_ = (double)dto.atkA;
            double B_ = (double)dto.atkB;
            double atk = Math.Floor(A_ * dto.matchBuf) + Math.Floor(B_ * dto.matchBuf);
            // 潜在1
            atk += p1((double)fesm_num, (double)fesl_num);
            // バフ
            atk += buf("ATK", atk, dto.slv);
            // 潜在2
            atk = p2(atk);
            // SP
            atk = bufSP(atk, dto);
            // 可変倍率
            if (dto.atkBonus <= 0) dto.atkBonus = 1;
            atk *= dto.atkBonus;
            return (int)atk;
        }

        /// <summary>潜在1</summary>
        private static double p1(double fesm_num, double fesl_num)
            => Math.Floor(dto.slv * (dto.pm + dto.pl + dto.fuku + dto.shien + dto.fesm * fesm_num + dto.fesl * fesl_num));

        /// <summary>潜在2</summary>
        private static double p2(double atk)
            => Math.Round(atk * (1 + dto.vec + dto.vecm + dto.vecl + dto.lnk + dto.anas + dto.anam));

        /// <summary>防</summary>
        private int defend()
        {
            double d = (double)dto.def;
            d -= buf("DEF", d, dto.slv);
            return (int)Math.Max(d, 0);
        }

        /// <summary>計算</summary>
        private int dmg(int atk_, int def_, bool cri)
        {
            double d = dmgBase(atk_, def_);
            //
            d *= dto.colorBuf;
            d = Math.Ceiling(d);
            d *= dto.superBuf;
            d = Math.Ceiling(d);
            //
            double tmp = d;
            if (cri) {
                d += Math.Ceiling(tmp * 0.5)
                  + buf("CRI_POW", tmp, dto.slv)
                  + buf("CRI_DEF", tmp, dto.slv);
            }
            //
            tmp = d;
            d += buf("REG_Z", tmp, dto.slv);
            if (chkSSP(dto.sp1) > 0) d += buf("REG_SP", tmp, dto.slv);
            //
            d *= dto.partyBuf;
            d = Math.Ceiling(d);
            d *= 1 + dto.chrBonus / 100;
            d = Math.Ceiling(d);
            d *= dto.breakBuf;
            d = Math.Ceiling(d);
            //
            d -= buf("CUT", d, 1);
            return (int)Math.Max(d, 1);
        }

        /// <summary>基礎値</summary>
        private static double dmgBase(int atk, int def)
        {
            if (atk + def == 0) return 0;
            return Math.Ceiling(Math.Pow(atk, 2) / (atk + def));
        }

        // バフ
        public static int buf(string pk, double dmg_, int slv_)
        {
            T_bufDto d = new T_bufDto();
            foreach (T_bufDto i in dto.buflist)
            {
                if (i.pk == pk) d = i;
            }
            return (int)Math.Min(
                Math.Floor(dmg_ * d.bufs) * d.cnts +
                Math.Floor(dmg_ * d.bufm) * d.cntm +
                Math.Floor(dmg_ * d.bufl) * d.cntl +
                Math.Floor(dmg_ * d.bufxl) * d.cntxl +
                Math.Floor(dmg_ * d.bufxxl) * d.cntxxl,
                Math.Floor(dmg_ * d.upper)) +
                (slv_ - 1) * (
                    d.slvs * d.cnts +
                    d.slvm * d.cntm +
                    d.slvl * d.cntl +
                    d.slvxl * d.cntxl +
                    d.slvxxl * d.cntxxl
                );
        }

        private static int bufSP(double atk_, T_displayDto dto)
        {
            T_spDto spdto1 = logic.Loadsp1(dto.sp1);
            T_spDto spdto2 = logic.Loadsp2(dto.sp2);
            T_bufDto b = new T_bufDto();
            if (chkSSP(dto.sp1) == 1) b = logic.Loadbuf("POW_SK");
            if (chkSSP(dto.sp1) == 2) b = logic.Loadbuf("POW_SP");
            double bufSP = logic.Calculate1(spdto1.buf);
            foreach (T_bufDto i in dto.buflist)
            {
                if ((chkSSP(dto.sp1) == 1 && i.pk == "POW_SK") ||
                    (chkSSP(dto.sp1) == 2 && i.pk == "POW_SP"))
                {
                    b.cnts = i.cnts;
                    b.cntm = i.cntm;
                    b.cntl = i.cntl;
                    b.cntxl = i.cntxl;
                    b.cntxxl = i.cntxxl;
                }
            }
            //
            double base_ = atk_ + (dto.slv - 1) *
                (
                    (double)spdto1.slv +
                    b.slvs * b.cnts +
                    b.slvm * b.cntm +
                    b.slvl * b.cntl +
                    b.slvxl * b.cntxl +
                    b.slvxxl * b.cntxxl
                );
            //
            string tokkouStr = spdto2.buf;
            tokkouStr = tokkouStr.Replace("n", dto.num.ToString());
            tokkouStr = tokkouStr.Replace("maxhp", dto.maxhp.ToString());
            tokkouStr = tokkouStr.Replace("hp", dto.hp.ToString());
            double tokkou = 1 + logic.Calculate1(tokkouStr);
            //
            double result = Math.Floor(base_* bufSP * tokkou) +
                Math.Min(
                    Math.Floor(base_ * b.bufs) * b.cnts +
                    Math.Floor(base_ * b.bufm) * b.cntm +
                    Math.Floor(base_ * b.bufl) * b.cntl +
                    Math.Floor(base_ * b.bufxl) * b.cntxl +
                    Math.Floor(base_ * b.bufxxl) * b.cntxxl,
                    Math.Floor(base_ * b.upper));
            return (int)result;
        }

        public static int antibuf_up(string pk, double realdmg_, int slv_, double baseNum)
        {
            T_bufDto d = new T_bufDto();
            foreach (T_bufDto i in dto.buflist)
            {
                if (i.pk == pk) d = i;
            }
            realdmg_ -= (slv_ - 1) * (
                d.slvs * d.cnts +
                d.slvm * d.cntm +
                d.slvl * d.cntl +
                d.slvxl * d.cntxl +
                d.slvxxl * d.cntxxl
                );
            return (int)(realdmg_ / (1 + baseNum + Math.Min(
                d.bufs * d.cnts +
                d.bufm * d.cntm +
                d.bufl * d.cntl +
                d.bufxl * d.cntxl +
                d.bufxxl * d.cntxxl,
                d.upper)));
        }

        public static int antibuf_down(string pk, double realdmg_, int slv_)
        {
            T_bufDto d = new T_bufDto();
            foreach (T_bufDto i in dto.buflist)
            {
                if (i.pk == pk) d = i;
            }
            realdmg_ += (slv_ - 1) * (
                d.slvs * d.cnts +
                d.slvm * d.cntm +
                d.slvl * d.cntl +
                d.slvxl * d.cntxl +
                d.slvxxl * d.cntxxl
                );
            return (int)(realdmg_ / (1 - Math.Min(
                d.bufs * d.cnts +
                d.bufm * d.cntm +
                d.bufl * d.cntl +
                d.bufxl * d.cntxl +
                d.bufxxl * d.cntxxl,
                d.upper)));
        }

        public static int antislv(string pk, double realdmg_, int slv_)
        {
            T_bufDto d = new T_bufDto();
            foreach (T_bufDto i in dto.buflist)
            {
                if (i.pk == pk) d = i;
            }
            realdmg_ -= (slv_ - 1) * (
                d.slvs * d.cnts +
                d.slvm * d.cntm +
                d.slvl * d.cntl +
                d.slvxl * d.cntxl +
                d.slvxxl * d.cntxxl
                );
            return (int)realdmg_;
        }

        private double antiBase(double dmg_, double atk_)
        {
            if (dmg_ == 0) return 0;
            return Math.Max(atk_ * atk_ / dmg_ - atk_, 0);
        }

        private int anti(double atk_)
        {
            double d = dto.realdmg;
            d = antibuf_down("CUT", d, 1);
            d /= Math.Floor(dto.breakBuf);
            d /= Math.Floor(1 + dto.chrBonus / 100);
            d /= Math.Floor(dto.partyBuf);
            //
            if (chkSSP(dto.sp1) > 0) d = antislv("REG_SP", d, dto.slv);
            d = antislv("REG_Z", d, dto.slv);

            double tmp = d;
            if (chkSSP(dto.sp1) > 0) d = antibuf_up("REG_SP", tmp, 1, 0);
            d = antibuf_up("REG_Z", tmp, 1, 0);
            //
            d = antislv("CRI_POW", d, dto.slv);
            d = antislv("CRI_DEF", d, dto.slv);

            tmp = d;
            d = antibuf_up("CRI_POW", tmp, 1, 0.5);
            d = antibuf_up("CRI_DEF", tmp, 1, 0);
            //
            d /= Math.Floor(dto.superBuf);
            d /= Math.Floor(dto.colorBuf);
            d = antiBase(d, atk_);
            return (int)antibuf_down("DEF", d, dto.slv);
        }
    }
}
