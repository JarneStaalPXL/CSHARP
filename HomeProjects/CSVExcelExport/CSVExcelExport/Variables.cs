using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVExcelExport
{
    public class Variables
    {  
        public string StockName { get; set; }
        public float AmountOfStockBought { get; set; }
        public float BoughtAtStockPrice { get; set; }

        public List<string> StocksList = new List<string>();
        //{"KBCA","INGA","EURN","SOLB","BPOST","COFB","KIN","PROX",
        //"AAPL","MSFT","AMZN",
        //"GOOG","GOOGL","FB","BABA","TSLA","JPM","WMT","MA","NVDA","BAC","HD","PYPL",
        //"INTC","CMCSA","ASML","NFLX","VZ","KO","ADBE","NKE","PFE","CVX","ORCL","MRK",
        //"PEP","AVGO","ACN","SHOP","BA","BMY","UNP"};

        public List<string> EuropeanStockList = new List<string>();
        public List<string> AmericanStockList = new List<string>();

        public List<string> BackupEuropeanStocksList = new List<string>() 
        { "KBCA", "INGA", "EURN", "SOLB", "BPOST", "COFB", "KIN", "PROX" };
        public List<string> BackupAmericanStocksList = new List<string>() 
        { "AAPL", "MSFT", "AMZN", "GOOG", "GOOGL", "FB", "BABA", "TSLA", "JPM", "WMT",
            "MA", "NVDA", "BAC", "HD", "PYPL", "INTC", "CMCSA", "ASML", "NFLX", "VZ", "KO",
            "ADBE", "NKE", "PFE", "CVX", "ORCL", "MRK", "PEP", "AVGO", "ACN", "SHOP", "BA", "BMY", "UNP" };

        public  string Currency { get; set; }
        public  float TotalPrice() => AmountOfStockBought * BoughtAtStockPrice;
    }
}
