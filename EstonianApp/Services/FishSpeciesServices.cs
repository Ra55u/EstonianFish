using EstonianApp.Models;


namespace EstonianApp.Services
{
    internal static class FishService
    {
        private static List<Fish> fish = new()
        {


                new()
                {
                    Name = "Ahven",
                    Keywords="",
                    Subtitle="Ahven ehk harilik ahven (Perca fluviatilis) on ahvenlaste sugukonda ahvena perekonda kuuluv röövkala.",
                    HeroImage = "Ahven.jpg",
                    Description = "Ahven on levinud kogu Euroopas (välja arvatud Pürenee poolsaar, Itaalia, Island, Šotimaa ja Norra), Taga-Kaukaasias ning Põhja-Aasias. Venemaal puudub ta vaid Amuuri jõgikonnas ja Kolõma jõest ida pool. Ta elab paljusugustes mage-, riim- ja tumedaveelistes ning happelistes veekogudes. Ahven võib vähendada metaani eritumist järve toitumisahela muutuste kaudu. Eestis on ahven tavaline kala, mida püütakse ka töönduslikult.\r\n\r\nBalhašis ei ela harilik ahven, vaid selle sugulasliik balhaši ahven. Põhja-Ameerikas Suure järvistu vesikonnas elab teine sugulasliik kollane ahven, keda on käsitletud ka hariliku ahvena alamliigina.\r\n\r\nAhven on ilus ja ereda värvusega kala. Tema selg on tumeroheline, küljed rohekaskollased, 5–9 tumeda ristvöödiga. Saba- ja pärakuuim ning kõhuuimed on erepunased, rinnauimed kollased. Eesmine seljauim on sinakashall, suure musta laiguga tagaosas, tagumine seljauim rohekaskollane. Silmad on oranžid. Ahvena värvus oleneb ka elukohast, näiteks turbajärvedes on ta täiesti tume.\r\n\r\nAhven moodustab suurtes veekogudes harilikult kaks vormi: rohuahven, kes elab kalda ääres, ja suur süvaveeahven. Rohuahven kasvab aeglasemalt ja on väiksem. Põhiosa tema toidust moodustavad zooplankton ja putukavastsed. Süvaveeahven kasvab kiiremini ja suuremaks, mitte niivõrd pikemaks kui laiemaks ja paksemaks, mistõttu tundub küürakana.\r\n\r\nAhven on tavaliselt kuni 2 kg raskune (üksikud isendid on üle 4 kg raskused) ja kuni 50 cm pikkune. Ta võib elada kuni 20–25-aastaseks. Eestis ahvena alammõõduks loetakse 19 cm kogupikkusest või 16 cm sabauimeni, siseveekogudes alammõõt puudub.[2]. Ahvenat kasvatatakse Euroopas hõrgu maitse pärast.[3]\r\n\r\nIsasahvenad saavad suguküpseks varakult: 1-2-aastaselt. Emased suguvõimestuvad 3-4-aastaselt.\r\n\r\nEmasahven koeb olenevalt suurusest 12–200 tuhat marjatera. Kudemiskoha suhtes pole ahven valiv, kudeda kõlbab enam-vähem ükskõik millisele objektile. Kudu kujutab endast sültjat õõnsat võrkseinaga toru, mis meenutab pitslinti. Väikestel isenditel on see lint 12–40 cm pikkune, suurtel isenditel üle meetri. Pikemad lindid koetakse enamasti sügavamale. Marjaterad paiknevad mõnekaupa ümber \"võrgusilmade\". Nad on umbes 3,5 mm läbimõõduga ja rebus on suur õlitilk. Sültja massi eesmärk on nähtavasti kaitsta mune hallitusseente ja mõne vaenlase eest.\r\n\r\nRöövtoidule võivad noorkalad üle minna juba 4 cm pikkuselt, aga harilikult juhtub see 10 cm pikkuselt. ",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/6/62/Perca_fluviatilis-female_Siverskiy_Donets_River_Ukraine.jpg",
                        "https://p.ohtuleht.ee/58/i/2016/6/26/yefoesl5.y5w.jpg"
                    }
                },
                new()
                {
                    Name = "Haug",
                    Keywords="",
                    Subtitle = "Haug ehk harilik haug ehk havi (Esox lucius) on hauglaste sugukonda haugi perekonda kuuluv röövkala. ",
                    HeroImage = "Haug.jpg",
                    Description = "Haug on meie sisevete levinumaid kalu. Mõnes järves on ta koguni ainuke kalaliik. Ta on suur ja toekas kala, kelle pikkus võib ulatuda kuni meetrini. Haugi piklik keha on läbilõikes ovaalse kujuga, pea on pikk, suured silmad asetsevad suhteliselt kõrgel ja suur suu on pardinokataoliselt lapergune. Selja- ja pärakuuim asetsevad vastakuti ja sabauime lähedal. Värvuselt on ta mustjasroheline kuni rohekashall, küljed heledamad, kõht on valkjas. Külgedel on heledatest laikudest triipudeni varieeruv muster, mis on suurepärane kohastumus eluks veetaimede keskel.\r\n\r\nHaug asustab peaaegu kõiki Eesti siseveekogusid, kuid ta on võimeline elama ka nõrgalt soolases merevees. Haug on erakliku eluviisiga kala, kes veedabki aega põhiliselt veetaimetihnikus saaki varitsedes. Seda tegevust kergendab kala kohta terav nägemine: haugi silm seletab kuni 2,5 m kaugusele, seega on ta rangelt päevase eluviisiga. Saaki silmanud, teeb ta selle suunas välkkiire sööstu. Ohvriks langevad kõikvõimalikud väiksemad kalad, peamiselt ahvenad, kiisad, viidikad ja latikad. Suuremat kasvu haugide jõud käib üle ka pardipoegadest, konnadest ja pisiimetajatest. Haug neelab oma saagi tervelt, enamasti pea ees. Tihti tarvitatakse toiduks ka väiksemaid ja nõrgemaid liigikaaslasi.\r\n\r\nHaugid koevad kohe peale jäälagunemist aprillist maini. Koelmuteks on enamasti suurveest üleujutatud luhad, kus on rikkalikult taimestikku ja kus vesi on juba mõnevõrra soojenenud. Suurvesi on kudemisel oluline tegur ning veevaestel aastatel jätab suur hulk hauge lihtsalt kudemata. Kudemise ajaks kogunevad haugid gruppidesse, kuhu kuulub üks emaskala ja mitu isast. Pulm hajutab tavaliselt üliettevaatliku kala tähelepanu sedavõrd, et sel ajal on haug kerge saak röövpüüdjatele, seda enam, et kudemine toimub kuni 0,5 m sügavuses vees. Kudemisrühmad pole püsivad, vaid liiguvad pidevalt ühest kohast teise kattes tunnis mitusada meetrit. Isashaugid löövad kudemise ajal sabaga tugevalt laksu, mis on kuulda kuni 100 m kaugusele. Mari koetakse eelmise aasta surnud taimestikule. Vastsed kooruvad olenevalt veetemperatuurist 12...25 päeva pärast. Maimud toituvad alguses selgrootutest, hiljemalt oma esimese suve lõpuks lähevad üle röövtoidule.\r\n\r\nHaug on meie sisevete tähtsamaid püügikalu, ta liha on rasvavaene ja sobib hästi dieettoiduks. Hauge on kasvatatud ka tiikides ning ta marja inkubeeritakse ka kunstlikult. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://et.wikipedia.org/wiki/Fail:Hecht.jpg",
                        ""
                    }
                },
                new()
                {
                    Name = "Latikas",
                    Keywords="Latikas on karpkalalaste sugukonda latika perekonda kuuluv kala",
                    Subtitle = "",
                    HeroImage = "Latikas.jpg",
                    Description = "Latikas on kõrget kasvu, külgedelt silmatorkavalt lamenenud kehaga kala. Selja poolt tume rohekas-pruunikas kuni mustjas-sinine. Küljed hõbedased, vanematel kaladel pronksjad, kõht valkjas. Noored latikad on sihvakama kehaga ja külgedelt hõbedased. Uimed hallid või tumehallid, vahel peaaegu mustad, ilma punaka toonita. Isastel kudemisajal peas ja keha eesosas silmatorkav helmeskate. Latikas on pikaealine kala, vanuse maailmarekordiks 32 aastat. Eesti rekord: kaal 5,5 kg, pikkus 58 cm, kõrgeim vanus 25 aastat.\r\n\r\nLatikas elab siseveekogudes eelistades suuri, madalaid, rohketoitelisi järvi ja aeglaselt voolavaid jõgesid ning vähesel määral ka rannikumeres. Latikad elavad peaaegu kogu Euroopas - ainult päris Lõuna-Euroopas pole neid leitud. Latikad on veekogu põhja hoiduvad parvekalad. Noored kalad sulistavad rohkem kaldavees taimede vahel. Nad püüavad söögiks planktonit ja pisikesi veeloomi. Suuremad kalad rändavad sügavamasse vette, et seal mudasel põhjal toitu otsida. Latikate lemmiktoiduks on suured surusääse vastsed. Latikatel on söögiaeg ainult kaks korda päevas - hommikul ja õhtul.\r\n\r\nJärglasi võib latikas saada alles alates kuuendast eluaastast. Paljunemise ajaks otsib iga isane endale sobiva territooriumi. Selleks on lihtsalt üks kuni meetri sügavuses vees asuv maatükk, millel on surnud taimeollust, eelistatavalt tarnasid ja mida ta oma silmadega vaatama ulatub. Sinna tuleb ka emane ning seal toimubki kudemine. Emakala mari kleepub taimedele ja haub seal umbes 10 ööpäeva. Kudemise ajaks peab vesi olema juba üsna soe - umbes 15 °C. Suuremad latikad koevad natuke varem, aga üle 3 kilo raskused ei koe üldse, vaid peavad väärikalt pensionipõlve.\r\n\r\nLatika vaenlasteks on suured röövkalad ja toidukonkurentideks kiisad ning angerjad. Ta on Eesti sisevete üks tähtsamaid püütavaid kalu. Latikast saab valmistada palju toite, eriti maitsev on kuumsuitsu latikas. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://kalafoorum.ee/portaal/wp-content/uploads/2022/05/latikas.jpg",
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/AbramisBramaWaal.JPG/220px-AbramisBramaWaal.JPG"
                    }
                },
                new()
                {
                    Name = "Linask",
                    Keywords="",
                    Subtitle = "Linask on mageveekala, kes kuulub kiiruimsete klassi, karpkalaliste seltsi ja karpkalaliste sugukonda.",
                    HeroImage = "Linask.jpg",
                    Description = "Linask on ilus paks ja ümar kala, lühikese ning jämeda sabavarrega. Keha katab tugev ja läbipaistev limane marrasknahk, mille all paiknevad katusekivitaoliselt üksteist katvad väikesed soomued. Suu on väike, ülespoole suunatud ja paksude lihavate huultega. Ülahuulel paiknevad kaks väikest poiset. Värvus sõltub rohkem elupaigast, kuid tavaliselt on ta selg tõmmu-oliivroheline ja metalse läikega, küljed aga kollakasrohelised, kõht heledam. Kõhuuimed on tugevad ning lusikakujulised, aidates kalal \"jalutada\" mööda mudast põhja. Linaski kehapikkus on enamasti kuni 45 cm ja kehamass kuni 2 kg.\r\n\r\nTa on levinud kõikjal Eestis. Linaski koduks on mudase põhjaga, taimestikurikkad ja soojad järved ja aeglase vooluga jõed, kus ta liigub põhiliselt põhjalähedastes mudastes veekihtides. Mõnikord on teda leitud ka riimveelisest rannikumerest. Ta on väga vähenõudlik kala, kes talub hästi hapnikuvaest ja haput vett. Südasuvel, kui veekogusid võib ähvardada ülekuumenemine ja ärakuivamine, langeb linask suveunne. Ta poeb sügavale mutta, kattub paksu limakihiga ja jääb paremate aegade ootele.\r\n\r\nLinask on väga vastupidav. Arvatakse, et linask suudab söömata vastu pidada kuni 8 kuud. On tehtud katseid, kus linask pidas veest välja võetuna ja märja sambla sisse mähituna vastu 46 tundi. Temperatuuril 8°C jääb linask juba talveunne.\r\n\r\nLinaski toidusedelisse kuuluvad peamiselt selgrootud loomad: surusääsklaste vastsed, kirpvähid ja limused, kuid ta võib neelata ka kalamarja, vastseid ja väikesi kalu ning lisaks ka taimset toitu.\r\n\r\nLinask koeb keset suve juuni lõpust kuni augustini, kui vesi on maksimaalselt soe. Kudemispaik asub kalda lähedal ning on tuulte eest kõrgema taimestikuga hästi varjatud. Mari koetakse veetaimedele ning see areneb 3...6 päeva kuni vastsete koorumiseni. Algul on vastsed liikumatud ja elavad taimedel rippudes, kuid nädala kuni paari pärast hakkavad ringi liikuma ja iseseisvalt toituma. Suguküpseks saab linask 4...6 aasta vanuselt ja ta eluiga ulatub umbes 10 aastani.\r\n\r\nLinask on kõrgelt hinnatud maitsva liha tõttu. Linaskit kasvatatakse ka kunstlikult, tavaliselt lisakalana karbitiikides.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/e/eb/Tinca_tinca_Prague_Vltava_1.jpg/220px-Tinca_tinca_Prague_Vltava_1.jpg",
                        "http://admin.entsyklopeedia.ee/EME%20II/publicthumbs/linask_S.png"
                    }
                },
                new()
                {
                    Name = "Säinas",
                    Keywords="",
                    Subtitle = "Säinas (Leuciscus idus) on karpkalaliste seltsi kuuluv kala.",
                    HeroImage = "Säinas.jpg",
                    Description = "Säinas on keskmiselt 40 cm pikkune kala mustjasrohelise selja, hõbedaste külgede ja valge, ümara kõhuga. Saba ja seljauim lillakashallid, teised uimed punased. Säinas võib elutseda mitmekesistes tingimustes: aeglase vooluga jõgedes ja nendega seotud järvedes, aga ka nõrga soolsusega merelahtedes. \r\n\r\n    Ta on levinud Eesti rannikumeres kõikjal, kuigi paljudes kohtades vaid üksikutena, sagedasem Saaremaa lõunarannikul ja Väinameres. Rohkem on säinast Suure Emajõega seotud järvedes, Peipsis ja Võrtsjärves. Üldiselt meeldivad talle aeglase vooluga jõed ja järved ning ta on suhteliselt paikne kala, kes ei soorita ulatuslikke rändeid. Säinas on kivilembese ja taimelembese kala vahepealne, kuid võimaluse korral näib ta siiski eelistavat kõva põhja. \r\n\r\n    Säina toidulaud on omapärane - esikohal on limused (lamekarp, rannakarp, vesitigu ja vesiking) ja kirpvähilised. Suured säinad võivad mõnikord olla ka röövtoidulised, tarvitades peamiselt luukaritsat. \r\n\r\n    Kudemise ajal muutub säinas ilusaks: keha omandab metalse värvuse, lõpusekaaned ja pea tunduvad kuldsetena ja uimed värvuvad erepunaseks. Isastel on peas ja kehal helmeskate. Kudemine algab varsti peale jääminekut aprillis-mais ning toimub tavaliselt kohe pärast haugi kudemist. Koelmud paiknevad madalas, tavaliselt alla 1 m sügavuses vees. Koetud ja viljastatud mari areneb kividel või eelmise aasta veetaimedel. Vastsed kooruvad paari nädala pärast. Vastne kleepub alguses taimedele, kuid alustab juba õige pea aktiivset ujumist. Säinas saab suguküpseks 5...7 aasta vanusena. Ta elab enamasti kuni 15 aastaseks.\r\n\r\n    Säinas on hinnatud spordikala, kuid süües on ta suhteliselt luine. Üksikutesse meie veekogudess on säinaid ka asustatud. Veekogudes väärib säinas tähelepanu kui limustevarude kasutaja. Looduskaitse alla ei kuulu.\r\n",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/b/b4/Aland.jpg",
                        "https://www.kalapeedia.ee/u/kalad/s%C3%A4inas.jpg"
                    }
                },
                new()
                {
                    Name = "Angerjas",
                    Keywords="",
                    Subtitle = "Euroopa angerjas (ka harilik angerjas) (Anguilla anguilla) on angerlaste sugukonda angerja perekonda kuuluv kala.",
                    HeroImage = "Angerjas.jpg",
                    Description = "Angerjat tunneb arvatavasti küll igaüks. Kes ei ole seda libedat, madujat kala juhtunud käes hoidma, on tõenäoliselt vähemalt tema hõrku liha delikatessina proovinud. Emased kalad kasvavad meil kuni 1 m pikkuseks ja paarikiloseks, isased jäävad aga pea poole väiksemaks.\r\n\r\nAngerja puhul on eriti omapäraseks tema elukäik. Nimelt hakkavad kõigi Euroopas elavate angerjate maimud arenema ühes kohas: Sargasso meres. Seal tõusevad vähem kui ühe sentimeetri pikkused vastsed sügavamatest veekihtidest pinnale ja kanduvad Golfi hoovusega ida suunas. See mitme tuhande kilomeetri pikkune teekond võtab aega 2,5...3 aastat. Euroopa läänerannikule jõudnud läbipaistvad 75 millimeetrised vastsed katkestavad toitumise ja moonduvad nn klaasangerjaiks. Järgnevalt hakkavad nad tungima jõgedesse ja jõgede kaudu järvedesse, Eestis peamiselt Pärnu jõgikonda (Peipsis ja Võrtsjärves kasvatatakse sissetoodud angerjaid). Suguküpseiks saavad isased 5...7, emased 7...12 aastase magevee-elu järel. Huvitav on ka see, et kuni 24 cm pikkustel (kolmeaastastel) angerjatel pole sugu veel kindel. Magevees ning vähesoolases vees Läänemere rannikul elavad peamiselt vaid emased angerjad, isased Läänemerre üldiselt ei satu.\r\n\r\nAngerjad on rangelt öise eluviisiga. Kogu valge aja veedavad nad veekogu põhjamudas, kust õhtu saabudes jahile siirduvad. Angerjas on röövtoiduline, toitudes vastavalt oma suurusele jõukohasest saagist: veeputukate vastsetest, ussidest, väikestest kaladest.\r\n\r\nPiisavalt suureks kasvanud angerjatega toimub taas muutus: küljed ja kõht omandavad hõbedase värvuse, silmas muutuvad süvamerekaladele omaselt suureks ning nad lahkuvad magedast veest ookeani. Kuue tuhande kilomeetrise retke Soome lahest Sargasso merre läbivad meie angerjad pooleteise aastaga. Märgistamise teel on välja selgitatud, et soodsates tingimustes läbivad nad kuni 50 km ööpäevas.\r\n\r\nKudemine toimub sügaval, 500...1000 meetri sügavusel Sargasso meres. Angerjad koevad vaid üks kord elus, nad ei rända enam tagasi vaid hukkuvad sealsamas.\r\n\r\nAngerjas on väga maitsva lihaga kala (eriti suitsutatult või marineeritult), tema liha sisaldab kuni 40% rasva. Vaatamata sellele, et viimase 70 aasta jooksul on Võrtsjärve asustatud miljoneid maime, on angerja püüdmisel kehtestatud piiranguid. Angerja arvukus on viimase 50 aastaga tugevalt langenud, looduskaitse alla hetkel siiski ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Anguilla_anguilla.jpg/240px-Anguilla_anguilla.jpg",
                        "https://nami-nami.ee/files//news/3440/ilseangerjasterve.jpg"
                    }
                },
                new()
                {
                    Name = "Meriforell",
                    Keywords="",
                    Subtitle = "",
                    HeroImage = "Meriforell.jpg",
                    Description = "Meriforell on jässaka kehaga, suhteliselt suure peaga kala, kes asustab pea kogu Põhja-Euroopa rannikut kuni Murmanskini ning kogu Läänemerd. Meriforell on siirdekala, see tähendab, et oma elu veedab ta põhiliselt meres, kudema rändab aga jõgedesse. Eestis sobivad talle enam-vähem kõik merre suubuvad jõed, seda enam, et jõgede suhtes pole ta kapriisne. Meriforell talub pruuni ja kergelt hapukat jõevett, samuti ei põlga ta ära isegi päris kitsaid ojakesi, kuid vesi olgu külm ja hapnikurikas.\r\n\r\nSoodsatel aastatel algab meriforelli jõkketõus juba augustis, isegi juuli lõpus. Rännutuhinas on nad võimelised ületama kuni 1,5 m kõrguseid tõkkeid - jugasid ja tamme. Kudemine toimub aga alles siis, kui vesi on muutunud jahedaks (4...6 °C). Tavaliselt leiab see aset oktoobris-novembris. Jõkke jõudnud, valib isane kala välja sobiva paiga võimalikult kruusases ja allikarohkes jõelõigus ning jääb paarilise ootele. Samal ajal kaevab emane meriforell valmis pikliku pesalohu, millesse ta marja koeb. Meriforelli kudemisseltskond koosneb 1 emaskalast ning 1...5 isasest ning partnereid ei vahetata. Kui mari on koetud ja viljastatud, katab emane forell selle kruusaga ning siirdub kaaslaste saatel järgmist lohku valmistama.\r\n\r\nMarjaterast koorub vastne alles järgmisel kevadel aprillis-mais. Noored meriforellid toituvad alguses selgrootutest, kuid lähevad ruttu üle röövtoidule ning harvad pole ka juhud, kui ohvriks langeb oma liigikaaslane. Kui meriforellijõkke satub kudema lõhi, siis kipub lemmiktoiduks olema lõhemari. Samuti on menüüs koht vihmaussidel ja isegi konnadel. Jões veedab forell keskmiselt 2 aastat, seejärel siirdub ta elama merre.\r\n\r\nMeriforell on truu koduümbrusele. Ta ei rända sünnijõe suudmest väga kaugele, ning 30% meriforellidest suundub kudema samasse jõkke, kus ise ilmale tuli. Esimest korda võtab ta reisi jõkke ette peale kahesuvist mere-elu. Erinevalt paljudest teistest siirdekaladest, ei mõju kudemine talle eriti kurnavalt ning kudemine toimub mitmel aastal.\r\n\r\nMeriforelli maitsev liha on kõrgelt hinnatud, kuid ta on ohus just kudemispaikade hävimise tõttu. Neid ohustavad jõgede tõkestamine tammidega ja metsatööd jõgede kallastel, seetõttu inkubeeritakse marja ja kasvatatakse maime kunstlikult kalakasvandustes. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://www.kalaportaal.ee/images/joomlart/article/8835fed4de3847a26822c5cc338a0cab.jpg",
                        "https://www.kalale.ee/pilt/Failid/Blog/1412154000/medium/14147561002429.jpg"
                    }
                },
                new()
                {
                    Name = "Lõhe",
                    Keywords="",
                    Subtitle = "Lõhe ehk lõhi (Salmo salar) on lõhelaste sugukonda kuuluv kala. Eesti keeles on kasutatud ka nimetusi lohe ja laks. ",
                    HeroImage = "Lõhe.jpg",
                    Description = "Lõhi on suur ja tugev kala, üks suurimaid röövkalu Läänemeres. Iseloomulikuks tunnuseks on rasvauim, mis asub seljauime taga sabauime lähedal. Keha külgedel asetsevad tähnid on põhiliselt X- tähe kujulised ning vaid mõni üksik neist asub küljejoonest allpool. Sabauim on märgatava sälguga. Isastel ilmub kudemise eel alalõuale konksutaoliselt kõverdunud moodustis, mis ei lase kalal suud täielikult sulgeda. Täiskasvanud lõhede  pikkus on  kuni 1 m ja mass kuni 10 kg. Maksimaalne pikkus võib ületada 1,5 m ja mass võib ulatuda 46 kg-ni.\r\n\r\nNoored lõhed elavad algul jões, siis meres ja suguküpsuse saabumisel suunduvad tagasi oma sünnijõgedesse. Eestis on lõhejõed Vasalemma, Pirita, Rutja, Keila, Loobu, Kunda ja Pärnu jõgi ning Valgejõgi. Alates juulikuust suunduvad suguküpsed kalad merest jõgedesse.\r\n\r\nKudemine toimub tavaliselt oktoobris või novembris. Kudemiseks valivad kalad kiirevoolulise kärestikulise koha. Emane kaevab sabalöökidega veekogu põhja pesa ning katab selle pärast marjaheitmist kruusaga. Osa isendeid sureb pärast kudemist, kuna nad on nälginud ning kurnatud. Osa läheb merre, kuid väga vähesed koevad kaks või kolm korda.\r\n\r\nMarja areng kestab ligikaudu viis kuud. Paari sentimeetri pikkused vastsed kooruvad varakevadel, kuid lahkuvad pesast alles kuu - pooleteise pärast. Noori lõhesid kutsutakse tähnikuteks nende ilusa erksa mustri tõttu. Nad veedavad jões üsna paiksena enamasti kaks aastat, toitudes putukavastsetest ja teistest selgrootutest. Selle ajaga kasvavad nad kuni kahekümne sentimeetri pikkuseks. Merre minekul eredad vöödid ning tähnid kaovad ja keha muutub hõbedaseks. Meres kasvavad lõhed kiiresti. Toiduks on peamiselt kilu ja räim ja jahitaktikaks on saakkala jälitamine.  Lõhed saavad suguküpseks tavaliselt mereelu kolmandal aastal ja rändavad oma sünnijõgedesse tagasi. Pulmarüüs lõhe keha tumeneb ning külgedele ja pähe ilmuvad punased ja oranzid tähnid.\r\n\r\nLõhi on väga maitsva ja väärtusliku lihaga. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://www.muurileht.ee/core/media/Atlandi-l%C3%B5he_Foto-www.fjordfishmarket.com_-e1517227276635.jpg",
                        "https://www.kalapeedia.ee/u/kalad/atlandi%20l%C3%B5he.jpg"
                    }
                },
                new()
                {
                    Name = "Merisiig",
                    Keywords="",
                    Subtitle = "Merisiig ehk siig (Coregonus lavaretus lavaretus L.) on kalaliik lõhelaste (Salmonidae) sugukonna siia perekonnast. Merisiig on saleda kehakuju, hõbedaste külgede, tömbi ninamiku, valge kõhu ja väikese peaga kala. Sabavarre alguses on lõheliste seltsile omane rasvauim. Ta asustab kogu Läänemerd ja on üsna tavaline. Eestis elab merisiig kõikides rannikuvetes ning Pärnu ja Narva jões.",
                    HeroImage = "Merisiig.jpg",
                    Description = "Merisiig on saleda kehakujuga, väikese peaga kala. Selg oliivrohekas või tumedam sinakasroheline, küljed hõbedased, kõht valge. Rinna- ja kõhuuimed punakad, tipus tumenevad. Siial on nõrk värske kurgi lõhn. Kehapikkus tavaliselt 40...60 cm ning kaal kuni 3,5 kg. Ta on üsna tavaline kala, kes asustab kogu Läänemerd. Eestis elab siig erineva sagedusega kõikides rannikuvetes ning Pärnu ja Narva jões.\r\n\r\nMerisiig on külma ja selge vee elanik, kes elutseb vähese soolsusega merelahtedes ning jõgede suudmetes. Siiad eelistavad koguneda parvedesse ning liiguvad rohkem põhjalähedastes veekihtides. Kudemiseks võivad nad siirduda jõgedesse, kuid ei pruugi seda teha. Enim meeldivateks kudemispaikadeks on madalad, lainetuse eest kaitstud merelahed, kus on kõva liiva-, kruusa- või kivipõhi. Siiad koevad hilissügisel oktoobri lõpust detsembrini. Kuigi siig on üldiselt päevase eluviisiga, toimub kudemine õhtuhämaruses või öö varjus. Marja ja niisa heitmine toimub veepinnal. Pärast kudemist läheb paar lahku, kumbki osapool leiab omale aga uue partneri. Kogenud kalurid räägivad, et siiad tekitavad veepinnal järsult suunda muutes tugevaid veekeeriseid, mis paiskavad viljastatud marja vees laiali. Sellega kaasnevad veeplartsatused, mille järgi saab siigade pulmaplatsi juba kaugelt kindlaks määrata. Niiviisi jõuavad siia marjaterad veekogu põhjale tugevasti hajutatult ning marjasööjatel on neid raskem kätte saada. Kahjuks on suurimad marjaröövlid siiad ise. Jälgides liigikaaslaste paaritumist, ahmivad nad ahnelt põhjalaskuvaid marjateri. Mari areneb külmas vees kuni kevadeni ja vastsed kooruvad peale jää lagunemist aprillis. Veidi alla 1,5 cm pikkused vastsed on väga head ujujad ja hakkavad parvedesse kogunedes juba ühepäevastena toitu otsima.\r\n\r\nPisikesed siiad toituvad alguses planktonist ja hiljem põhjaloomastikust. Täiskasvanute toiduspekter on lai: siia kuuluvad väikesed limused, hüdraloomad, kirpvähilised ja väikesed kalad (mudilake) ja ka kalamari.\r\n\r\nSiig on kaval kala, kes oskab hästi püüniseid vältida. Ta on osav põgenema mõrdadest ja nootadest, võrkudest hiilib aga lihtsalt mööda. Siia liha peetakse delikatessiks, seda eriti soolatult. Siiavarude suurendamiseks inkubeeritakse marja kunstlikult ning koorunud maimud lastakse merelahtedesse. Looduses ohustab teda talvine veekogude hapnikupuudus. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Sik%2C_Iduns_kokbok.jpg/220px-Sik%2C_Iduns_kokbok.jpg",
                        "https://www.kalapeedia.ee/u/kalad/harilik%20siig.jpg"
                    }
                },
                new()
                {
                    Name = "Vingerjas",
                    Keywords="",
                    Subtitle = "Vingerjas (Misgurnus fossilis) on karpkalaliste seltsi hinklaste sugukonda kuuluv kala.\r\n\r\nVingerjas on 15–30 cm pikkune mageveekala, kes eelistab aeglase vooluga jõe ja seisuveekogu mudast põhja. Öise eluviisiga. Keha on piklik, värvuselt seljalt kollakaspruun, külgedel pruunikad pikitriibud vaheldumisi kollakatega, uimed pruunikad. ",
                    HeroImage = "Vingerjas.jpg",
                    Description = "Vingerjas on väike, angerjataoline kollakaspruuni seljaga musta-kollasetriibuliste külgede ja pruunide uimedega 15...18 cm pikkune kala. Suu juures on tal viis paari lühikesi tumedaid jätkeid - poiseid. Saba ja uimed on ümardunud. Keha ja uimed on kaetud väikeste tumedate täppidega. Silmad on väikesed ja paiknevad kõrgel.\r\n\r\nVingerjas on levinud Kesk- ja Ida-Euroopas. Eestis on ta levila põhjapiiril. Vingerjad elavad soostunud kallastega jõgedes, mudaste põhjadega järvedes ning üldse on tema puhul tegemist ühe korraliku mudanäoga. On ka selge, miks. Vingerjad toituvad surusääsklaste ja teiste putukate vastsetest ja tigudest, kes valdavalt kõik mudas elutsevad. Lisaks sellele on vingerjatel palju vaenlasi: sellisest toredast suutäiest ei ütle ära keegi ja nii ei jäägi tal muud üle, kui mutta peitu pugeda.\r\n\r\nSeoses mudaeluviisiga (väga hapnikuvaene keskkond) on vingerjal arenenud teist järku hingamine rikkalikult veresoontega varustatud pärasoole abil. Aeg-ajalt vingerdab vingerjas mudast pinnale õhku neelama. Samaaegselt laseb ta pärakust välja ka juba ärakasutatud (ärahingatud) õhumulli ja seda saadab piiksuv heli, mistõttu vingerjat ka vigisejaks hüütakse. \r\n\r\nVingerjas sigib kevadel, aprilli lõpust juunini. Tavaliselt koevad nad samas elukeskkonnas, teinekord aga lähevad kudema üleujutatud luhtadele.\r\n\r\nEt vingerjas on väga väike, siis toiduks teda ei tarvitata, küll aga \"vahetavad\" ontlikud kalamehed vingerja välja mõne suurema kala vastu. Vingerjad on suurepäraseks elussöödaks ja eriti hästi saab tema abil haugi püüda. Vingerjad on hinnatud ka akvaariumikaladena. Nad on päris vastupidavad, ega nõua eriti sooja vett. Lisaks sellele on nad ka tänu oma huvitavale hingamisviisile küllalt atraktiivsed.\r\n\r\nVingerjat kasutati vanasti ka ilmaennustamisel. Nimelt tulevad vingerjad enne vihma õhurõhu langedes tavaliselt veepinnale hingama. Vingerjas on looduskaitse all. ",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://www.looduskalender.ee/n/sites/default/files/inline-images/Vingerjas1.jpg",
                        "https://www.looduskalender.ee/n/sites/default/files/inline-images/Vingerjas2.jpg"
                    }
                },
               new()
                {
                    Name = "Kiisk",
                    Keywords="",
                    Subtitle = "Kiisk (Acerina cernua või Gymnocephalus cernuus) on ahvenlaste sugukonda kiisa perekonda kuuluv väike röövkala. ",
                    HeroImage = "Kiisk.jpg",
                    Description = "Kiisk on küllaltki tüseda, külgedelt kergelt lamendunud kehaga kala. Pea on lühika ja ninamik tömp. Seljauimed on liitunud ja nii on kiisal üks pikk seljauim, mis eest on kõrgem ja väga ogaline ning tagant madalam. Ta on üsna väike kala, keskmine pikkus on 10...15 cm ja kaal 10...50 g. Iseloomulikuks võib veel pidada seda, et kiisa keha on kaetud märgatava limakihiga. Silmad on suured ja pungis. Kiiskade värvus on erinev, üldiselt on suuremad isendid märgatavalt tumedamad, kuid tavaliselt on seljal valdavad pruunikad-kollakad toonid tumedate täpikestega, küljed on hallikad-hõbedased ja kõht valkjas.\r\n\r\n    Kiisk võib elada nii mere- kui magevees. Eestis leidub teda paljudes järvedes ja mõnekümnes jões üle kogu vabariigi, välja arvatud Hiiumaal. Meres leidub arvukamalt Matsalu ja Pärnu lahes ja Väinameres. Kiisk tahab pehmet, peene liiva ja napi taimestikuga põhja ning madalamat vett. Kiisad tegutsevad veekogu põhjas suhteliselt paiksetes parvedes ja on aktiivsed hommikuti ja õhtuti.\r\n\r\n    Peamiseks toiduks on põhjast väljatuhnitavad selgrootud, kuid suuremat kasvu kiisad tarvitavad toiduks ka kalu. Lisaks sellele tarvitab kiisk innukalt ka teiste kalade marja.\r\n\r\n    Kiisa kudemisperiood on pikk - see algab kiiremini soojenevates veekogudes juba aprilli keskel ja võib kesta juuni lõpuni. Emane koeb oma marja liiva- või kivipõhjale või ka eelmise aasta taimestikule. Marja areng kestab 2...3 nädalat. Vastne lebab esimesed 3...4 päeva liikumatult põhjal, enne kui ujuma ja toituma hakkab. Noored kiisad toituvad peamiselt vee alumistes kihtidest hõljuvatest selgrootutest. Kiisk kasvab aeglaselt, kuid suguküpseks saab juba 1...2 aasta vanuselt. Eluiga võib küündida kuni 11 aastani. Kiisk võib heade elutingimuste korral muutuda mõnes järves massiliseks ja siis peetakse teda kahjulikuks kalaks, sest ta hävitab hinnaliste kalade marja ja söödavarusid.\r\n\r\n    Kiisa liha on maitsev ja seda süüakse peamiselt keedetult. Iidsetest aegadest on teada, et mitte ühestki kalast ei saa nii head uhhaad kui kiisast. Kiisk ei kuulu looduskaitse alla.\r\n\r\n",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Gymnocephalus_cernuus.jpg/220px-Gymnocephalus_cernuus.jpg",
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Gymnocephalus_cernuus_P%C3%A4rnu_River_Estonia_2010-01-06.jpg/220px-Gymnocephalus_cernuus_P%C3%A4rnu_River_Estonia_2010-01-06.jpg"
                    }
                },
                new()
                {
                    Name = "Räim",
                    Keywords="",
                    Subtitle = "Räim ehk läänemere heeringas (Clupea harengus membras) on atlandi heeringa alamliik, kes elab Läänemeres. ",
                    HeroImage = "Räim.jpg",
                    Description = "Räim on valitud Eesti rahvuskalaks. Ta on olnud peamine kala eestlaste toidulaual juba sajandeid. Räim on suhteliselt väike, kiilukujulise, külgedelt lamenenud kehaga, hõbedaläikeline kala tume-sinakasrohelise seljaga. Asustab Läänemere keskosa ning Botnia ja Soome lahte. Räim on avaveelise eluviisiga ning võib laskuda meres enam kui saja meetri sügavusele. Juhuslikult võib ta eksida ka magevette. Räim elab vilkalt liikuvates suurtes parvedes, mis võtavad toiduotsinguil või kudemise ajal ette küllalt ulatuslikke rändeid.\r\n\r\nKeskmine räim on umbes 15 cm pikkune, kuid esineb ka hiiglasi, kelle pikkus ulatub kuni 40 cm-ni. Neid nimetatakse hiidräimedeks. Hiidräimed kujunevad välja nendest räimedest, kel õnnestub noorpõlves hakata neelama teiste kalade vastseid ja maime. See tingibki kiire kasvu võrreldes teiste räimedega, kes jäävad elu lõpuni truuks selgrootutest toitumisele. Huvitav on see, et talvel ei toitu räimed üldse - nad veedavad talve tihedates väheliikuvates parvedes kuni saja meetri sügavusel põhja lähedal. Intensiivse toitumise ajal varakevadest hilissügiseni toimuvad aga igaõhtused ränded ülemisse veekihti, kus öö mööda saadetakse, hommikul laskutakse seevastu sügavamatesse veekihtidesse tagasi. Sellise liikumise põhjustab see, et räimed ei talu eredat päikesevalgust, samal ajal on aga ülemine veekiht soojem ja hapnikurikkam ning seal on rohkem toitu.\r\n\r\nKui kudemisaeg kätte jõuab, kevadräimedel aprilli teisest poolest juulini, sügisräimel augustist septembrini, suunduvad räimeparved rannikualadele. Koelmud paiknevad 4...12 m sügavusel. Kruusasele põhjale kleepunud marjast satub palju põhjakalade toiduks. Koorunud vastsed toituvad zooplanktonist, räimemaimud suurematest põhjalähedastest selgrootutest loomakestest. Meres on räimel ohtralt vaenlasi: ta on toiduks paljudele röövkaladele, hüljestele ja kajakatele. \r\n\r\nRäim on üks tähtsamaid püügikalu kogu Läänemeres, teda tarvitatakse toiduks värskelt, soolatult, suitsutatult ja konserveeritult. Vaenlaste ohtruse ja suure väljapüügi tõttu tekkiva kahju kompenseerib räim suure järglaste arvuga. Ei kuulu looduskaitse alla.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/R%C3%A4im.JPG/220px-R%C3%A4im.JPG"
                    }
                },
                new()
                {
                    Name = "Tursk",
                    Keywords="",
                    Subtitle = "Tursk ehk atlandi tursk ehk kabeljoo (Gadus morhua) on tursklaste sugukonda kuuluv kalaliik.",
                    HeroImage = "Tursk.jpg",
                    Description = "Tursk on omapärase ja hõlpsalt äratuntava kehakujuga kala. Ta ruljas keha on kõige kõrgem kukla kohalt, siis aga aheneb ühtlaselt saba suunas. Pea ja suu on suhteliselt suured, alalõua all väike poise. Tursa värvus sõltub elukeskkonnast, kuid üldiselt on valdavad hallikad ja pruunikad toonid. Selga ja külgi katavad arvukad tumedamad hallid või pruunid täpid, kõht helehall või valge ning küljejoon valkjas. Ta on suhteliselt suur kala, kelle keskmine pikkus täiskasvanult on 40...60 cm ja kehamass 0,8...1,5 kg.\r\n\r\nTursk on kala, kes asustab laiu veteavarusi, elades peamiselt Läänemere kesk- ja lõunaosas. Tursaparved on väga liikuvad, nad hoiduvad suurtesse sügavustesse ja põhjalähedastesse veekihtidesse. Läänemerd asustavad tursaparved võivad olla üksteisest välimuselt veidi erinevad. Eesti rannavetesse satub teda üldiselt vähe.\r\n\r\nTursk on röövkala, kelle ohvriks langevad räimed, kilud, lestad ja ka enda nõrgemad liigikaaslased. Tursk on päevase eluviisiga. On kindlaks tehtud, et ööseks laskuvad nad kivisele merepõhjale ja lebavad seal liikumatult, kas kõhuli või koguni külili.\r\n\r\nLähimad tursad koelmud asuvad Gotlandi süviku või selle nõlvade piirkonnas 70...100 m sügavusel, ka Hiiumaa ja Stockholmi vahelistes sügavates kohtades. Kudemine toimub Läänemere turskadel pika aja jooksul märtsist augstini. Vaatamata sellele, et tursk on parvekala ja seltskonnaga harjunud, muutuvad nad mõnikord - intensiivse toitumise ja eriti kudemise ajal - üksteise suhtes vaenulikuks. Siis hõivab iga isaskala omale territooriumi. Et avavees piiritähised puuduvad, siis kujutab see lihtsalt teatud suurusega vaba ruumi peremehe ümber. Kudemistseremoonia ajal teeb isastursk ujupõie abil röhkivat häält ja müksib emast ninaga.\r\n\r\nViljastatud marjaterad arenevad vabalt vees hõljudes ning vastsed kooruvad 2...4 nädala pärast. Esialgu kerkivad vastsed vee ülakihtidesse, kus nad planktonist toitudes hõljuvad, hiljem aga laskuvad merepõhja. Suguküpseks saavad tursad 2...5 aasta vanuselt. Looduses elab tursk tavaliselt 9...10 aastat vanaks.\r\n\r\nTursk on üks tähtsamaid põhjalähedase eluviisiga püügikalu kogu maailmas. Eriti väärtuslikuks peetakse tema A- ja D-vitamiini rikast maksa, millest toodetakse kalamaksaõli. Tursa liha on rasvavaene, kuid maitsev ja sobib hästi dieettoiduks. Looduskaitse alla ei kuulu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Atlantic_cod.jpg/220px-Atlantic_cod.jpg"
                    }
                },
                new()
                {
                    Name = "Kilu",
                    Keywords="",
                    Subtitle = "Läänemere kilu, balti kilu ehk kilu (Sprattus sprattus balticus või Clupea sprattus balticus) on väike, saleda kehakujuga sinakasrohelise seljaga hõbedane kala, euroopa kilu (Sprattus sprattus) alamliik.",
                    HeroImage = "Kilu.jpg",
                    Description = "Kilu on väike, saleda kehakujuga sinakasrohelise seljaga hõbedane kala. Kui libistada näpuga mööda kilu kõhuäärt saba poolt pea poole, siis on tunda, kuidas teravad kiilusoomused nakkuvad sõrme külge. Seda meetodit kasutatakse sageli, et eristada kilu räimest.\r\n\r\nKilu on Eesti merevetes laialt levinud - ta ei tule kunagi ranniku lähedale, vaid veedab kogu oma elu avamerel. Kilud koonduvad suurtesse parvedesse, mille pikkus võib ulatuda sadadesse meetritesse või koguni kilomeetritesse.\r\n\r\nKilu leviku määravad ära talvitumistingimused ja üldine soolsus, sest sellest sõltub kudemise edukus. Nimelt võib mari liiga madala soolsuse tõttu hukkuda, sest marja areng saab toimuda vaid vabalt vees hõljudes, madala soolsusega vees vajub aga mari põhja. Kudemine toimub juunis või juulis ülemistes veekihtides ning kalurid on tähele pannud kilude kudemisaegset \"mängu\", mis jätab mulje nagu sajaks vaiksesse vette tugevat vihma. Vastsed kooruvad juba 3...4 päeva pärast, 2,5...4 cm pikkusena teevad nad läbi moonde - ilmub hõbeläige ning vastsest on saanud maim.\r\n\r\nNii vastsete kui ka maimude põhiosa menüüst moodustavad vees hõljuvad selgrootud - peamiselt aerjalalised ja vesikirbulised. Talvel toituvad kilud vähe ja nad koonduvad tihedatesse väheliikuvatesse parvedesse kuni saja meetri sügavusele põhja lähedale. Intensiivse toitumise ajal varakevadest hilissügiseni toimuvad aga igaõhtused ränded ülemisse veekihti, kus öö mööda saadetakse, hommikul laskutakse seevastu sügavamatesse veekihtidesse tagasi. Sellise liikumise põhjustab asjaolu, et kilud ei talu eredat päikesevalgust, samal ajal on aga ülemine veekiht soojem ja hapnikurikkam ning seal on rohkem toitu.\r\n\r\nKilu on ka ise toiduks paljudele loomadele - röövkaladele, hüljestele ja veelindudele, samuti on tal tugev toidukonkurents noorte räimedega. Kilu elule mõjub väga soodsalt soolase vee sissevool Põhjamerest Läänemerre, sest see rikastab ta toidulauda. Kilu arvukust kahjustab vaenlaste arvu (tursa) suurenemine. Ta on üks tähtsamaid töönduslikke masskalu, keda kasutatakse ka loomasöödaks. Sügiskuudel on kilul suur rasvasisaldus (10-18 %) ning temast toodetakse sprotte ja vürtsikilu.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Sprattus_sprattus.jpg/220px-Sprattus_sprattus.jpg"
                    }
                },
                new()
                {
                    Name = "Särg",
                    Keywords="",
                    Subtitle = "Särg (Rutilus rutilus) on karpkalaliste seltsi kuuluv kala.",
                    HeroImage = "Särg.jpg",
                    Description = "Särge on teistest kaladest lihtne eristada silma oranzi või punase vikerkesta järgi. Keha on külgedelt lamenenud ja kaetud suurte korrapärastes ridades asetsevate soomustega. Värvuselt on ta seljalt sinakas- või rohekasmust, küljed ja kõht on hõbevalged. Särg on tavaliselt 10...25 cm pikkune ja kaalub kuni150 g. Särje eluiga võib ulatuda kuni 17 aastani.\r\n\r\nSärg on laialt levinud peaaegu kõigis Eesti järvedes, samuti jõgedes ja ojades. Ta elutseb veekogude kaldaäärsetes, mudastes ja rikka taimestikuga osades. Särg on rangelt päevase eluviisiga, kes ööseks peitub taimede vahele ja heidab unne, võttes sisse kaldasendi ning toetades pea ja rinnauimedega põhjale.\r\n\r\nSärg on segatoiduline kalaliik, kes sööb väikseid tigusid, veeputukaid, kalamarja ja vastseid, mändvetikate ja vesikatkude võrseid ning taimset kõdu. Suuremate veekogude särjed (meil Võrtsjärves) tarvitavad toiduks ka kalu. Särg ise langeb ohvriks peaaegu kõikidele röövkaladele, kajakatele ja teistele veelindudele.\r\n\r\nKudemise ajaks kasvab isasele särjele selga pulmarüü - helmeskate. Selle moodustavad sarvainest köbrukesed kala kehal, mis muudavad ta karedaks. Särjed koevad kevadel - aprilli lõpul või mai algul. Koelmud asuvad kalda lähedal madalvees, kus põhi on kaetud tihedate tarnapuhmastega või muu taimestikuga. Särg ei hõiva omale individuaalset kudemisala, vaid hoiduvad ühisesse kudemisvööndisse. Kudemine toimub rabeldes ja kärarikka veepladina saatel, mis võib olla nii tugev, et osa marjateri satub veest välja taimede veepealsetele osadele. Vastsed kooruvad sõltuvalt veetemperatuurist 9...14 päeva pärast. Särg võib anda hübriide latika, roosärje, nuru, viidika ja linaskiga. \r\n\r\nInimeste seas pole särg püügikalana kuigi hinnatud - tema liha on luine ja tihti mudamaitsega. Särge tarvitatakse peamiselt soolatult ja kuivatatult. Kalameeste poolt leiab ta kasutamist söödakalana õngepüügil. Järvedes etendab ta olulist osa veetaimede tarbijana ning hinnaliste röövkalade toiduna. Ei ole looduskaitse all.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Blausteinsee_Tierwelt_03.jpg/220px-Blausteinsee_Tierwelt_03.jpg"
                    }
                }
        };

        public static List<Fish> GetFeaturedFish()
        {
            var random = new Random();
            var randomizedFish = fish.OrderBy(item => random.Next());

            return randomizedFish.Take(3).ToList();
        }

        public static List<Fish> SearchAndSortFish(string searchQuery)
        {
            string query = searchQuery.ToLower();

            return fish.Where(fish =>
                fish.Keywords.ToLower().Contains(query) ||
                fish.Description.ToLower().Contains(query)
            )
            .OrderBy(fish => fish.Keywords)
            .ThenBy(fish => fish.Description)
            .ToList();
        }



        public static List<Fish> GetAllFish()
            => fish;
    }

}