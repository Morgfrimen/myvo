﻿namespace WpfApp.Models.GPZCurrentYear_Legasy
{
    public sealed class SapPresent
    {
        public CountAndSum First { get; set; }
        public CountAndSum Second { get; set; }

        public SapPresent(CountAndSum first, CountAndSum second)
        {
            First = first;
            Second = second;
        }

        public SapPresent() { }
    }
}