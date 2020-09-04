using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlxParser.SelectDataSection
{
    class Section
    {

        public string[] firstSection { get; private set; } =
        {
            "https://www.olx.kz/uslugi/",
            "https://www.olx.kz/uslugi/razvlecheniya/",
            "https://www.olx.kz/uslugi/krasota-i-zdorove/",
            "https://www.olx.kz/uslugi/dlya-biznesa/",
            "https://www.olx.kz/uslugi/avto-uslugi/",
            "https://www.olx.kz/uslugi/bytovye-uslugi/",
            "https://www.olx.kz/uslugi/perevozki-i-skladskie-uslugi/",
            "https://www.olx.kz/uslugi/remont-i-obsluzhivanie-tehniki/",
            "https://www.olx.kz/uslugi/remont-i-stroitelstvo/",
            "https://www.olx.kz/uslugi/uborka/",
            "https://www.olx.kz/uslugi/ohrana-bezopasnost/",
            "https://www.olx.kz/uslugi/delovye-uslugi/",
            "https://www.olx.kz/uslugi/obuchenie-kursy-repetitorstvo/",
            "https://www.olx.kz/uslugi/studii-zvukozapisi/",
            "https://www.olx.kz/uslugi/foto-i-videosemka/",
            "https://www.olx.kz/uslugi/turizm-immigratsiya/",
            "https://www.olx.kz/uslugi/setevoy-marketing/",
            "https://www.olx.kz/uslugi/prokat-tovarov/",
            "https://www.olx.kz/uslugi/uslugi-dlya-zhivotnyh/",
            "https://www.olx.kz/uslugi/prochie-uslugi/",
            "https://www.olx.kz/uslugi/byuro-nakhodok-v-uslugah/"
        };

        public string[] secondSection { get; private set; } =
        {
            "https://www.olx.kz/nedvizhimost/",
            "https://www.olx.kz/nedvizhimost/kvartiry/",
            "https://www.olx.kz/nedvizhimost/doma/",
            "https://www.olx.kz/nedvizhimost/komnaty/",
            "https://www.olx.kz/nedvizhimost/zemlya/",
            "https://www.olx.kz/nedvizhimost/garazhi-stoyanki/",
            "https://www.olx.kz/nedvizhimost/kommercheskie-pomeshcheniya/",
            "https://www.olx.kz/nedvizhimost/zarubezhnaya-nedvizhimost/"
        };

        public string[] threeSection { get; private set; } =
        {
            "https://www.olx.kz/elektronika/",
            "https://www.olx.kz/elektronika/telefony-i-aksesuary/",
            "https://www.olx.kz/elektronika/kompyutery-i-komplektuyuschie/",
            "https://www.olx.kz/elektronika/foto-video/",
            "https://www.olx.kz/elektronika/tv-videotehnika/",
            "https://www.olx.kz/elektronika/audiotehnika/",
            "https://www.olx.kz/elektronika/igry-i-igrovye-pristavki/",
            "https://www.olx.kz/elektronika/planshety-el-knigi-i-aksessuary/",
            "https://www.olx.kz/elektronika/noutbuki-i-aksesuary/",
            "https://www.olx.kz/elektronika/tehnika-dlya-doma/",
            "https://www.olx.kz/elektronika/tehnika-dlya-kuhni/",
            "https://www.olx.kz/elektronika/klimaticheskoe-oborudovanie/",
            "https://www.olx.kz/elektronika/individualnyy-uhod/",
            "https://www.olx.kz/elektronika/aksessuary-i-komplektuyuschie/",
            "https://www.olx.kz/elektronika/prochaja-electronika/",
            "https://www.olx.kz/elektronika/noutbuki-i-aksesuary/",
            "https://www.olx.kz/uslugi/remont-i-obsluzhivanie-tehniki/"
        };

        public string[] forSection { get; private set; } =
        {
            "https://www.olx.kz/dom-i-sad/",
            "https://www.olx.kz/dom-i-sad/komnatnye-rasteniya/",
            "https://www.olx.kz/dom-i-sad/mebel/",
            "https://www.olx.kz/dom-i-sad/predmety-interera/",
            "https://www.olx.kz/dom-i-sad/prochie-tovary-dlya-doma/",
            "https://www.olx.kz/dom-i-sad/produkty-pitaniya-napitki/",
            "https://www.olx.kz/dom-i-sad/hozyaystvennyy-inventar/",
            "https://www.olx.kz/dom-i-sad/sadovyy-inventar/",
            "https://www.olx.kz/dom-i-sad/kantstovary-rashodnye-materialy/",
            "https://www.olx.kz/dom-i-sad/stroitelstvo-remont/",
            "https://www.olx.kz/dom-i-sad/instrumenty/",
            "https://www.olx.kz/dom-i-sad/posuda-kuhonnaya-utvar/",
            "https://www.olx.kz/dom-i-sad/sad-ogorod/"
        };

        public string[] fiveSection { get; private set; } =
        {
            "https://www.olx.kz/rabota/",
            "https://www.olx.kz/rabota/gostinitsy-turizm-otdykh/",
            "https://www.olx.kz/rabota/bary-restorany-kafe/",
            "https://www.olx.kz/rabota/meditsina-farmatsevtika/",
            "https://www.olx.kz/rabota/krasota-fitnes-sport/",
            "https://www.olx.kz/rabota/transport-logistika/",
            "https://www.olx.kz/rabota/obrazovaniye-nauka/",
            "https://www.olx.kz/rabota/proizvodstvo-energetika/",
            "https://www.olx.kz/rabota/roznichnaya-torgovlya-prodazhi-zakupki/",
            "https://www.olx.kz/rabota/marketing-reklama-dizayn/",
            "https://www.olx.kz/rabota/internet-it-kompyutery-telekom/",
            "https://www.olx.kz/rabota/finansy-bukhgalteriya-ekonomika/",
            "https://www.olx.kz/rabota/administrativnyy-personal/",
            "https://www.olx.kz/rabota/stroitelstvo-arkhitektura/",
            "https://www.olx.kz/rabota/drugiye-sfery-deyatelnosti/",
            "https://www.olx.kz/rabota/ohrana-bezopasnost/",
            "https://www.olx.kz/rabota/kultura-iskusstvo-razvlecheniya/",
            "https://www.olx.kz/rabota/domashniy-personal/",
            "https://www.olx.kz/rabota/nedvizhimost/",
            "https://www.olx.kz/rabota/servis-i-byt/",
            "https://www.olx.kz/rabota/nachalo-karyery-stazhirovka-praktika/",
            "https://www.olx.kz/rabota/banki-strakhovaniye/",
            "https://www.olx.kz/rabota/yuristy-advokaty-notariusy/",
            "https://www.olx.kz/rabota/dobycha-syrya/",
            "https://www.olx.kz/rabota/hr-upravleniye-personalom-treningi/",
            "https://www.olx.kz/rabota/sto-avtomoyki-servisnoye-obsluzhivaniye/",
            "https://www.olx.kz/rabota/top-menedzhment-rukovodstvo-vysshego-zvena/",
            "https://www.olx.kz/rabota/gosudarstvennaya-sluzhba-nekommercheskiye-organizatsii/",
            "https://www.olx.kz/rabota/selskoye-khozyaystvo-agrobiznes-lesnoye-khozyaystvo/",
            "https://www.olx.kz/rabota/rabota-za-rubezhom/",
            "https://www.olx.kz/rabota/setevoy-marketing/"
        };

        public string[] sixSection { get; private set; } =
        {
            "https://www.olx.kz/moda-i-stil/",
            "https://www.olx.kz/moda-i-stil/podarki/",
            "https://www.olx.kz/moda-i-stil/odezhda/",
            "https://www.olx.kz/moda-i-stil/dlya-svadby/",
            "https://www.olx.kz/moda-i-stil/aksessuary/",
            "https://www.olx.kz/moda-i-stil/naruchnye-chasy/",
            "https://www.olx.kz/moda-i-stil/moda-raznoe/",
            "https://www.olx.kz/moda-i-stil/krasota-zdorove/",
        };

        public string[] sevenSection { get; private set; } =
        {
            "https://www.olx.kz/detskiy-mir/",
            "https://www.olx.kz/detskiy-mir/detskie-kolyaski/",
            "https://www.olx.kz/detskiy-mir/detskaya-mebel/",
            "https://www.olx.kz/detskiy-mir/prochie-detskie-tovary/",
            "https://www.olx.kz/detskiy-mir/detskie-avtokresla/",
            "https://www.olx.kz/detskiy-mir/detskaya-odezhda/",
            "https://www.olx.kz/detskiy-mir/detskaya-obuv/",
            "https://www.olx.kz/detskiy-mir/igrushki/",
            "https://www.olx.kz/detskiy-mir/kormlenie/",
            "https://www.olx.kz/detskiy-mir/tovary-dlya-shkolnikov/",
            "https://www.olx.kz/detskiy-mir/detskiy-transport/"
        };

        public string[] eightSection { get; private set; } =
        {
            "https://www.olx.kz/hobbi-otdyh-i-sport/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/antikvariat-kollektsii/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/sport-otdyh/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/bilety/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/muzykalnye-instrumenty/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/knigi-zhurnaly/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/poisk-poputchikov/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/drugoe/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/cd-dvd-plastinki/",
            "https://www.olx.kz/hobbi-otdyh-i-sport/poisk-grupp-muzykantov/"
        };

        public string[] nineSection { get; private set; } =
        {
            "https://www.olx.kz/transport/",
            "https://www.olx.kz/transport/legkovye-avtomobili/",
            "https://www.olx.kz/transport/moto/",
            "https://www.olx.kz/transport/drugoy-transport/",
            "https://www.olx.kz/transport/avtozapchasti-i-aksessuary/",
            "https://www.olx.kz/transport/gruzovye-avtomobili/",        
            "https://www.olx.kz/transport/avtobusy/",
            "https://www.olx.kz/transport/vodnyy-transport/",
            "https://www.olx.kz/transport/pritsepy/",
            "https://www.olx.kz/transport/shiny-diski-i-kolesa/",
            "https://www.olx.kz/transport/spetstehnika/",
            "https://www.olx.kz/transport/selhoztehnika/",
            "https://www.olx.kz/transport/vozdushnyy-transport/",
            "https://www.olx.kz/transport/zapchasti-dlya-spets-sh-tehniki/",
            "https://www.olx.kz/transport/prochie-zapchasti/",
            "https://www.olx.kz/transport/motozapchasti-i-aksessuary/"
        };

        public string[] tenSection { get; private set; } =
        {
            "https://www.olx.kz/zhivotnye/",
            "https://www.olx.kz/zhivotnye/sobaki/",
            "https://www.olx.kz/zhivotnye/koshki/",
            "https://www.olx.kz/zhivotnye/drugie-zhivotnye/",
            "https://www.olx.kz/zhivotnye/tovary-dlya-zhivotnyh/",
            "https://www.olx.kz/zhivotnye/byuro-nahodok/",
            "https://www.olx.kz/zhivotnye/vyazka/",
            "https://www.olx.kz/zhivotnye/zhivotnye-darom/",
            "https://www.olx.kz/zhivotnye/ptitsy/",
            "https://www.olx.kz/zhivotnye/gryzuny/",
            "https://www.olx.kz/zhivotnye/reptilii/",
            "https://www.olx.kz/zhivotnye/akvariumnye-rybki/",
            "https://www.olx.kz/zhivotnye/selskohozyaystvennye-zhivotnye/",
        };

        //enum SectionID
        //{
        //    FirstSection = 1,
        //    SecondSection,
        //    ThreeSection,
        //    ForSection,
        //    FiveSection,
        //    SixSection,
        //    SevenSection,
        //    EightSection,
        //    NineSection,
        //    TenSection
        //};
    }
}
