﻿using System;
using Wokhan.Data.Providers.Attributes;
using Wokhan.Data.Providers.Bases;

namespace Wokhan.Data.Providers
{
    public partial class RandomDataProvider
    {
        private class RandomDoubleData
        {
            [ColumnDescription(IsKey = true)]
            public int RowId { get; set; }
            public double Number { get; set; }

            public RandomDoubleData(Random rnd, int i)
            {
                RowId = i;
                Number = rnd.NextDouble();
            }
        }
    }
}
