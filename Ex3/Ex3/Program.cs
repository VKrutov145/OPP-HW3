using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Converter
    {
        public Converter(double newDollarRate, double newEuroRate)
        {
            if (newDollarRate == 0 || newEuroRate == 0)
            {
                //throw new System.Exception();
            } else
            {
                DollarRate = newDollarRate;
                EuroRate = newEuroRate;
            }
        }
        public double GrnToUsd(double grnAmount)
        {
            return grnAmount / DollarRate;
        }
        public double GrnToEur(double grnAmount)
        {
            return grnAmount / EuroRate;
        }
        public double EurToGrn(double eurAmount)
        {
            return eurAmount * EuroRate;
        }
        public double UsdToGrn(double usdAmount)
        {
            return usdAmount * DollarRate;
        }
        private double DollarRate;
        private double EuroRate;
    }

    class Program
    {
        static void Main(string[] args) 
        {
            double GrnAmount = 300100;
            double EurAmount = 20013;
            double UsdAmount = 172;
            
            Converter UsdEurConverter = new Converter(27.567, 33.128);
            
            Console.WriteLine("{0} GRN are equal to {1} USD", GrnAmount,
                Convert.ToDecimal(UsdEurConverter.GrnToUsd(GrnAmount)).ToString("#,##0.00"));
            Console.WriteLine("{0} GRN are equal to {1} EUR", GrnAmount,
                Convert.ToDecimal(UsdEurConverter.GrnToEur(GrnAmount)).ToString("#,##0.00"));
            
            Console.WriteLine("{0} USD are equal to {1} GRN", UsdAmount,
                Convert.ToDecimal(UsdEurConverter.UsdToGrn(UsdAmount)).ToString("#,##0.00"));
            Console.WriteLine("{0} EUR are equal to {1} GRN", EurAmount,
                Convert.ToDecimal(UsdEurConverter.EurToGrn(EurAmount)).ToString("#,##0.00"));
        }
    }
}
