using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OlxParser.SelectDataSection
{
    class SelectSection 
    {
        private string[] _dataName =
        {
            "https://www.olx.kz/nedvizhimost/alga/",
"https://www.olx.kz/transport/alga/",
"https://www.olx.kz/rabota/alga/",
"https://www.olx.kz/uslugi/alga/",
"https://www.olx.kz/zhivotnye/alga/",
"https://www.olx.kz/detskiy-mir/alga/",
"https://www.olx.kz/elektronika/alga/",
"https://www.olx.kz/elektronika/kompyutery-i-komplektuyuschie/alga/",
"https://www.olx.kz/elektronika/telefony-i-aksesuary/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/muzykalnye-instrumenty/alga/",
"https://www.olx.kz/dom-i-sad/komnatnye-rasteniya/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/knigi-zhurnaly/alga/",
"https://www.olx.kz/moda-i-stil/odezhda/alga/",
"https://www.olx.kz/moda-i-stil/krasota-zdorove/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/antikvariat-kollektsii/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/bilety/alga/",
"https://www.olx.kz/elektronika/igry-i-igrovye-pristavki/alga/",
"https://www.olx.kz/dom-i-sad/mebel/alga/",
"https://www.olx.kz/dom-i-sad/predmety-interera/alga/",
"https://www.olx.kz/dom-i-sad/prochie-tovary-dlya-doma/alga/",
"https://www.olx.kz/zhivotnye/sobaki/alga/",
"https://www.olx.kz/zhivotnye/koshki/alga/",
"https://www.olx.kz/zhivotnye/drugie-zhivotnye/alga/",
"https://www.olx.kz/zhivotnye/tovary-dlya-zhivotnyh/alga/",
"https://www.olx.kz/detskiy-mir/detskie-kolyaski/alga/",
"https://www.olx.kz/detskiy-mir/detskaya-mebel/alga/",
"https://www.olx.kz/detskiy-mir/prochie-detskie-tovary/alga/",
"https://www.olx.kz/dom-i-sad/produkty-pitaniya-napitki/alga/",
"https://www.olx.kz/moda-i-stil/dlya-svadby/alga/",
"https://www.olx.kz/moda-i-stil/aksessuary/alga/",
"https://www.olx.kz/transport/legkovye-avtomobili/alga/",
"https://www.olx.kz/transport/moto/alga/",
"https://www.olx.kz/transport/drugoy-transport/alga/",
"https://www.olx.kz/transport/avtozapchasti-i-aksessuary/alga/",
"https://www.olx.kz/uslugi/avto-uslugi/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/poisk-poputchikov/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/poisk-grupp-muzykantov/alga/",
"https://www.olx.kz/zhivotnye/byuro-nahodok/alga/",
"https://www.olx.kz/rabota/gostinitsy-turizm-otdykh/alga/",
"https://www.olx.kz/rabota/bary-restorany-kafe/alga/",
"https://www.olx.kz/rabota/meditsina-farmatsevtika/alga/",
"https://www.olx.kz/rabota/krasota-fitnes-sport/alga/",
"https://www.olx.kz/rabota/transport-logistika/alga/",
"https://www.olx.kz/rabota/obrazovaniye-nauka/alga/",
"https://www.olx.kz/rabota/proizvodstvo-energetika/alga/",
"https://www.olx.kz/rabota/roznichnaya-torgovlya-prodazhi-zakupki/alga/",
"https://www.olx.kz/rabota/marketing-reklama-dizayn/alga/",
"https://www.olx.kz/rabota/internet-it-kompyutery-telekom/alga/",
"https://www.olx.kz/rabota/finansy-bukhgalteriya-ekonomika/alga/",
"https://www.olx.kz/rabota/administrativnyy-personal/alga/",
"https://www.olx.kz/rabota/stroitelstvo-arkhitektura/alga/",
"https://www.olx.kz/rabota/drugiye-sfery-deyatelnosti/alga/",
"https://www.olx.kz/rabota/ohrana-bezopasnost/alga/",
"https://www.olx.kz/rabota/kultura-iskusstvo-razvlecheniya/alga/",
"https://www.olx.kz/rabota/domashniy-personal/alga/",
"https://www.olx.kz/uslugi/prochie-uslugi/alga/",
"https://www.olx.kz/uslugi/remont-i-stroitelstvo/alga/",
"https://www.olx.kz/uslugi/turizm-immigratsiya/alga/",
"https://www.olx.kz/uslugi/perevozki-i-skladskie-uslugi/alga/",
"https://www.olx.kz/uslugi/krasota-i-zdorove/alga/",
"https://www.olx.kz/uslugi/uslugi-dlya-zhivotnyh/alga/",
"https://www.olx.kz/uslugi/foto-i-videosemka/alga/",
"https://www.olx.kz/uslugi/obuchenie-kursy-repetitorstvo/alga/",
"https://www.olx.kz/transport/gruzovye-avtomobili/alga/",
"https://www.olx.kz/transport/avtobusy/alga/",
"https://www.olx.kz/zhivotnye/vyazka/alga/",
"https://www.olx.kz/transport/vodnyy-transport/alga/",
"https://www.olx.kz/zhivotnye/zhivotnye-darom/alga/",
"https://www.olx.kz/transport/pritsepy/alga/",
"https://www.olx.kz/transport/shiny-diski-i-kolesa/alga/",
"https://www.olx.kz/transport/spetstehnika/alga/",
"https://www.olx.kz/transport/selhoztehnika/alga/",
"https://www.olx.kz/transport/vozdushnyy-transport/alga/",
"https://www.olx.kz/transport/zapchasti-dlya-spets-sh-tehniki/alga/",
"https://www.olx.kz/transport/prochie-zapchasti/alga/",
"https://www.olx.kz/zhivotnye/ptitsy/alga/",
"https://www.olx.kz/zhivotnye/gryzuny/alga/",
"https://www.olx.kz/zhivotnye/reptilii/alga/",
"https://www.olx.kz/zhivotnye/akvariumnye-rybki/alga/",
"https://www.olx.kz/zhivotnye/selskohozyaystvennye-zhivotnye/alga/",
"https://www.olx.kz/elektronika/tehnika-dlya-kuhni/alga/",
"https://www.olx.kz/elektronika/tehnika-dlya-doma/alga/",
"https://www.olx.kz/elektronika/individualnyy-uhod/alga/",
"https://www.olx.kz/elektronika/klimaticheskoe-oborudovanie/alga/",
"https://www.olx.kz/elektronika/aksessuary-i-komplektuyuschie/alga/",
"https://www.olx.kz/elektronika/audiotehnika/alga/",
"https://www.olx.kz/elektronika/tv-videotehnika/alga/",
"https://www.olx.kz/elektronika/foto-video/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/cd-dvd-plastinki/alga/",
"https://www.olx.kz/dom-i-sad/hozyaystvennyy-inventar/alga/",
"https://www.olx.kz/detskiy-mir/detskie-avtokresla/alga/",
"https://www.olx.kz/detskiy-mir/detskaya-odezhda/alga/",
"https://www.olx.kz/detskiy-mir/detskaya-obuv/alga/",
"https://www.olx.kz/detskiy-mir/igrushki/alga/",
"https://www.olx.kz/detskiy-mir/kormlenie/alga/",
"https://www.olx.kz/detskiy-mir/tovary-dlya-shkolnikov/alga/",
"https://www.olx.kz/moda-i-stil/naruchnye-chasy/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/sport-otdyh/alga/",
"https://www.olx.kz/dom-i-sad/sadovyy-inventar/alga/",
"https://www.olx.kz/dom-i-sad/kantstovary-rashodnye-materialy/alga/",
"https://www.olx.kz/dom-i-sad/stroitelstvo-remont/alga/",
"https://www.olx.kz/dom-i-sad/instrumenty/alga/",
"https://www.olx.kz/dom-i-sad/posuda-kuhonnaya-utvar/alga/",
"https://www.olx.kz/uslugi/setevoy-marketing/alga/",
"https://www.olx.kz/uslugi/prokat-tovarov/alga/",
"https://www.olx.kz/uslugi/remont-i-obsluzhivanie-tehniki/alga/",
"https://www.olx.kz/detskiy-mir/detskiy-transport/alga/",
"https://www.olx.kz/moda-i-stil/alga/",
"https://www.olx.kz/moda-i-stil/podarki/alga/",
"https://www.olx.kz/dom-i-sad/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/alga/",
"https://www.olx.kz/otdam-darom/alga/",
"https://www.olx.kz/rabota/nedvizhimost/alga/",
"https://www.olx.kz/rabota/servis-i-byt/alga/",
"https://www.olx.kz/rabota/nachalo-karyery-stazhirovka-praktika/alga/",
"https://www.olx.kz/hobbi-otdyh-i-sport/drugoe/alga/",
"https://www.olx.kz/moda-i-stil/moda-raznoe/alga/",
"https://www.olx.kz/elektronika/prochaja-electronika/alga/",
"https://www.olx.kz/dom-i-sad/sad-ogorod/alga/",
"https://www.olx.kz/nedvizhimost/kvartiry/alga/",
"https://www.olx.kz/nedvizhimost/doma/alga/",
"https://www.olx.kz/nedvizhimost/komnaty/alga/",
"https://www.olx.kz/nedvizhimost/zemlya/alga/",
"https://www.olx.kz/nedvizhimost/garazhi-stoyanki/alga/",
"https://www.olx.kz/nedvizhimost/kommercheskie-pomeshcheniya/alga/",
"https://www.olx.kz/nedvizhimost/zarubezhnaya-nedvizhimost/alga/",
"https://www.olx.kz/transport/motozapchasti-i-aksessuary/alga/",
"https://www.olx.kz/elektronika/noutbuki-i-aksesuary/alga/",
"https://www.olx.kz/elektronika/planshety-el-knigi-i-aksessuary/alga/",
"https://www.olx.kz/uslugi/bytovye-uslugi/alga/",
"https://www.olx.kz/uslugi/uborka/alga/",
"https://www.olx.kz/uslugi/ohrana-bezopasnost/alga/",
"https://www.olx.kz/uslugi/delovye-uslugi/alga/",
"https://www.olx.kz/uslugi/studii-zvukozapisi/alga/",
"https://www.olx.kz/uslugi/dlya-biznesa/alga/",
"https://www.olx.kz/uslugi/razvlecheniya/alga/",
"https://www.olx.kz/uslugi/byuro-nakhodok-v-uslugah/alga/",
"https://www.olx.kz/rabota/banki-strakhovaniye/alga/",
"https://www.olx.kz/rabota/yuristy-advokaty-notariusy/alga/",
"https://www.olx.kz/rabota/dobycha-syrya/alga/",
"https://www.olx.kz/rabota/hr-upravleniye-personalom-treningi/alga/",
"https://www.olx.kz/rabota/sto-avtomoyki-servisnoye-obsluzhivaniye/alga/",
"https://www.olx.kz/rabota/top-menedzhment-rukovodstvo-vysshego-zvena/alga/",
"https://www.olx.kz/rabota/gosudarstvennaya-sluzhba-nekommercheskiye-organizatsii/alga/",
"https://www.olx.kz/rabota/selskoye-khozyaystvo-agrobiznes-lesnoye-khozyaystvo/alga/",
"https://www.olx.kz/rabota/rabota-za-rubezhom/alga/",
"https://www.olx.kz/rabota/setevoy-marketing/alga/"

        };

        public string[] _dataUrl = {"","akm",
"akt",
"alm",
"atr",
"vko",
"zhm",
"zko",
"kar",
"kus",
"kyz",
"man",
"pav",
"sko",
"uko",
"abay",
"akkol",
"aksay",
"aksu",
"astana",
"atbasar",
"derjavinsk",
"ereymentau",
"esil",
"kokshetau",
"makinsk",
"schuchinsk",
"sergeevka",
"stepnogorsk",
"stepnyak",
"aktobe",
"alga",
"emba",
"hromtau",
"kandyagash",
"shalkar",
"temir",
"jem",
"alma-ata",
"esik",
"kapchagay",
"kaskelen",
"sarkand",
"taldykorgan",
"talgar",
"tekeli",
"usharal",
"ushtobe",
"zharkent",
"atyrau",
"kulsary",
"ayagoz",
"kurchatov",
"ridder",
"satpaev",
"semey",
"serebryansk",
"charsk",
"shemonaiha",
"ust-kamenogorsk",
"zaysan",
"zyryanovsk",
"karatau",
"shu",
"taraz",
"janatas",
"aktau",
"uralsk",
"atasu",
"balhash",
"baykonur",
"karaganda",
"karajal",
"karkaralinsk",
"priozersk",
"saran",
"shahtinsk",
"temirtau",
"jezkazgan",
"arkalyk",
"kostanay",
"lisakovsk",
"rudnyy",
"jitikara",
"aralsk",
"kazalinsk",
"kyzylorda",
"fort-shevchenko",
"janaozen",
"ekibastuz",
"pavlodar",
"bulaevo",
"mamlyutka",
"petropavlovsk",
"tayynsha",
"kentau",
"lenger",
"shardara",
"shymkent",
"turkestan",
"jetysay" };

        private string[] _localDataId = {"Акмолинская область",
"Актюбинская область",
"Алматинская область",
"Атырауская область",
"Восточно-Казахстанская область",
"Жамбылская область",
"Западно-Казахстанская область",
"Карагандинская область",
"Костанайская область",
"Кызылординская область",
"Мангистауская область",
"Павлодарская область",
"Северо-Казахстанская область",
"Южно-Казахстанская область",
"Абай",
"Акколь",
"Аксай",
"Аксу",
"Астана",
"Атбасар",
"Державинск",
"Ерейментау",
"Есиль",
"Кокшетау",
"Макинск",
"Щучинск",
"Сергеевка",
"Степногорск",
"Степняк",
"Актобе",
"Алга",
"Эмба",
"Хромтау",
"Кандыагаш",
"Шалкар",
"Темир",
"Жем",
"Алматы",
"Есик",
"Капчагай",
"Каскелен",
"Сарканд",
"Талдыкорган",
"Талгар",
"Текели",
"Ушарал",
"Уштобе",
"Жаркент",
"Атырау",
"Кульсары",
"Аягоз",
"Курчатов",
"Риддер",
"Сатпаев",
"Семей",
"Серебрянск",
"Шар",
"Шемонаиха",
"Усть-Каменогорск",
"Зайсан",
"Зыряновск",
"Каратау",
"Шу",
"Тараз",
"Жанатас",
"Актау",
"Уральск",
"Атасу",
"Балхаш",
"Байконур",
"Караганда",
"Каражал",
"Каркаралинск",
"Приозерск",
"Сарань",
"Шахтинск",
"Темиртау",
"Жезказган",
"Аркалык",
"Костанай",
"Лисаковск",
"Рудный",
"Житикара",
"Аральск",
"Казалинск",
"Кызылорда",
"Форт-Шевченко",
"Жанаозен",
"Экибастуз",
"Павлодар",
"Булаево",
"Мамлютка",
"Петропавловск",
"Тайынша",
"Кентау",
"Ленгер",
"Шардара",
"Шымкент",
"Туркестан",
"Жетысай"};

        public List<string> Content { get; private set; }

        public SelectSection()
        {
            Content = new List<string>();
        }

        private async Task<string> RequestAndResponse(string url)
        {
            string content = "";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36";
            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
            {
                content = await reader.ReadToEndAsync();
                reader.Close();
            }
            response.Close();
            response.Dispose();
            return content;
        
        }

        public async void GetInfo(int selectDataId, int selectDataNameId, System.Windows.Forms.RichTextBox richTextBox)
        {
            string builderUrl = _dataUrl[selectDataId];
            string builderName = _dataName[selectDataNameId];
            string builded = builderUrl + builderName;

            System.Windows.Forms.MessageBox.Show(builded);


        }

        public async Task ExperimintalAsync()
        {
            var startIndexSubstring = 0;
            string substringOldUrl = "";
            string urlRelease = "";
            string urlReleasse = "";
            var k = 0;

            for (var i = 0; i <= _dataUrl.Length; i++)
            {
                if (i >= _dataUrl.Length && k <= _dataName.Length)
                {
                    i = 0;
                    k++;
                }

                startIndexSubstring = _dataName[i].LastIndexOf("/") - 4;
                substringOldUrl = _dataName[i].Substring(startIndexSubstring, 4);
                urlRelease = _dataName[i].Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[k]);
                urlReleasse = _dataName[i].Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[k]);
                Content.Add(await RequestAndResponse(urlRelease));
                System.IO.File.AppendAllText(@"C:\Users\xaNe\Desktop\cronjob.txt", $"{urlRelease} ======= i = {i} , ======== k = {k}\n");
            }

            System.Windows.Forms.MessageBox.Show("Completion");
        }

        public Task SafeAsync()
        {
            var tasks = new List<Task>();
            for (var i = 0; i < _dataName.Length; i++)
            {
                if(i == 5)
                {
                    var currentTask = Task.Factory.ContinueWhenAll(tasks.ToArray(), t => { System.Windows.Forms.MessageBox.Show("Task " + Task.Factory.CreationOptions.ToString()); });
                    bool isStatusCompletion = (currentTask.Status == TaskStatus.RanToCompletion);
                    break;
                }

                tasks.Add(TestAllocation(_dataName[i]));



            }

           

            return Task.Factory.ContinueWhenAll(tasks.ToArray(), t => { System.Windows.Forms.MessageBox.Show("Task " + Task.Factory.CreationOptions.ToString()); });

        }

        //private async Task TestAllocation(string nDataName, int count)
        //{
        //    int startIndexSubstring = 0;
        //    string substringOldUrl = ""; 
        //    string urlRelease = "";
        //    string urlReleasse = "";
        //    int k = 0;
        //    for (int i = 0; i < dataUrl.Length; i++)
        //    {
        //        if(i == count)
        //        {
        //            k++;
        //        }
        //        startIndexSubstring = nDataName.LastIndexOf("/") - 4;
        //        substringOldUrl = nDataName.Substring(startIndexSubstring, 4);
        //        urlRelease = nDataName.Remove(startIndexSubstring, 4).Insert(startIndexSubstring, dataUrl[k]);
        //        urlReleasse = nDataName.Remove(startIndexSubstring, 4).Insert(startIndexSubstring, dataUrl[k]);
        //        Content.Add(await RequestAndResponse(urlRelease));
        //    }

        //}

        private async Task TestAllocation(string nameUrl)
        {
            int startIndexSubstring = 0;
            string substringOldUrl = "";
            string urlRelease = "";
            string urlReleasse = "";
            int k = 0;
            for (var i = 0; i < _dataUrl.Length; i++)
            {
                if(i == _dataUrl.Length)
                {
                    k++;
                }
              
                startIndexSubstring = nameUrl.LastIndexOf("/") - 4;
                substringOldUrl = nameUrl.Substring(startIndexSubstring, 4);
                urlRelease = nameUrl.Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[i]);
                urlReleasse = nameUrl.Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[i]);
                Content.Add(await RequestAndResponse(urlRelease));
                System.IO.File.AppendAllText(@"C:\Users\xaNe\Desktop\cronjob.txt", $"{urlRelease} ======= i = {i} ======== k = {k} \n");
            }

            Console.WriteLine("Method complete");

        }

        public async Task InfoLocation()
        {
            string urlReleasse = "";
            try
            {
                int k = 0;
                for (var i = 0; i < _dataName.Length; i++)
                {
                    if (i == _dataName.Length)
                    {
                        k++;
                    }
                    
                    int startIndexSubstring = _dataName[i].LastIndexOf("/") - 4;
                    string substringOldUrl = _dataName[i].Substring(startIndexSubstring, 4);
                    string urlRelease = _dataName[i].Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[k]);
                    urlReleasse = _dataName[i].Remove(startIndexSubstring, 4).Insert(startIndexSubstring, _dataUrl[k]);
                    Content.Add(await RequestAndResponse(urlRelease));
                 
                }
            }
            catch (Exception exp)
            {

                System.Windows.Forms.MessageBox.Show(exp.Message);
                System.Windows.Forms.MessageBox.Show(exp.ToString());
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show(urlReleasse);
            }
          
        }


        
    }
}
