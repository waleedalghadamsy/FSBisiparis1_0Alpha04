﻿using BisiparişÇekirdek.Valıklar.Esansiyel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BisiparişÇekirdek.Valıklar.Güvenlik
{
    public class KullanıcıYüzüBileşen : TemelVarlık
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        #endregion

        #region Properties (Özellikler)
        [Required, StringLength(100)]
        public string İsim { get; set; }
        public List<YüzüBileşenİzin> YüzüBileşenİzinler { get; set; }
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        #endregion
    }
}
