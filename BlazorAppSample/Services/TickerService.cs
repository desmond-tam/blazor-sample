using BlazorAppSample.Models;
using BlazorBootstrap;
using Newtonsoft.Json.Linq;

namespace BlazorAppSample.Services
{
    internal class TickerService : ITickerService
    {
        private const string _data = @"[
    {
        ""TradeDate"": ""2025-06-17T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6012.14990234375,
        ""Close"": 5982.72021484375,
        ""High"": 6023.25,
        ""Low"": 5974.7998046875,
        ""Volume"": 4955700000
    },
    {
        ""TradeDate"": ""2025-06-18T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 5987.93017578125,
        ""Close"": 5980.8701171875,
        ""High"": 6018.25,
        ""Low"": 5971.89013671875,
        ""Volume"": 5106470000
    },
    {
        ""TradeDate"": ""2025-06-20T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 5999.669921875,
        ""Close"": 5967.83984375,
        ""High"": 6018.2001953125,
        ""Low"": 5952.56005859375,
        ""Volume"": 7451500000
    },
    {
        ""TradeDate"": ""2025-06-23T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 5969.669921875,
        ""Close"": 6025.169921875,
        ""High"": 6028.77001953125,
        ""Low"": 5943.22998046875,
        ""Volume"": 5597000000
    },
    {
        ""TradeDate"": ""2025-06-24T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6061.2099609375,
        ""Close"": 6092.18017578125,
        ""High"": 6101.759765625,
        ""Low"": 6059.25,
        ""Volume"": 5443690000
    },
    {
        ""TradeDate"": ""2025-06-25T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6104.22998046875,
        ""Close"": 6092.16015625,
        ""High"": 6108.509765625,
        ""Low"": 6080.08984375,
        ""Volume"": 5171110000
    },
    {
        ""TradeDate"": ""2025-06-26T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6112.08984375,
        ""Close"": 6141.02001953125,
        ""High"": 6146.52001953125,
        ""Low"": 6107.27001953125,
        ""Volume"": 5308140000
    },
    {
        ""TradeDate"": ""2025-06-27T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6150.7001953125,
        ""Close"": 6173.06982421875,
        ""High"": 6187.68017578125,
        ""Low"": 6132.35009765625,
        ""Volume"": 7889350000
    },
    {
        ""TradeDate"": ""2025-06-30T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6193.35986328125,
        ""Close"": 6204.9501953125,
        ""High"": 6215.080078125,
        ""Low"": 6174.97021484375,
        ""Volume"": 5782900000
    },
    {
        ""TradeDate"": ""2025-07-01T04:00:00Z"",
        ""Symbol"": ""^GSPC"",
        ""Index"": ""S&P 500"",
        ""Open"": 6187.25,
        ""Close"": 6198.009765625,
        ""High"": 6210.77978515625,
        ""Low"": 6177.97021484375,
        ""Volume"": 6275310000
    },
    {
        ""TradeDate"": ""2025-06-17T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 42358.62109375,
        ""Close"": 42215.80078125,
        ""High"": 42530.828125,
        ""Low"": 42132.6484375,
        ""Volume"": 423070000
    },
    {
        ""TradeDate"": ""2025-06-18T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 42236.03125,
        ""Close"": 42171.66015625,
        ""High"": 42510.0703125,
        ""Low"": 42118.23046875,
        ""Volume"": 485440000
    },
    {
        ""TradeDate"": ""2025-06-20T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 42291.08984375,
        ""Close"": 42206.8203125,
        ""High"": 42432.19140625,
        ""Low"": 42089.98828125,
        ""Volume"": 859840000
    },
    {
        ""TradeDate"": ""2025-06-23T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 42178.55078125,
        ""Close"": 42581.78125,
        ""High"": 42609.46875,
        ""Low"": 41981.140625,
        ""Volume"": 496750000
    },
    {
        ""TradeDate"": ""2025-06-24T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 42807.12890625,
        ""Close"": 43089.01953125,
        ""High"": 43183.48046875,
        ""Low"": 42794.078125,
        ""Volume"": 516060000
    },
    {
        ""TradeDate"": ""2025-06-25T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 43130.328125,
        ""Close"": 42982.4296875,
        ""High"": 43130.328125,
        ""Low"": 42871.5,
        ""Volume"": 527460000
    },
    {
        ""TradeDate"": ""2025-06-26T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 43084.0703125,
        ""Close"": 43386.83984375,
        ""High"": 43430.98828125,
        ""Low"": 43084.0703125,
        ""Volume"": 536710000
    },
    {
        ""TradeDate"": ""2025-06-27T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 43505.6015625,
        ""Close"": 43819.26953125,
        ""High"": 43966.37109375,
        ""Low"": 43505.6015625,
        ""Volume"": 921330000
    },
    {
        ""TradeDate"": ""2025-06-30T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 44020.66015625,
        ""Close"": 44094.76953125,
        ""High"": 44138.69140625,
        ""Low"": 43889.16015625,
        ""Volume"": 623630000
    },
    {
        ""TradeDate"": ""2025-07-01T04:00:00Z"",
        ""Symbol"": ""^DJI"",
        ""Index"": ""Dow Jones"",
        ""Open"": 44061.48828125,
        ""Close"": 44494.94140625,
        ""High"": 44604.1484375,
        ""Low"": 44013.5390625,
        ""Volume"": 593600000
    },
    {
        ""TradeDate"": ""2025-06-17T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 19627.080078125,
        ""Close"": 19521.08984375,
        ""High"": 19666.560546875,
        ""Low"": 19485.439453125,
        ""Volume"": 8519930000
    },
    {
        ""TradeDate"": ""2025-06-18T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 19526.919921875,
        ""Close"": 19546.26953125,
        ""High"": 19660.76953125,
        ""Low"": 19489.560546875,
        ""Volume"": 7818790000
    },
    {
        ""TradeDate"": ""2025-06-20T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 19639.41015625,
        ""Close"": 19447.41015625,
        ""High"": 19696.109375,
        ""Low"": 19380.580078125,
        ""Volume"": 9969140000
    },
    {
        ""TradeDate"": ""2025-06-23T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 19427.009765625,
        ""Close"": 19630.970703125,
        ""High"": 19643.69921875,
        ""Low"": 19334.98046875,
        ""Volume"": 9088000000
    },
    {
        ""TradeDate"": ""2025-06-24T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 19809.619140625,
        ""Close"": 19912.529296875,
        ""High"": 19946.720703125,
        ""Low"": 19795.2890625,
        ""Volume"": 8330090000
    },
    {
        ""TradeDate"": ""2025-06-25T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 20013.94921875,
        ""Close"": 19973.55078125,
        ""High"": 20052.779296875,
        ""Low"": 19918.080078125,
        ""Volume"": 8256120000
    },
    {
        ""TradeDate"": ""2025-06-26T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 20062.189453125,
        ""Close"": 20167.91015625,
        ""High"": 20187.150390625,
        ""Low"": 19982.48046875,
        ""Volume"": 8383380000
    },
    {
        ""TradeDate"": ""2025-06-27T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 20217.259765625,
        ""Close"": 20273.4609375,
        ""High"": 20311.509765625,
        ""Low"": 20095.05078125,
        ""Volume"": 10951070000
    },
    {
        ""TradeDate"": ""2025-06-30T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 20360.150390625,
        ""Close"": 20369.73046875,
        ""High"": 20418.310546875,
        ""Low"": 20266.359375,
        ""Volume"": 8220420000
    },
    {
        ""TradeDate"": ""2025-07-01T04:00:00Z"",
        ""Symbol"": ""^IXIC"",
        ""Index"": ""NASDAQ"",
        ""Open"": 20290.609375,
        ""Close"": 20202.890625,
        ""High"": 20339.05078125,
        ""Low"": 20105.41015625,
        ""Volume"": 8631710000
    },
    {
        ""TradeDate"": ""2025-06-17T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8834.0,
        ""Close"": 8843.5,
        ""High"": 8858.599609375,
        ""Low"": 8820.400390625,
        ""Volume"": 657935000
    },
    {
        ""TradeDate"": ""2025-06-18T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8843.5,
        ""Close"": 8791.7998046875,
        ""High"": 8844.099609375,
        ""Low"": 8788.7998046875,
        ""Volume"": 481335200
    },
    {
        ""TradeDate"": ""2025-06-19T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8791.7998046875,
        ""Close"": 8774.7001953125,
        ""High"": 8847.2998046875,
        ""Low"": 8772.2998046875,
        ""Volume"": 1831139500
    },
    {
        ""TradeDate"": ""2025-06-22T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8774.7001953125,
        ""Close"": 8758.0,
        ""High"": 8787.099609375,
        ""Low"": 8741.400390625,
        ""Volume"": 611232900
    },
    {
        ""TradeDate"": ""2025-06-23T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8758.0,
        ""Close"": 8759.0,
        ""High"": 8831.900390625,
        ""Low"": 8758.0,
        ""Volume"": 1063635300
    },
    {
        ""TradeDate"": ""2025-06-24T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8759.0,
        ""Close"": 8718.7998046875,
        ""High"": 8792.400390625,
        ""Low"": 8716.2001953125,
        ""Volume"": 699302400
    },
    {
        ""TradeDate"": ""2025-06-25T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8718.7998046875,
        ""Close"": 8735.599609375,
        ""High"": 8757.099609375,
        ""Low"": 8707.7001953125,
        ""Volume"": 768435000
    },
    {
        ""TradeDate"": ""2025-06-26T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8735.599609375,
        ""Close"": 8798.900390625,
        ""High"": 8798.900390625,
        ""Low"": 8735.599609375,
        ""Volume"": 711522100
    },
    {
        ""TradeDate"": ""2025-06-29T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8798.900390625,
        ""Close"": 8761.0,
        ""High"": 8818.400390625,
        ""Low"": 8761.0,
        ""Volume"": 713304300
    },
    {
        ""TradeDate"": ""2025-06-30T23:00:00Z"",
        ""Symbol"": ""^FTSE"",
        ""Index"": ""FTSE 100"",
        ""Open"": 8761.0,
        ""Close"": 8785.2998046875,
        ""High"": 8790.7998046875,
        ""Low"": 8726.900390625,
        ""Volume"": 766020100
    },
    {
        ""TradeDate"": ""2025-06-18T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 38858.51953125,
        ""Close"": 38488.33984375,
        ""High"": 38870.55078125,
        ""Low"": 38488.33984375,
        ""Volume"": 89300000
    },
    {
        ""TradeDate"": ""2025-06-19T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 38472.25,
        ""Close"": 38403.23046875,
        ""High"": 38646.16015625,
        ""Low"": 38362.5390625,
        ""Volume"": 183900000
    },
    {
        ""TradeDate"": ""2025-06-22T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 38260.69140625,
        ""Close"": 38354.08984375,
        ""High"": 38368.21875,
        ""Low"": 38026.3203125,
        ""Volume"": 95800000
    },
    {
        ""TradeDate"": ""2025-06-23T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 38779.1796875,
        ""Close"": 38790.55859375,
        ""High"": 38990.109375,
        ""Low"": 38665.609375,
        ""Volume"": 100800000
    },
    {
        ""TradeDate"": ""2025-06-24T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 38904.1796875,
        ""Close"": 38942.0703125,
        ""High"": 38944.76953125,
        ""Low"": 38711.109375,
        ""Volume"": 102900000
    },
    {
        ""TradeDate"": ""2025-06-25T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 39072.140625,
        ""Close"": 39584.578125,
        ""High"": 39615.58984375,
        ""Low"": 39056.140625,
        ""Volume"": 123600000
    },
    {
        ""TradeDate"": ""2025-06-26T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 39866.359375,
        ""Close"": 40150.7890625,
        ""High"": 40267.83984375,
        ""Low"": 39847.30859375,
        ""Volume"": 156100000
    },
    {
        ""TradeDate"": ""2025-06-29T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 40550.7890625,
        ""Close"": 40487.390625,
        ""High"": 40852.5390625,
        ""Low"": 40322.5390625,
        ""Volume"": 143900000
    },
    {
        ""TradeDate"": ""2025-06-30T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 40340.640625,
        ""Close"": 39986.328125,
        ""High"": 40345.87109375,
        ""Low"": 39885.37890625,
        ""Volume"": 124000000
    },
    {
        ""TradeDate"": ""2025-07-01T15:00:00Z"",
        ""Symbol"": ""^N225"",
        ""Index"": ""Nikkei 225"",
        ""Open"": 39631.171875,
        ""Close"": 39678.0390625,
        ""High"": 39754.0,
        ""Low"": 39444.69921875,
        ""Volume"": 0
    },
    {
        ""TradeDate"": ""2025-06-17T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 23859.55078125,
        ""Close"": 23710.689453125,
        ""High"": 23880.240234375,
        ""Low"": 23631.48046875,
        ""Volume"": 3264300000
    },
    {
        ""TradeDate"": ""2025-06-18T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 23620.01953125,
        ""Close"": 23237.740234375,
        ""High"": 23653.55078125,
        ""Low"": 23185.580078125,
        ""Volume"": 3871900000
    },
    {
        ""TradeDate"": ""2025-06-19T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 23291.400390625,
        ""Close"": 23530.48046875,
        ""High"": 23538.630859375,
        ""Low"": 23291.400390625,
        ""Volume"": 4801500000
    },
    {
        ""TradeDate"": ""2025-06-22T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 23335.509765625,
        ""Close"": 23689.130859375,
        ""High"": 23689.130859375,
        ""Low"": 23272.75,
        ""Volume"": 3225900000
    },
    {
        ""TradeDate"": ""2025-06-23T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 23832.73046875,
        ""Close"": 24177.0703125,
        ""High"": 24229.2109375,
        ""Low"": 23832.73046875,
        ""Volume"": 3995700000
    },
    {
        ""TradeDate"": ""2025-06-24T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 24327.8203125,
        ""Close"": 24474.669921875,
        ""High"": 24533.390625,
        ""Low"": 24287.859375,
        ""Volume"": 3724300000
    },
    {
        ""TradeDate"": ""2025-06-25T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 24345.2890625,
        ""Close"": 24325.400390625,
        ""High"": 24411.48046875,
        ""Low"": 24235.5390625,
        ""Volume"": 3258500000
    },
    {
        ""TradeDate"": ""2025-06-26T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 24451.189453125,
        ""Close"": 24284.150390625,
        ""High"": 24471.529296875,
        ""Low"": 24194.849609375,
        ""Volume"": 4341600000
    },
    {
        ""TradeDate"": ""2025-06-29T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 24274.91015625,
        ""Close"": 24072.279296875,
        ""High"": 24274.91015625,
        ""Low"": 24064.259765625,
        ""Volume"": 3775900000
    },
    {
        ""TradeDate"": ""2025-07-01T16:00:00Z"",
        ""Symbol"": ""^HSI"",
        ""Index"": ""Hang Seng"",
        ""Open"": 24304.310546875,
        ""Close"": 24243.91015625,
        ""High"": 24372.69921875,
        ""Low"": 24122.5703125,
        ""Volume"": 0
    },
    {
        ""TradeDate"": ""2025-06-18T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8531.2001953125,
        ""Close"": 8523.7001953125,
        ""High"": 8540.2998046875,
        ""Low"": 8504.7001953125,
        ""Volume"": 755500
    },
    {
        ""TradeDate"": ""2025-06-19T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8523.7001953125,
        ""Close"": 8505.5,
        ""High"": 8526.5,
        ""Low"": 8462.7001953125,
        ""Volume"": 1873100
    },
    {
        ""TradeDate"": ""2025-06-22T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8505.5,
        ""Close"": 8474.900390625,
        ""High"": 8505.5,
        ""Low"": 8421.099609375,
        ""Volume"": 619800
    },
    {
        ""TradeDate"": ""2025-06-23T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8474.900390625,
        ""Close"": 8555.5,
        ""High"": 8574.0,
        ""Low"": 8474.900390625,
        ""Volume"": 685400
    },
    {
        ""TradeDate"": ""2025-06-24T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8555.5,
        ""Close"": 8559.2001953125,
        ""High"": 8577.2998046875,
        ""Low"": 8547.2001953125,
        ""Volume"": 645700
    },
    {
        ""TradeDate"": ""2025-06-25T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8559.2001953125,
        ""Close"": 8550.7998046875,
        ""High"": 8560.400390625,
        ""Low"": 8533.0,
        ""Volume"": 704100
    },
    {
        ""TradeDate"": ""2025-06-26T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8551.099609375,
        ""Close"": 8514.2001953125,
        ""High"": 8605.7001953125,
        ""Low"": 8514.2001953125,
        ""Volume"": 819600
    },
    {
        ""TradeDate"": ""2025-06-29T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8514.2001953125,
        ""Close"": 8542.2998046875,
        ""High"": 8576.7001953125,
        ""Low"": 8514.2001953125,
        ""Volume"": 822400
    },
    {
        ""TradeDate"": ""2025-06-30T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8541.099609375,
        ""Close"": 8541.099609375,
        ""High"": 8541.099609375,
        ""Low"": 8541.099609375,
        ""Volume"": 0
    },
    {
        ""TradeDate"": ""2025-07-01T14:00:00Z"",
        ""Symbol"": ""^AXJO"",
        ""Index"": ""ASX 200"",
        ""Open"": 8541.099609375,
        ""Close"": 8574.099609375,
        ""High"": 8585.599609375,
        ""Low"": 8536.7001953125,
        ""Volume"": 0
    },
    {
        ""TradeDate"": ""2025-06-18T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8757.900390625,
        ""Close"": 8741.400390625,
        ""High"": 8761.400390625,
        ""Low"": 8727.0,
        ""Volume"": 1370483800
    },
    {
        ""TradeDate"": ""2025-06-19T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8741.400390625,
        ""Close"": 8723.5,
        ""High"": 8744.0,
        ""Low"": 8683.7998046875,
        ""Volume"": 2692531000
    },
    {
        ""TradeDate"": ""2025-06-22T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8723.5,
        ""Close"": 8688.0,
        ""High"": 8723.5,
        ""Low"": 8633.2001953125,
        ""Volume"": 1131080100
    },
    {
        ""TradeDate"": ""2025-06-23T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8688.0,
        ""Close"": 8774.7998046875,
        ""High"": 8791.099609375,
        ""Low"": 8688.0,
        ""Volume"": 1170886100
    },
    {
        ""TradeDate"": ""2025-06-24T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8774.7998046875,
        ""Close"": 8779.900390625,
        ""High"": 8794.900390625,
        ""Low"": 8766.5,
        ""Volume"": 1260368400
    },
    {
        ""TradeDate"": ""2025-06-25T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8779.900390625,
        ""Close"": 8773.599609375,
        ""High"": 8781.599609375,
        ""Low"": 8754.2998046875,
        ""Volume"": 1312034600
    },
    {
        ""TradeDate"": ""2025-06-26T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8773.599609375,
        ""Close"": 8743.599609375,
        ""High"": 8830.900390625,
        ""Low"": 8743.599609375,
        ""Volume"": 1528842000
    },
    {
        ""TradeDate"": ""2025-06-29T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8743.599609375,
        ""Close"": 8773.0,
        ""High"": 8804.099609375,
        ""Low"": 8743.599609375,
        ""Volume"": 1529898700
    },
    {
        ""TradeDate"": ""2025-06-30T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8773.0,
        ""Close"": 8772.0,
        ""High"": 8804.5,
        ""Low"": 8770.400390625,
        ""Volume"": 1327714600
    },
    {
        ""TradeDate"": ""2025-07-01T14:00:00Z"",
        ""Symbol"": ""^AORD"",
        ""Index"": ""All Ordinaries"",
        ""Open"": 8772.0,
        ""Close"": 8805.400390625,
        ""High"": 8816.2001953125,
        ""Low"": 8771.2001953125,
        ""Volume"": 0
    },
    {
        ""TradeDate"": ""2025-06-17T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.179999828338623,
        ""Close"": 4.170000076293945,
        ""High"": 4.239999771118164,
        ""Low"": 4.130000114440918,
        ""Volume"": 41536150
    },
    {
        ""TradeDate"": ""2025-06-18T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.170000076293945,
        ""Close"": 4.03000020980835,
        ""High"": 4.170000076293945,
        ""Low"": 3.9600000381469727,
        ""Volume"": 40660001
    },
    {
        ""TradeDate"": ""2025-06-19T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.03000020980835,
        ""Close"": 4.0,
        ""High"": 4.059999942779541,
        ""Low"": 3.9700000286102295,
        ""Volume"": 25588560
    },
    {
        ""TradeDate"": ""2025-06-22T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.050000190734863,
        ""Close"": 4.059999942779541,
        ""High"": 4.090000152587891,
        ""Low"": 4.010000228881836,
        ""Volume"": 20083000
    },
    {
        ""TradeDate"": ""2025-06-23T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.0,
        ""Close"": 4.039999961853027,
        ""High"": 4.059999942779541,
        ""Low"": 3.950000047683716,
        ""Volume"": 35282755
    },
    {
        ""TradeDate"": ""2025-06-24T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.039999961853027,
        ""Close"": 4.170000076293945,
        ""High"": 4.179999828338623,
        ""Low"": 4.039999961853027,
        ""Volume"": 49702640
    },
    {
        ""TradeDate"": ""2025-06-25T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.179999828338623,
        ""Close"": 4.239999771118164,
        ""High"": 4.329999923706055,
        ""Low"": 4.139999866485596,
        ""Volume"": 84515500
    },
    {
        ""TradeDate"": ""2025-06-26T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.260000228881836,
        ""Close"": 4.260000228881836,
        ""High"": 4.369999885559082,
        ""Low"": 4.230000019073486,
        ""Volume"": 44133347
    },
    {
        ""TradeDate"": ""2025-06-29T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.300000190734863,
        ""Close"": 4.429999828338623,
        ""High"": 4.510000228881836,
        ""Low"": 4.289999961853027,
        ""Volume"": 103291580
    },
    {
        ""TradeDate"": ""2025-07-01T16:00:00Z"",
        ""Symbol"": ""2357.HK"",
        ""Index"": ""AviChina"",
        ""Open"": 4.429999828338623,
        ""Close"": 4.409999847412109,
        ""High"": 4.460000038146973,
        ""Low"": 4.300000190734863,
        ""Volume"": 30528287
    }
]";

