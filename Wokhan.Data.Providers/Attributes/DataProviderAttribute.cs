﻿using System;

namespace Wokhan.Data.Providers.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DataProviderAttribute : Attribute
    {
        public string Category;
        public string Name;
        public string Icon;
        public string Copyright;
        public string Description;
        public bool IsDirectlyBindable;

        public DataProviderAttribute() { }
    }
}