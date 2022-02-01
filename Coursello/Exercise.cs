using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Coursello
{
    internal class Exercise
    {
        public Dictionary<string, long> StatesAndTerritories = new Dictionary<string, long>() 
        { 
            { "California", 39538223 },
            { "Texas", 29145505 }, 
            { "Florida", 21538187 }, 
            { "New York", 20201249 }, 
            {"Pennsylvania", 13002700 }, 
            {"Illinois", 12812508 }, 
            {"Ohio", 11799448 }, 
            {"Georgia", 10711908 }, 
            {"North Carolina", 10439388 }, 
            {"Michigan", 10077331}, 
            {"New Jersey", 9288994 }, 
            {"Virginia", 8631393 }, 
            {"Washinton", 7705281 }, 
            {"Arizona", 7151502 }, 
            {"Massachusetts", 7029917 }, 
            {"Tennessee", 6910840 }, 
            {"Indiana", 6785528 }, 
            {"Maryland", 6177224 }, 
            {"Missouri", 6152913 }, 
            {"Wisconsin", 5893718 },
            {"Colorado", 5773714 }, 
            {"Minnesota", 5706494 }, 
            {"South Carolina", 5118425 },
            {"Alabama", 5024279 }, 
            {"Louisiana", 4657757 }, 
            {"Kentucky", 4505836 }, 
            {"Oregon", 4237256 }, 
            {"Oklahoma", 3959353 }, 
            {"Connecticut", 3605944 },
            {"Puerto Rico", 3285874 }, 
            {"Utah", 3271616 }, 
            {"Iowa", 3190369 }, 
            {"Nevada", 3104614 }, 
            {"Arkansas", 3011524 }, 
            {"Mississippi", 2961279 }, 
            {"Kansas", 2937880 }, 
            {"New Mexico", 2117522 },
            {"Nebraska", 1961504 }, 
            {"Idaho", 1839106 }, 
            {"West Virginia", 1793716 }, 
            {"Hawaii", 1455271 }, 
            {"New Hampshire", 1377529 }, 
            {"Maine", 1362359 }, 
            {"Rhode Island", 1097379 }, 
            {"Montana", 1084225 }, 
            {"Delaware", 989948 }, 
            {"South Dakota", 886667 },
            {"North Dakota", 779094 }, 
            {"Alaska", 733391 }, 
            {"District of Columbia", 689545 }, 
            {"Vermont", 643077 }, 
            {"Wyoming", 576851 }, 
            {"Guam", 153836 }, 
            {"U.S. Virgin Islands", 87146 }, 
            {"American Samoa", 49710 }, 
            {"Northern Mariana Islands", 47329 } 
        };

        public double CalculateMedian()
        {
            var toList = StatesAndTerritories.ToList();
            var sorted = toList.OrderBy(kvp => kvp.Value);

            var num1 = StatesAndTerritories["Connecticut"];
            var num2 = StatesAndTerritories["Oklahoma"];

            double sum = num1 + num2;
            double median = sum / 2;
            
            return median;
        }

        public long CalculateMean()
        {
            long sum = 0;

            foreach (KeyValuePair<string, long> kvp in StatesAndTerritories)
            {
                sum += kvp.Value;              
            }

            long mean = sum / 56;
            return mean;
        }

        public double CalculateStandardDeviation()
        {
            long sum = 0;

            foreach (KeyValuePair<string, long> kvp in StatesAndTerritories)
            {
                sum += kvp.Value;
            }

            long mean = sum / 56;

            long subtractedVal = 0;
            long squaredVal = 0;
            double newSum = 0;
            List<long> subtractedVals = new List<long>();
            List<long> squaredVals = new List<long>();

            foreach (KeyValuePair<string, long> kvp in StatesAndTerritories)
            {
                subtractedVal = kvp.Value - mean;
                subtractedVals.Add(subtractedVal);
            }

            foreach (long val in subtractedVals)
            {
                squaredVal = val * val;

                squaredVals.Add(squaredVal);
            }

            foreach (long val in squaredVals)
            {
                newSum += val;
            }

            double newMean = (double)(newSum / 56);
            double standardDeviation = Math.Sqrt((double)newMean);


            return standardDeviation;

        }

        public long GetPopulation(string stateOrTerritory)
        {
            var population = StatesAndTerritories[stateOrTerritory];
            return population;
        }

        public void ExecuteFirstProblem()
        {
            Console.WriteLine($"Median: {CalculateMedian()}");
            Console.WriteLine($"Mean: {CalculateMean()}");
            Console.WriteLine($"Standard Deviation: {CalculateStandardDeviation()}");
        }

        public void ExecuteSecondProblem(string stateOrTerritory)
        {
            Console.WriteLine($"Population of {stateOrTerritory}: {GetPopulation(stateOrTerritory)}");
        }
    }
}
