using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlxParser.GetHtml
{
    class GetHtmlParse : IDisposable
    {
        private List<string> DataList { get; set; }

        private List<string> ContentCollection { get; set; }

        private List<string> AdsCollection { get; set; }

        private List<string> PricesCollection { get; set; }

        private List<string> LocationCollection { get; set; }

        private List<string> PublishingTimeCollection { get; set; }

        private List<string> IndividualAdsUrlsCollection { get; set; }

        private List<string> IndividualAdsNamesCollection { get; set; }

        private string _getBodyHtml { get; set; }

        public string getPhoneValue { get; private set; }

        public string setParseLink { private get; set; }

        private string getId { get; set; }

        private HttpWebResponse Response { get; set; }

        public ProgressBar ProgressBarFromViewAds { get; set; }

        public GetHtmlParse()
        {
            DataList = new List<string>();
            ContentCollection = new List<string>();
            AdsCollection = new List<string>();
            ProgressBarFromViewAds = new ProgressBar();
            PricesCollection = new List<string>();
            LocationCollection = new List<string>();
            PublishingTimeCollection = new List<string>();
            IndividualAdsUrlsCollection = new List<string>();
            IndividualAdsNamesCollection = new List<string>();
        }

        public async void StartRunning(RichTextBox richTextBox, ListBox listBox, ProgressBar progressBar)
        {
            //  await GetHtmlCode();
            //   GetPhoneToken();

           
            //GetTopAnnouncements();
            //var orders = dataUrl.OrderBy(t => t);
            //var withDistinct = dataUrl.Distinct().OrderBy(t => t);
            //List<int> testsd = new List<int>();

            //foreach (var item in withDistinct)
            //{
            //    testsd.Add(item);
            //}

            //var fixedRelease = idSets.Distinct().ToArray();

            //for (int i = 0; i < fixedRelease.Length; i++)
            //{
            //    await GetUrlData(i);
            //    richTextBox.Text += "1";

            //}


            MessageBox.Show("done!");
            // await GetPhoneRequest(richTextBox);

        }

        public async void DebugginAsync(RichTextBox richTextBox, ListBox listBoxer,ProgressBar progressBar)
        {
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html: _getBodyHtml);

            var htmlNodes = document.DocumentNode.SelectNodes("//tr/td/a");
           // var htmlNodes = document.DocumentNode.SelectNodes("//ul/li/a");

            foreach (HtmlNode node in htmlNodes)
            {
                listBoxer.Items.Add(node.Attributes["href"].Value);
                DataList.Add(node.Attributes["href"].Value);
               // DataList.Add(node.OuterHtml);


            }

            List<string> releaseUri = new List<string>();
            //List<string> idCollection = new List<string>();

            for (int i = 0; i < DataList.Count; i++)
            {
                string collectionId = "";
                if (DataList[i].IndexOf("ID") != -1)
                {
                    for (int k = 0; k <= 4; k++)
                    {
                        //idCollection.Add(DataList[i][i + k].ToString());
                        int indexer = DataList[i].IndexOf("ID") + 2;
                        collectionId += DataList[i][indexer + k];
                    }
                }
                releaseUri.Add($"https://www.olx.kz/ajax/misc/contact/phone/{collectionId}/?pt=");
                richTextBox.Text += $" https://www.olx.kz/ajax/misc/contact/phone/{collectionId}/?pt= "; 
            }

            var bodyCollection = new List<string>();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            List<string> getPhoneTokenCollection = new List<string>();
            List<string> getPhoneRequestUrls = new List<string>();
            string[] splitChar = { }; 

            for (int i = 0; i < DataList.Count; i++)
            {
                doc.LoadHtml(await GetCodeAsync(DataList[i], progressBar));
                HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//section/script");
                foreach (HtmlNode node in nodes)
                {
                    splitChar = node.InnerText.Split(new string[] { "var", "=", "'", "phoneToken", ";", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
                    getPhoneTokenCollection.Add(splitChar[0]);
                }
            }

       
            
            MessageBox.Show("End;");

        }

        public async Task<string> GetCodeAsync(string uri, ProgressBar progressBar)
        {
            string getCode = "";
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                //getBodyHtml =  stream.ReadToEnd();
                getCode = await stream.ReadToEndAsync();
            }
            response.Close();
            response.Dispose();
            progressBar.Value += 1;
            return getCode;
        }

        public void GetTopAnnouncements()
        {
            //https://www.olx.kz/ajax/geo6/getstatsandlinks/

            List<string> getDataUrl = new List<string>();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.Load(@"C:\Users\xaNe\Desktop\sda.html", Encoding.UTF8);
            HtmlNodeCollection htmlNodes = document.DocumentNode.SelectNodes("//ul/li/a");

            foreach (HtmlNode node in htmlNodes)
            {
                //data-url
                var test = node.GetAttributeValue("data-id", "not found");
                //if(test != "not found")
                //{
                //    getDataUrl.Add(test);
                //}
                getDataUrl.Add(test);

                File.AppendAllText(@"C:\Users\xaNe\Desktop\ssa.txt", test + "," + "\n");
            }
        }

        public async Task<int> PostTest(string urls)
        {
            string getHtml = "";
            HttpWebRequest firstRequest = WebRequest.Create(urls) as HttpWebRequest;
            firstRequest.Method = "GET";
            //  IWebProxy webProxy = new WebProxy("185.27.62.66:54547");
            // request.Proxy = webProxy;
            firstRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            Response = await firstRequest.GetResponseAsync() as HttpWebResponse;
            using (var stream = new StreamReader(Response.GetResponseStream()))
            {
                getHtml = await stream.ReadToEndAsync();
            }
            Response.Close();
           

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(getHtml);
            var getMaxPageNode = htmlDocument.DocumentNode.SelectSingleNode($"//span[@class='item fleft'][14]/a[@class='block br3 brc8 large tdnone lheight24']/span");
      
            if(getMaxPageNode == null)
            {
                return 0;
            }
            int maxPage = Convert.ToInt32(getMaxPageNode.InnerText);
            return maxPage;

        }

        public async Task TestParse(string urls, decimal numberStrParse)
        {
            string getHtml = "";
            HttpWebRequest firstRequest = WebRequest.Create(urls) as HttpWebRequest;
            firstRequest.Method = "GET";
            //  IWebProxy webProxy = new WebProxy("185.27.62.66:54547");
            // request.Proxy = webProxy;
            firstRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            HttpWebResponse firstResponse = await firstRequest.GetResponseAsync() as HttpWebResponse;
            using (var stream = new StreamReader(firstResponse.GetResponseStream()))
            {
                getHtml = await stream.ReadToEndAsync();
                ContentCollection.Add(getHtml);
            }
            firstResponse.Close();
            firstResponse.Dispose();


            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(getHtml);
            // var getMaxPageNode = htmlDocument.DocumentNode.SelectSingleNode($"//span[@class='item fleft'][14]/a[@class='block br3 brc8 large tdnone lheight24']/span");
            var getMaxAdsNode = htmlDocument.DocumentNode.SelectSingleNode($"//td/div[@class='hasPromoted section clr']/p[@class='color-2']");
            string getAdsStr = "";
            string getMaxAds = getMaxAdsNode.InnerText;
            int s = 0;
            int pages = 0;
            int getPostTestResult = await PostTest(urls);

            if (getMaxAdsNode == null)
            {
                MessageBox.Show("Null maximum page");
                return;
            }

            if (getPostTestResult != 0)
            {
                pages = getPostTestResult;
            }
            else
            {
                for (int i = 0; i < getMaxAds.Length; i++)
                {
                    if (!int.TryParse(getMaxAds[i].ToString(), out s))
                    {
                        continue;
                    }
                    getAdsStr += getMaxAds[i];
                }

                decimal onlyAdsOnePage = 44m;
                // decimal calculatePage = Convert.ToInt32(getAdsStr) / onlyAdsOnePage;
                decimal calculatePage = Convert.ToDecimal(getAdsStr) / onlyAdsOnePage;
                int typeComparer = (int)calculatePage;
                if (typeComparer <= calculatePage)
                {
                    pages = typeComparer + 1;
                }
            }

            //try
            //{
            //    getMaxStr = node.InnerText;
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.ToString());
            //    MessageBox.Show(exp.Message);
            //    return;
            //}
         
            for (var i = 2; i <= pages + 1; i++)
            {
                if (numberStrParse <= i) 
                {
                    break;
                }
                HttpWebRequest request = WebRequest.Create($"{urls}?page={i}") as HttpWebRequest;
                request.Method = "GET";
                //  IWebProxy webProxy = new WebProxy("185.27.62.66:54547");
                // request.Proxy = webProxy;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
                request.AllowAutoRedirect = false;
                Response = await request.GetResponseAsync() as HttpWebResponse;
                string sgg = Response.Headers[HttpResponseHeader.Location];

                if (sgg != null)
                {
                    MessageBox.Show("Location Jump");
                }
                using (var stream = new StreamReader(Response.GetResponseStream()))
                {
                    ContentCollection.Add(await stream.ReadToEndAsync());
                    stream.Close();
                }
                Response.Close();
            }

        }

        public async Task<List<string>> GetAds()
        {
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parseAdsData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    HtmlNodeCollection nodeName = htmlDocument.DocumentNode.SelectNodes("//a[@class='marginright5 link linkWithHash detailsLink']/strong");
                    HtmlNodeCollection nodeAds = htmlDocument.DocumentNode.SelectNodes("//a[@class='marginright5 link linkWithHash detailsLink']");
                    HtmlNodeCollection nodeIndividualAds = htmlDocument.DocumentNode.SelectNodes("//ul/li[@class='hidden']/a");

                    if (nodeName != null || nodeIndividualAds != null || nodeAds != null)
                    {
                        for (var k = 0; k < nodeName.Count; k++)
                        {
                            AdsCollection.Add(nodeAds[k].Attributes["href"].Value);
                            parseAdsData.Add(nodeName[k].InnerText);
                        }

                        //for (var k = 0; k < nodeIndividualAds.Count; k++)
                        //{
                        //    IndividualAdsUrlsCollection.Add(nodeIndividualAds[k].Attributes["href"].Value);
                        //    IndividualAdsNamesCollection.Add(nodeIndividualAds[k].InnerText);
                        //}
                    }
                }
            });
            return parseAdsData;
        }

        public async Task<List<string>> GetPricesAds()
        {
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parsePricesAdsData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    HtmlNodeCollection nodeAds = htmlDocument.DocumentNode.SelectNodes("//div[@class='space inlblk rel']/p[@class='price']/strong");

                    if (nodeAds != null)
                    {
                        for (var k = 0; k < nodeAds.Count; k++)
                        {
                            PricesCollection.Add(nodeAds[k].InnerText);
                            parsePricesAdsData.Add(nodeAds[k].InnerText);
                            //PricesCollection.Add();
                        }
                    }
                }
            });
            return parsePricesAdsData;
        }

        public async Task<List<string>> GetLocationAds()
        {
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parseLocationAdsData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    HtmlNodeCollection nodeAds = htmlDocument.DocumentNode.SelectNodes("//p[@class='lheight16']/small[@class='breadcrumb x-normal'][1]/span");

                    if (nodeAds != null)
                    {
                        for (var k = 0; k < nodeAds.Count; k++)
                        {
                            LocationCollection.Add(nodeAds[k].InnerText);
                            parseLocationAdsData.Add(nodeAds[k].InnerText);
                            //PricesCollection.Add();
                        }
                    }

                }
            });
            return parseLocationAdsData;
        }

        public async Task<List<string>> GetTimeToPublishAd()
        {
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parseTimeToPublishAdData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    HtmlNodeCollection nodeAds = htmlDocument.DocumentNode.SelectNodes("//p[@class='lheight16']/small[@class='breadcrumb x-normal'][2]/span");

                    if (nodeAds != null)
                    {
                        for (var k = 0; k < nodeAds.Count; k++)
                        {
                            PublishingTimeCollection.Add(nodeAds[k].InnerText);
                            parseTimeToPublishAdData.Add(nodeAds[k].InnerText);
                        }
                    }
                }
            });
            return parseTimeToPublishAdData;
        }

        public async void GetPhoneAds()
        {
            //a[@class='marginright5 link linkWithHash detailsLink']/@href

            
            for (var i = 0; i < AdsCollection.Count; i++)
            {
                #region MyRegion
                // HttpWebRequest firstRequest = WebRequest.Create(AdsCollection[i]) as HttpWebRequest;
                // firstRequest.Method = "GET";
                // //  IWebProxy webProxy = new WebProxy("185.27.62.66:54547");
                // // request.Proxy = webProxy;
                // firstRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
                // HttpWebResponse firstResponse = await firstRequest.GetResponseAsync() as HttpWebResponse;
                // using (var stream = new StreamReader(firstResponse.GetResponseStream()))
                // {
                //     getHtml = await stream.ReadToEndAsync();
                // }
                // firstResponse.Close();
                // firstResponse.Dispose();

                // HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                // htmlDocument.LoadHtml(getHtml);
                // var getPhoneToken = htmlDocument.DocumentNode.SelectSingleNode("//section/script");
                // string[] phoneToken = getPhoneToken.InnerText.Split(new string[] { "var", "=", "'", "phoneToken", ";", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
                // string getToken = phoneToken[0];
                // string releaseUrlGetPhone = "";
                // int indexer = AdsCollection[i].IndexOf("ID");
                // string rowSelection = AdsCollection[i].Substring(indexer + 2, 5);
                // releaseUrlGetPhone = $"https://www.olx.kz/ajax/misc/contact/phone/{rowSelection}/?pt={getToken}";

                // HttpWebRequest secondRequest = WebRequest.Create(releaseUrlGetPhone) as HttpWebRequest;
                // secondRequest.Method = "GET";
                //// IWebProxy webProxy = new WebProxy("212.101.74.72");
                //// secondRequest.Proxy = webProxy;
                // secondRequest.Referer = AdsCollection[i];
                // secondRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
                // HttpWebResponse secondResponse = await secondRequest.GetResponseAsync() as HttpWebResponse;
                // using (var stream = new StreamReader(secondResponse.GetResponseStream()))
                // {
                //     phone = await stream.ReadToEndAsync();
                // }
                // MessageBox.Show(phone);
                // secondResponse.Close();
                // secondResponse.Dispose();
                #endregion
                //td[@class='wwnormal tright td-price']/div[@class='space inlblk rel']


            }

        }

        public async Task<List<string>> GetViewsAds()
        {
            string content = "";
            var viewsAdsDataList = new List<string>();
            HtmlNode node = null;
            int maximumValue = AdsCollection.Count;
            ProgressBarFromViewAds.Value = 0;
            ProgressBarFromViewAds.Minimum = 0;
            ProgressBarFromViewAds.Maximum = maximumValue;

            for (var i = 0; i < AdsCollection.Count; i++)
            {
                //td[@class='wwnormal tright td-price']/div[@class='space inlblk rel']
                // var web = new HtmlWeb();
                // var document = web.Load(AdsCollection[i]);
                HttpWebRequest request = WebRequest.Create(AdsCollection[i]) as HttpWebRequest;
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
                Response = await request.GetResponseAsync() as HttpWebResponse;
                using (var reader = new StreamReader(Response.GetResponseStream()))
                {
                    content = await reader.ReadToEndAsync();
                    reader.Close();
                }
                var document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(content);
                Response.Close();
                node = document.DocumentNode.SelectSingleNode("//div[@id='offerbottombar']/div[@class='pdingtop10']/strong");

                if (node != null)
                {
                    viewsAdsDataList.Add(node.InnerText);
                    ProgressBarFromViewAds.Value += 1;
                }
            }
            return viewsAdsDataList;
        }

        public async Task<List<string>> GetNameOfSeller()
        {
            string content = "";
            var nameOfSellerDataList = new List<string>();
            HtmlNode node = null;
            int maximumValue = AdsCollection.Count;
            ProgressBarFromViewAds.Value = 0;
            ProgressBarFromViewAds.Minimum = 0;
            ProgressBarFromViewAds.Maximum = maximumValue;

            for (var i = 0; i < AdsCollection.Count; i++)
            {
                //td[@class='wwnormal tright td-price']/div[@class='space inlblk rel']
                // var web = new HtmlWeb();
                // var document = web.Load(AdsCollection[i]);
                HttpWebRequest request = WebRequest.Create(AdsCollection[i]) as HttpWebRequest;
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
                Response = await request.GetResponseAsync() as HttpWebResponse;
                using (var reader = new StreamReader(Response.GetResponseStream()))
                {
                    content = await reader.ReadToEndAsync();
                    reader.Close();
                }
                var document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(content);
                Response.Close();
                node = document.DocumentNode.SelectSingleNode("//div/h4/a");

                if (node != null)
                {
                    nameOfSellerDataList.Add(node.InnerText.Replace(" ", ""));
                    ProgressBarFromViewAds.Value += 1;
                }
            }
            return nameOfSellerDataList;
        }


        public async Task<List<string>> GetIndividuaNameslAds()
        {
            //div[@class='inner']/ul[1]
            //Транспорт имя
            //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li
            //дата валуе для запроса /list
            //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li/a/@data-value

            //Optimized поиск other link
            //ul/li[@class='hidden']/a/@href

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parseIndividualAdsData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    //ul/li[@class='hidden']/a
                    HtmlNodeCollection nodeIndividualAds = htmlDocument.DocumentNode.SelectNodes("//div[@class='inner']/ul/li/a");

                    if (nodeIndividualAds != null)
                    {
                        for (var k = 0; k < nodeIndividualAds.Count; k++)
                        {
                            if (nodeIndividualAds[k].InnerText.Trim(new char[] { '\t', '\n' }).Last() != ' ') 
                            {
                                IndividualAdsNamesCollection.Add(nodeIndividualAds[k].InnerText.Trim(new char[] { '\t', '\n' }));
                                parseIndividualAdsData.Add(nodeIndividualAds[k].InnerText.Trim(new char[] { '\t', '\n' }));
                            }
                        }
                    }
                }
            });
            return parseIndividualAdsData;

        }

        public async Task<List<string>> GetIndividualUrlsAds()
        {
            //div[@class='inner']/ul[1]
            //Транспорт имя
            //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li
            //дата валуе для запроса /list
            //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li/a/@data-value

            //Optimized поиск other link
            //ul/li[@class='hidden']/a/@href

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            var parseIndividualAdsData = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < ContentCollection.Count; i++)
                {
                    htmlDocument.LoadHtml(ContentCollection[i]);
                    //ul/li[@class='hidden']/a
                    HtmlNodeCollection nodeIndividualAds = htmlDocument.DocumentNode.SelectNodes("//div[@class='inner']/ul/li/a");

                    if (nodeIndividualAds != null)
                    {
                        for (var k = 0; k < nodeIndividualAds.Count; k++)
                        {
                            IndividualAdsUrlsCollection.Add(nodeIndividualAds[k].Attributes["href"].Value);
                            parseIndividualAdsData.Add(nodeIndividualAds[k].Attributes["href"].Value);
                        }
                    }
                }
            });
            return parseIndividualAdsData.Distinct().ToList();

        }

        #region MyRegion
        //public Task<List<string>> GetIndividualUrlsAdsBetaTest()
        //{
        //    //div[@class='inner']/ul[1]
        //    //Транспорт имя
        //    //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li
        //    //дата валуе для запроса /list
        //    //ul[@class='small suggestinput bgfff lheight20 br-3 abs subcategories binded']/li/a/@data-value

        //    //Optimized поиск other link
        //    //ul/li[@class='hidden']/a/@href

        //    var htmlDocument = new HtmlAgilityPack.HtmlDocument();
        //    var parseIndividualAdsData = new List<string>();
        //    return Task.Run(() =>
        //    {
        //        for (int i = 0; i < ContentCollection.Count; i++)
        //        {
        //            htmlDocument.LoadHtml(ContentCollection[i]);
        //            //ul/li[@class='hidden']/a
        //            HtmlNodeCollection nodeIndividualAds = htmlDocument.DocumentNode.SelectNodes("//div[@class='inner']/ul/li/a");

        //            if (nodeIndividualAds != null)
        //            {
        //                for (var k = 0; k < nodeIndividualAds.Count; k++)
        //                {
        //                    IndividualAdsUrlsCollection.Add(nodeIndividualAds[k].Attributes["href"].Value);
        //                    parseIndividualAdsData.Add(nodeIndividualAds[k].Attributes["href"].Value);
        //                }
        //            }
        //        }
        //        return parseIndividualAdsData.Distinct().ToList();
        //    });
        //}
        #endregion

        public async Task GetUrlData(int cityId)
        {
            string getHtml = "";
            string url = "https://www.olx.kz/ajax/geo6/getstatsandlinks/";
            List<string> getDataUrl = new List<string>();
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            request.ContentType = "application/x-www-form-urlencoded";
            string data = $"region_id=&city_id={cityId}&district_id=0&dist=0&onlylinks=1";
            byte[] getDataBytes = Encoding.UTF8.GetBytes(data);
            request.ContentLength = getDataBytes.Length;
            //CookieContainer cookieContainer = new CookieContainer();
          //  request.CookieContainer = cookieContainer;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(getDataBytes, 0, getDataBytes.Length);
            }

            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                getHtml = await stream.ReadToEndAsync();
            }
            response.Close();
            response.Dispose();
        }

        public void Dispose()
        {
            Response.Dispose();
            ContentCollection.Clear();
            AdsCollection.Clear();
            PricesCollection.Clear();
            LocationCollection.Clear();
            PublishingTimeCollection.Clear();
            IndividualAdsUrlsCollection.Clear();
            IndividualAdsNamesCollection.Clear();
        }
    }
}
