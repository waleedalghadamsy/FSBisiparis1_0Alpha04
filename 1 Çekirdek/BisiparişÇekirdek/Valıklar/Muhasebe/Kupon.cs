﻿using BisiparişÇekirdek.Valıklar.Esansiyel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BisiparişÇekirdek.Valıklar.Muhasebe
{
    public class Kupon : TemelVarlık
    {
        #region Data Members (Veri Üyeler)
        #endregion

        #region Constructors (Oluşturucular) (Yapıcılar)
        #endregion

        #region Properties (Özellikler)
        public float Kıymet { get; set; }
        public byte İndirimOranı { get; set; }
        public DateTime GeçerlilikSüresi { get; set; }
        public string Şart { get; set; }
        #endregion

        #region Methods (Metotlar) (Yöntemler)
        #endregion
    }
}
