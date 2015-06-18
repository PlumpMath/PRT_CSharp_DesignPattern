﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactroy
{
    public interface IBeverageProvide
    {
        // 加料
        void AddMaterial();
        // 沖泡
        void Brew();
        // 裝杯
        void PouredCup();
    }
}
