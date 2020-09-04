using OlxParser.GetHtml;
using OlxParser.SelectDataSection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlxParser
{
    public partial class MainForm : Form
    {
        private GetHtmlParse getHtmlParse;
        private SelectDataSection.SelectSection selectSection;
        private Section section;

        private string OldUrl { get; set; }

        private string NewUrl { get; set; }

        private SectionID SectionId { get; }
        private string[] productsCollection { get; set; }

        public MainForm()
        {
            InitializeComponent();
            GlobalSectionList.Items.AddRange(new string[] { "Весь Казахстан","Акмолинская область",
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
"Жетысай"
});
            string[] temp = { "Услуги", "Недвижимость", "Электроника", "Дом и сад", "Работа", "Мода и стиль", "Детский мир", "Хобби, отдых и спорт", "Транспорт", "Животные" };

            productsCollection = temp;
            DefaultSectionList.Items.AddRange(productsCollection);
            getHtmlParse = new GetHtmlParse();
            section = new Section();
            selectSection = new SelectDataSection.SelectSection();
            SetupColumns();
        }

        enum SectionID
        {
            FirstSection,
            SecondSection,
            ThreeSection,
            ForSection,
            FiveSection,
            SixSection,
            SevenSection,
            EightSection,
            NineSection,
            TenSection
        };


        private void SelectFromSection(int sectionId, ref string moveUrl)
        {
            if (GlobalSectionList.SelectedIndex == -1)
                return;

            if (DefaultSectionList.SelectedIndex == -1)
                return;

            string[][] sectionsCollection =
            {
                section.firstSection,
                section.secondSection,
                section.threeSection,
                section.forSection,
                section.fiveSection,
                section.sixSection,
                section.sevenSection, section.eightSection,
                section.nineSection, section.tenSection
            };
            string selectSectionIndex = selectSection._dataUrl[GlobalSectionList.SelectedIndex];
            string buildUrl = sectionsCollection[sectionId][ProductSectionList.SelectedIndex + 1] + selectSectionIndex;

            if (selectSectionIndex != "") 
            {
                buildUrl += "/";
            }
            moveUrl = buildUrl;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (RestartAndClear.Checked)
            {
                dataGridView1.Rows.Clear();
            }

            string currentUrl = OldUrl;

            if (NewUrl != null) 
            {
                OldUrl = NewUrl;
            }
            string sf = SectionID.FirstSection.ToString();
            switch (DefaultSectionList.SelectedIndex)
            {
                case 0:
                    SelectFromSection((int)SectionID.FirstSection, moveUrl: ref currentUrl);
                    break;
                case 1:
                    SelectFromSection((int)SectionID.SecondSection, moveUrl: ref currentUrl);
                    break;
                case 2:
                    SelectFromSection((int)SectionID.ThreeSection, moveUrl: ref currentUrl);
                    break;
                case 3:
                    SelectFromSection((int)SectionID.ForSection, moveUrl: ref currentUrl);
                    break;
                case 4:
                    SelectFromSection((int)SectionID.FiveSection, moveUrl: ref currentUrl);
                    break;
                case 5:
                    SelectFromSection((int)SectionID.SixSection, moveUrl: ref currentUrl);
                    break;
                case 6:
                    SelectFromSection((int)SectionID.SevenSection, moveUrl: ref currentUrl);
                    break;
                case 7:
                    SelectFromSection((int)SectionID.EightSection, moveUrl: ref currentUrl);
                    break;
                case 8:
                    SelectFromSection((int)SectionID.NineSection, moveUrl: ref currentUrl);
                    break;
                case 9:
                    SelectFromSection((int)SectionID.TenSection, moveUrl: ref currentUrl);
                    break;
                default:
                    break;
            }

            int selectDataId = GlobalSectionList.SelectedIndex;
            int selectDataName = ProductSectionList.SelectedIndex;
            await getHtmlParse.TestParse(OldUrl, numericUpDown1.Value);
            string[] rowsContent = { GlobalSectionList.SelectedItem.ToString(), DefaultSectionList.SelectedItem.ToString(),
                ProductSectionList.SelectedItem.ToString(), "", "", "", "", "", "", "" };

            foreach (var item in await getHtmlParse.GetAds())
            {
                listBox1.Items.Add(item);
                rowsContent[3] = item;
                dataGridView1.Rows.Add(rowsContent);
            }
            MessageBox.Show(listBox1.Items.Count.ToString());
            // getHtmlParse.GetPhoneAds();
            getHtmlParse.ProgressBarFromViewAds = progressBar1;
            var viewsAds = await getHtmlParse.GetViewsAds();
            var pricesAds = await getHtmlParse.GetPricesAds();
            var locationAds = await getHtmlParse.GetLocationAds();
            var publicationTime = await getHtmlParse.GetTimeToPublishAd();
            var getNameOfSeller = await getHtmlParse.GetNameOfSeller();
        
            for (var i = 0; i < viewsAds.Count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = viewsAds[i];
            }

            for (var i = 0; i < pricesAds.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = pricesAds[i];
            }

            for (var i = 0; i < locationAds.Count; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = locationAds[i];
            }

            for (var i = 0; i < publicationTime.Count; i++)
            {
                dataGridView1.Rows[i].Cells[7].Value = publicationTime[i];
            }

            for (var i = 0; i < getNameOfSeller.Count; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = getNameOfSeller[i];
            }

            getHtmlParse.Dispose();
           // PopulateColumns();

        }

        private void SetupColumns()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns.Add("firstColumn", "Регион");
            dataGridView1.Columns.Add("secondColumn", "Категория");
            dataGridView1.Columns.Add("threeColumn", "Тип товара");
            dataGridView1.Columns.Add("forColumn", "Товар");
            dataGridView1.Columns.Add("fiveColumn", "Просмотры");
            dataGridView1.Columns.Add("sixColumn", "Цена");      
            dataGridView1.Columns.Add("sevenColumn", "Конкретный регион");      
            dataGridView1.Columns.Add("eighthСolumn", "Время публикации");      
            dataGridView1.Columns.Add("nineСolumn", "Имя продавца");      
        }

        private void PopulateColumns()
        {
            string[] rowsContent = { GlobalSectionList.SelectedItem.ToString(), DefaultSectionList.SelectedItem.ToString(), ProductSectionList.SelectedItem.ToString() };
            dataGridView1.Rows.Add(rowsContent);
            var asf = dataGridView1.Rows[0].Cells[0].Value;
        }

        private void getUrlParse_Click(object sender, EventArgs e)
        {
            #region MyRegion
            //richTextBox1.Clear();
            //richTextBox2.Clear();
            //string getHtml = "";
            //string urlBeta = "https://www.olx.kz/obyavlenie/pos-terminaly-verifone-ot-95-000-tg-v-astane-IDgrKlT.html#2168cec07a;promoted";
            //HttpWebRequest firstRequest = WebRequest.Create(urlBeta) as HttpWebRequest;
            //firstRequest.Method = "GET";
            //IWebProxy webProxy = new WebProxy(textBox1.Text);
            //firstRequest.Proxy = webProxy;
            //firstRequest.AllowAutoRedirect = true;
            //firstRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            //HttpWebResponse firstResponse = firstRequest.GetResponse() as HttpWebResponse;
            //using (var stream = new System.IO.StreamReader(firstResponse.GetResponseStream()))
            //{
            //    getHtml = stream.ReadToEnd();
            //}


            //CookieContainer cookieContainer = new CookieContainer();
            //firstResponse.Close();
            //firstRequest = WebRequest.Create(releaseUrlGetPhone) as HttpWebRequest;
            //firstRequest.CookieContainer = cookieContainer;
            //firstRequest.Method = "GET";
            //firstRequest.Referer = urlBeta;
            //firstRequest.Proxy = new WebProxy(textBox2.Text);

            //firstResponse = firstRequest.GetResponse() as HttpWebResponse;
            //string responseData = "";

            //using (var reader = new System.IO.StreamReader(firstResponse.GetResponseStream()))
            //{
            //    responseData = reader.ReadToEnd();
            //}
            //richTextBox1.Text = responseData;
            //firstResponse.Close();

            //firstResponse.Dispose();

            // string getToken = "78f6978c4732a6057c0be4327590f030cfc9c7b7ad43527fb93764f52353fbe56a236327606653b0a046835d0aa719dd5473e378f9e65ff9958b2f48521bdab2";


            //  string phone = "";
            //  HttpWebRequest httpWebRequest = WebRequest.Create(urlBeta) as HttpWebRequest;
            //  httpWebRequest.Method = "GET";
            ////  httpWebRequest.Referer = "https://www.olx.kz/obyavlenie/markery-markerno-melovye-doski-v-atyrau-IDfSkLs.html#882b9ebe8c;promoted";
            //  httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";
            //  HttpWebResponse secondResponse = null;
            //  try
            //  {
            //      secondResponse = httpWebRequest.GetResponse() as HttpWebResponse;
            //  }
            //  catch (Exception ex)
            //  {

            //      MessageBox.Show(ex.Message + "1");
            //      MessageBox.Show(ex.ToString());
            //      return;
            //  }

            //  using (var stream = new System.IO.StreamReader(secondResponse.GetResponseStream()))
            //  {
            //      phone = stream.ReadToEnd();
            //      richTextBox1.Text = phone;

            //      secondResponse.Close();
            //      secondResponse.Dispose();
            //      stream.Close();

            //      //if (string.IsNullOrWhiteSpace(textBox1.Text))
            //      //{
            //      //    return;
            //      //}

            //      //getHtmlParse = new GetHtmlParse() { setParseLink = textBox1.Text };
            //      //getHtmlParse.StartRunning(richTextBox1, listBox1, progressBar1);
            //  }


            //   string content = "";
            //HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            //htmlDocument.LoadHtml(phone);
            //var getPhoneToken = htmlDocument.DocumentNode.SelectSingleNode("//section/script");
            //string[] phoneToken = getPhoneToken.InnerText.Split(new string[] { "var", "=", "'", "phoneToken", ";", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            //string getToken = phoneToken[0];
            //string releaseUrlGetPhone = "";
            //int indexer = urlBeta.IndexOf("ID");
            //string rowSelection = urlBeta.Substring(indexer + 2, 5);
            //releaseUrlGetPhone = $"https://www.olx.kz/ajax/misc/contact/phone/{rowSelection}/?pt={getToken}";
            //string refererCurrent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.119 Safari/537.36";

            //System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            //System.Net.Http.HttpResponseMessage responseMessage = await httpClient.GetAsync(releaseUrlGetPhone);
            //richTextBox2.Text = await responseMessage.Content.ReadAsStringAsync();
            //responseMessage.Dispose();
            //httpClient.Dispose();

            #endregion

            #region NewRegion
            //string content = "";
            //string url = "https://www.olx.kz/obyavlenie/stol-stul-dlya-kormleniya-barty-babys-belyy-art-piggy-IDgRLUa.html#2168cec07a";
            //string getTokenPhoneUrl = "https://www.olx.kz/ajax/misc/contact/phone/gRLUa/?pt=";
            //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //request.Method = "GET";
            //request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36";
            //HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            //using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
            //{
            //    content = await reader.ReadToEndAsync();
            //    reader.Close();
            //}
            //response.Close();
            //response.Dispose();
            //HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            //htmlDocument.LoadHtml(content);
            //var getPhoneToken = htmlDocument.DocumentNode.SelectSingleNode("//section/script");
            //string[] phoneToken = getPhoneToken.InnerText.Split(new string[] { "var", "=", "'", "phoneToken", ";", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            //string getTokenWithUrl = getTokenPhoneUrl + phoneToken[0];
            //HttpWebRequest secondRequest = WebRequest.Create(getTokenWithUrl) as HttpWebRequest;
            //secondRequest.Method = "GET";
            //secondRequest.Referer = url;
            //secondRequest.AllowAutoRedirect = false;
            //secondRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.86 Safari/537.36";
            //secondRequest.Headers.Add("x-requested-with", "XMLHttpRequest");
            //HttpWebResponse secondResponse = await secondRequest.GetResponseAsync() as HttpWebResponse;
            //using (var reader = new System.IO.StreamReader(secondResponse.GetResponseStream()))
            //{
            //    richTextBox1.Text = await reader.ReadToEndAsync();
            //    reader.Close();
            //}
            //secondResponse.Close();
            //secondResponse.Dispose();
            #endregion

            dataGridView1.Rows.Clear();
           // PopulateColumns();
        }

        private void SelectAggregate(string[] selectAggregate)
        {
            foreach (var item in selectAggregate)
            {
                ProductSectionList.Items.Add(item);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductSectionList.Items.Clear();

            string[] firstCollection = {"Развлечения","Красота и здоровье",
"Для бизнеса",
"Авто услуги",
"Бытовые услуги",
"Перевозки и складские услуги",
"Ремонт и обслуживание техники",
"Ремонт и строительство",
"Уборка",
"Охрана / безопасность",
"Деловые услуги",
"Обучение / курсы / репетиторство",
"Студии звукозаписи",
"Фото- и видеосъемка",
"Туризм / иммиграция",
"Сетевой маркетинг",
"Прокат товаров",
"Услуги для животных",
"Прочие услуги",
"Бюро находок"};
            string[] secondCollection = {"Квартиры",
"Дома",
"Комнаты",
"Земля",
"Гаражи/стоянки",
"Коммерческие помещения",
"Зарубежная недвижимость"};
            string[] threeCollection = {"Телефоны и аксессуары",
"Компьютеры и комплектующие",
"Фото / видео",
"Тв / видеотехника",
"Аудиотехника",
"Игры и игровые приставки",
"Планшеты / эл. книги и аксессуары",
"Ноутбуки и аксессуары",
"Техника для дома",
"Техника для кухни",
"Климатическое оборудование",
"Индивидуальный уход",
"Аксессуары и комплектующие",
"Прочая электроника"};
            string[] forCollection = {"Комнатные растения",
"Мебель",
"Предметы интерьера",
"Прочие товары для дома",
"Продукты питания / напитки",
"Хозяйственный инвентарь/бытовая химия",
"Садовый инвентарь",
"Канцтовары / расходные материалы",
"Строительство / ремонт",
"Инструменты",
"Посуда / кухонная утварь",
"Сад / огород"};
            string[] fiveCollection = {"Гостиницы / туризм / отдых",
"Бары / рестораны / кафе",
"Медицина / фармацевтика",
"Красота / фитнес / спорт",
"Транспорт / логистика",
"Образование / наука",
"Производство / энергетика",
"Розничная торговля / продажи / закупки",
"Маркетинг / реклама / дизайн",
"Интернет / IT / компьютеры / телеком",
"Финансы / бухгалтерия / экономика",
"Административный персонал",
"Строительство / архитектура",
"Другие сферы деятельности",
"Охрана / безопасность",
"Культура / искусство / развлечения",
"Домашний персонал",
"Недвижимость",
"Сервис и быт",
"Начало карьеры / стажировка / практика",
"Банки / страхование",
"Юристы / адвокаты / нотариусы",
"Добыча сырья",
"HR / управление персоналом / тренинги",
"СТО / автомойки / сервисное обслуживание",
"Топ-менеджмент / руководство высшего звена",
"Государственная служба / некоммерческие организации",
"Сельское хозяйство / агробизнес / лесное хозяйство",
"Работа за рубежом",
"Сетевой маркетинг"};
            string[] noneCollection = {"Подарки",
"Одежда/обувь",
"Для свадьбы",
"Аксессуары",
"Наручные часы",
"Мода разное","Товары для красоты и здоровья"};
            string[] teCollection = {"Детские коляски",
"Детская мебель",
"Прочие детские товары",
"Детские автокресла",
"Детская одежда",
"Детская обувь",
"Игрушки",
"Товары для кормления",
"Товары для школьников",
"Детский транспорт"};
            string[] sixCollection =
            {
               "Антиквариат / коллекции",
"Спорт / отдых",
"Билеты",
"Музыкальные инструменты",
"Книги / журналы",
"Поиск попутчиков",
"Другое",
"CD / DVD / пластинки / кассеты",
"Поиск групп / музыкантов"
            };
            string[] oneSixCollection =
            {
               "Легковые автомобили",
"Мото",
"Другой транспорт",
"Автозапчасти и аксессуары",
"Грузовые автомобили",
"Автобусы ",
"Водный транспорт ",
"Прицепы",
"Шины, диски и колёса",
"Спецтехника",
"Сельхозтехника",
"Воздушный транспорт",
"Запчасти для спец / с.х. техники",
"Прочие запчасти",
"Мотозапчасти и аксессуары"
            };
            string[] secondSixCollection = {"Собаки",
"Кошки",
"Другие  животные",
"Зоотовары",
"Бюро находок",
"Вязка",
"Животные даром",
"Птицы",
"Грызуны",
"Рептилии",
"Аквариумистика",
"Сельхоз животные"};

            switch (DefaultSectionList.SelectedIndex)
            {
                case 0:
                    SelectAggregate(firstCollection);
                    break;
                case 1:
                    SelectAggregate(secondCollection);
                    break;
                case 2:
                    SelectAggregate(threeCollection);           
                    break;
                case 3:
                    SelectAggregate(forCollection);
                    break;
                case 4:
                    SelectAggregate(fiveCollection);
                    break;
                case 5:
                    SelectAggregate(noneCollection);
                    break;
                case 6:
                    SelectAggregate(teCollection);
                    break;
                case 7:
                    SelectAggregate(sixCollection);
                    break;
                case 8:
                    SelectAggregate(oneSixCollection);
                    break;
                case 9:
                    SelectAggregate(secondSixCollection);
                    break;
                default:
                    break;
            }
        }

        private async void ProductSectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndividualProductSectionList.Items.Clear();
            string currentUrl = "";
            switch (DefaultSectionList.SelectedIndex)
            {
                case 0:
                    SelectFromSection((int)SectionID.FirstSection, moveUrl: ref currentUrl);
                    break;
                case 1:
                    SelectFromSection((int)SectionID.SecondSection, moveUrl: ref currentUrl);
                    break;
                case 2:
                    SelectFromSection((int)SectionID.ThreeSection, moveUrl: ref currentUrl);
                    break;
                case 3:
                    SelectFromSection((int)SectionID.ForSection, moveUrl: ref currentUrl);
                    break;
                case 4:
                    SelectFromSection((int)SectionID.FiveSection, moveUrl: ref currentUrl);
                    break;
                case 5:
                    SelectFromSection((int)SectionID.SixSection, moveUrl: ref currentUrl);
                    break;
                case 6:
                    SelectFromSection((int)SectionID.SevenSection, moveUrl: ref currentUrl);
                    break;
                case 7:
                    SelectFromSection((int)SectionID.EightSection, moveUrl: ref currentUrl);
                    break;
                case 8:
                    SelectFromSection((int)SectionID.NineSection, moveUrl: ref currentUrl);
                    break;
                case 9:
                    SelectFromSection((int)SectionID.TenSection, moveUrl: ref currentUrl);
                    break;
                default:
                    break;
            }

            OldUrl = currentUrl;

            if (NewUrl != null)
            {
                OldUrl = NewUrl;
            }
            await getHtmlParse.TestParse(urls: OldUrl, numericUpDown1.Value);
            var getIndividualNamesAds = await getHtmlParse.GetIndividuaNameslAds();
            #region MyRegion
            //for (var i = 0; i < getIndividualNamesAds.Count; i++)
            //{
            //    if (getIndividualNamesAds.Count - 1 == i)
            //    {
            //        break;
            //    }
            //    string getOneTest = getIndividualNamesAds[i].Replace("\t", "").Replace("\n", "");
            //    string getTwoTest = getIndividualNamesAds[++i].Replace("\t", "").Replace("\n", "");
            //    var ss = getOneTest.Last();
            //    var getTwoTeaast = getTwoTest.Last();

            //    if (getOneTest != getTwoTest && getOneTest.Last() != ' ' || getTwoTest.Last() != ' ')  
            //    {
            //        IndividualProductSectionList.Items.Add(getIndividualNamesAds[i].Replace("\t", ""));
            //    }
            //}
            #endregion
            for (var i = 0; i < getIndividualNamesAds.Count; i++)
            {
                IndividualProductSectionList.Items.Add(getIndividualNamesAds[i]);
            }
            getHtmlParse.Dispose();
        }

        private async void IndividualProductSectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewUrl = OldUrl;
            await getHtmlParse.TestParse(urls: NewUrl, numericUpDown1.Value);
            var getIndividualUrlsAds = await getHtmlParse.GetIndividualUrlsAds();
            for (var i = 0; i < getIndividualUrlsAds.Count; i++)
            {
                listBox1.Items.Add(getIndividualUrlsAds[i]);
            }
            int indexTest = IndividualProductSectionList.SelectedIndex;
            NewUrl = getIndividualUrlsAds[IndividualProductSectionList.SelectedIndex];
            getHtmlParse.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LocalFiles.SaveAndWrite saveAndWrite = new LocalFiles.SaveAndWrite();
            //  saveAndWrite.Writed();
            saveAndWrite.DataGridView = dataGridView1;
            saveAndWrite.Writed("kek");
            saveAndWrite.Dispose();
        }

        private void BackGroundColorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (backGroundColorCheck.Checked && colorDialogGridBackground.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.BackgroundColor = colorDialogGridBackground.Color;
                backGroundColorCheck.Checked = false;
            }
        }
    }
}
