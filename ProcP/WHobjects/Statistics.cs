using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
	public class Statistics
	{
        public DateTime st { get; set; } //start time of the simulation itself
        public DateTime en { get; set; } // end time of the simulation itself
        public DateTime realst { get; set; } //when the first order arrives
        public DateTime realen { get; set; } //whan the last order is placed
        public int NrOrders { get; set; }//Number of orders completet during the simulation
        public int NrAgv { get; set; } //Number of avgs used in this simulation

        public TimeSpan CalculateSimulationTime()
        {

            return en.Subtract(st);
        }
        public double GetTimePerOrders()
        {
            double tpo = Convert.ToInt32(CalculateSimulationTime()) / NrOrders;
            return Math.Round(tpo, 2);
        }
        public double GetOrdersPerAvg()
        {
            double opa = NrOrders / NrAgv;
            return Math.Round(opa, 2);
        }
    }
}