        public async Task<IEnumerable<TickerModel>> GetPage(TickerSearchModel? search, IEnumerable<SortingItem<TickerModel>>? sortings, int page, int pageSize)
        {
            // Parse the JSON data into a list of TickerModel
            var list = JArray.Parse(_data).ToObject<List<TickerModel>>() ?? new List<TickerModel>();

            if (search?.Index != null)
            {
                list = list.Where(x => x.Index == search.Index).ToList();
            }

            if (sortings != null && sortings.Count() > 0)
            {
                var type = typeof(TickerModel);
                var sortproperty = type.GetProperty(sortings.First().SortString);
                list = list.GetSortedList<TickerModel>(sortings.First().SortString, sortings.First().SortDirection.ToString());
            }

            // Perform pagination
            var records = list.Skip((page - 1) * pageSize).Take(pageSize);

            // Return the result as a completed task
            return await Task.FromResult(records.AsEnumerable());
        }

        public async Task<int> GetTotalRecords(TickerSearchModel? search)
        {
            var list = JArray.Parse(_data).ToObject<List<TickerModel>>() ?? new List<TickerModel>();
            if (search?.Index != null)
            {
                return await Task.FromResult(list.Where(x => x.Index == search.Index).ToList().Count);
            }
            return await Task.FromResult(list.Count);
        }

        public async Task<IEnumerable<AutoCompleteModel>> GetAllIndexes()
        {
            List<TickerModel> list = JArray.Parse(_data).ToObject<List<TickerModel>>() ?? new List<TickerModel>();
            var groups = list.Select(x => x.Index).GroupBy(x => x).Select(x => new AutoCompleteModel() { Value = x.Key, Name = x.Key }).ToList();

            // Perform pagination
            return await Task.FromResult(groups.AsEnumerable());
        }
    }
}
