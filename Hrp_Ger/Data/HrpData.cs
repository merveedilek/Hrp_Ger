using Hrp_Ger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrp_Ger.Data
{
    public class HrpData
    {
        public HrpData()
        {
            bahceModels = new List<BahceModel>()
            {
                new BahceModel()
                {
                    BahceId=1,
                    UrunAdi="bm-ms-001",
                    En="510 mm",
                    Boy="510 mm",
                    Yukseklik="400 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-001-satine.jpg",Klasor="bm-ms-001"},
                        new Images(){ImagePath="bm-ms-001-3satine-600x600.jpg",Klasor="bm-ms-001"},
                        new Images(){ImagePath="bm-ms-001-ölçüleri-600x600.jpg",Klasor="bm-ms-001"},
                        new Images(){ImagePath="bm-ms-001-600x600.jpg",Klasor="bm-ms-001"}
                    }
                },
                new BahceModel()
                {
                    BahceId=2,
                    UrunAdi="bm-ms-002",
                    En="510 mm",
                    Boy="510 mm",
                    Yukseklik="400 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte ",
                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-002.jpg",Klasor="bm-ms-002"},
                        new Images(){ImagePath="bm-ms-002-2-600x600.jpg",Klasor="bm-ms-002"},
                        new Images(){ImagePath="bm-ms-002-ölçüleri-600x600.jpg",Klasor="bm-ms-002"},
                        new Images(){ImagePath="bm-ms-002-600x600.jpg",Klasor="bm-ms-002"}
                    }
                },
                new BahceModel()
                {
                    BahceId=3,
                    UrunAdi="bm-ms-003",
                    En="450 mm",
                    Boy="450 mm",
                    Yukseklik="400 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-003-2-1-600x600.jpg",Klasor="bm-ms-003"},
                        new Images(){ImagePath="bm-ms-003-3-600x600.jpg",Klasor="bm-ms-003"},
                        new Images(){ImagePath="bm-ms-003-ölçüleri-600x600.jpg",Klasor="bm-ms-003"},
                        new Images(){ImagePath="bm-ms-003.r-600x600.jpg",Klasor="bm-ms-003"}
                    }
                },
                new BahceModel()
                {
                    BahceId=4,
                    UrunAdi="bm-ms-004",
                    En="574 mm",
                    Boy="574 mm",
                    Yukseklik="410 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    AhsapKaplama="Teak,Sapelli",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-004.jpg",Klasor="bm-ms-004"},
                        new Images(){ImagePath="bm-ms-004-2-600x600.jpg",Klasor="bm-ms-004"},
                        new Images(){ImagePath="bm-ms-004-ölçüleri-600x600.jpg",Klasor="bm-ms-004"},
                        new Images(){ImagePath="bm-ms-004-600x600.jpg",Klasor="bm-ms-004"}
                    }
                },
                new BahceModel()
                {
                    BahceId=5,
                    UrunAdi="bm-ms-005",
                    En="600 mm",
                    Boy="600 mm",
                    Yukseklik="457 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    AhsapKaplama="Teak,Sapelli",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-005.jpg",Klasor="bm-ms-005"},
                        new Images(){ImagePath="bm-ms-005-2-600x600.jpg",Klasor="bm-ms-005"},
                        new Images(){ImagePath="bm-ms-005-Model-600x600.jpg",Klasor="bm-ms-005"},
                        new Images(){ImagePath="bm-ms-005-600x600.jpg",Klasor="bm-ms-005"}
                    }
                },
                new BahceModel()
                {
                    BahceId=6,
                    UrunAdi="bm-ms-006",
                    En="630 mm",
                    Boy="630 mm",
                    Yukseklik="420 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ms-006-üstü-satine-ayaklar-parlak.jpg",Klasor="bm-ms-006"},
                        new Images(){ImagePath="bm-ms-006-2-üstü-satine-ayaklar-parlak-600x600.jpg",Klasor="bm-ms-006"},
                        new Images(){ImagePath="bm-ms-006-Model-600x600.jpg",Klasor="bm-ms-006"},
                        new Images(){ImagePath="bm-ms-006-600x600.jpg",Klasor="bm-ms-006"}
                    }
                },
                  new BahceModel()
                {
                    BahceId=7,
                    UrunAdi="bm-ob-01",
                    En="631 mm",
                    Boy="857,5 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-01.jpg",Klasor="bm-ob-01"},
                        new Images(){ImagePath="bm-ob-01-2-600x600.jpg",Klasor="bm-ob-01"},
                        new Images(){ImagePath="bm-ob-01-3-600x600.jpg",Klasor="bm-ob-01"},
                        new Images(){ImagePath="bm-ob-01-ölçüleri-1-600x600.jpg",Klasor="bm-ob-01"},
                        new Images(){ImagePath="bm-ob-01-600x600.jpg",Klasor="bm-ob-01"}
                    }
                },
                   new BahceModel()
                {
                    BahceId=8,
                    UrunAdi="bm-ob-02",
                    En="570 mm",
                    Boy="855,5 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-02.jpg",Klasor="bm-ob-02"},
                        new Images(){ImagePath="bm-ob-02-2-600x600.jpg",Klasor="bm-ob-02"},
                        new Images(){ImagePath="bm-ob-02-3-600x600.jpg",Klasor="bm-ob-02"},
                        new Images(){ImagePath="bm-ob-02-ölçüleri-600x600.jpg",Klasor="bm-ob-02"},
                        new Images(){ImagePath="bm-ob-02-1-600x600.jpg",Klasor="bm-ob-02"}
                    }
                },
                new BahceModel()
                {
                    BahceId=9,
                    UrunAdi="bm-ob-03",
                    En="674 mm",
                    Boy="855,5 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-03.jpg",Klasor="bm-ob-03"},
                        new Images(){ImagePath="bm-ob-03-2-600x600.jpg",Klasor="bm-ob-03"},
                        new Images(){ImagePath="bm-ob-03-3-600x600.jpg",Klasor="bm-ob-03"},
                        new Images(){ImagePath="bm-ob-03-ölçüleri-600x600.jpg",Klasor="bm-ob-03"},
                        new Images(){ImagePath="bm-ob-03-600x600.jpg",Klasor="bm-ob-03"}
                    }
                },
                new BahceModel()
                {
                    BahceId=10,
                    UrunAdi="bm-ob-04",
                    En="608 mm",
                    Boy="853,5 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-04.jpg",Klasor="bm-ob-04"},
                        new Images(){ImagePath="bm-ob-04-2-600x600.jpg",Klasor="bm-ob-04"},
                        new Images(){ImagePath="bm-ob-04-3-600x600.jpg",Klasor="bm-ob-04"},
                        new Images(){ImagePath="bm-ob-04-Model-600x600.jpg",Klasor="bm-ob-04"},
                        new Images(){ImagePath="bm-ob-04-600x600.jpg",Klasor="bm-ob-04"}
                    }
                },
                  new BahceModel()
                {
                    BahceId=11,
                    UrunAdi="bm-ob-05",
                    En="830 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-05.jpg",Klasor="bm-ob-05"},
                        new Images(){ImagePath="bm-ob-05-2-600x600.jpg",Klasor="bm-ob-05"},
                        new Images(){ImagePath="bm-ob-05-3-600x600.jpg",Klasor="bm-ob-05"},
                        new Images(){ImagePath="bm-ob-05-ölçüleri-600x600.jpg",Klasor="bm-ob-05"},
                        new Images(){ImagePath="bm-ob-05-600x600.jpg",Klasor="bm-ob-05"}
                    }
                },
                  new BahceModel()
                {
                    BahceId=12,
                    UrunAdi="bm-ob-06",
                    En="830 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-06.jpg",Klasor="bm-ob-06"},
                        new Images(){ImagePath="bm-ob-06-2-600x600.jpg",Klasor="bm-ob-06"},
                        new Images(){ImagePath="bm-ob-06-3-600x600.jpg",Klasor="bm-ob-06"},
                        new Images(){ImagePath="bm-ob-06-ölçüleri-600x600.jpg",Klasor="bm-ob-06"},
                        new Images(){ImagePath="bm-ob-06-600x600.jpg",Klasor="bm-ob-06"}
                    }
                },
                     new BahceModel()
                {
                    BahceId=13,
                    UrunAdi="bm-ob-07",
                    En="1510 mm/1710 mm/1870 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-07.jpg",Klasor="bm-ob-07"},
                        new Images(){ImagePath="bm-ob-07-2-600x600.jpg",Klasor="bm-ob-07"},
                        new Images(){ImagePath="bm-ob-07-3-600x600.jpg",Klasor="bm-ob-07"},
                        new Images(){ImagePath="bm-ob-07-ölçüleri-600x600.jpg",Klasor="bm-ob-07"},
                        new Images(){ImagePath="bm-ob-07-600x600.jpg",Klasor="bm-ob-07"}
                    }
                },
                      new BahceModel()
                {
                    BahceId=14,
                    UrunAdi="bm-ob-08",
                    En="766,5 mm",
                    Boy="1510 mm/1710 mm/1870 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-08-600x600.jpg",Klasor="bm-ob-08"},
                        new Images(){ImagePath="bm-ob-08-3-600x600.jpg",Klasor="bm-ob-08"},
                        new Images(){ImagePath="bm-ob-08-2-600x600.jpg",Klasor="bm-ob-08"},
                        new Images(){ImagePath="bm-ob-08-2-ölçüleri-3lü-sol-tek-kollu-1-600x600.jpg",Klasor="bm-ob-08"},
                        new Images(){ImagePath="bm-ob-08-ölçüleri-sol-tek-kollu-1-600x600.jpg",Klasor="bm-ob-08"},
                        new Images(){ImagePath="bm-ob-08-r-600x600.jpg",Klasor="bm-ob-08"}
                    }
                },
                      new BahceModel()
                {
                    BahceId=15,
                    UrunAdi="bm-ob-08-9-10",
                    En="766,5 mm",
                    Boy="2276,5 mm/2476,5 mm/2636,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-08-9-10.jpg",Klasor="bm-ob-08-9-10"},
                        new Images(){ImagePath="bm-ob-08-9-10-2-600x600.jpg",Klasor="bm-ob-08-9-10"},
                        new Images(){ImagePath="bm-ob-08-9-10-3-600x600.jpg",Klasor="bm-ob-08-9-10"},
                        new Images(){ImagePath="bm-ob-08-9-10-ölçüleri-600x600.jpg",Klasor="bm-ob-08-9-10"},
                        new Images(){ImagePath="bm-ob-08-9-10-600x600.jpg",Klasor="bm-ob-08-9-10"},

                    }
                },
                 new BahceModel()
                {
                    BahceId=16,
                    UrunAdi="bm-ob-09",
                    En="766,5 mm",
                    Boy="1510 mm/1710 mm/1870 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-09-2-600x600.jpg",Klasor="bm-ob-09"},
                        new Images(){ImagePath="bm-ob-09-600x600.jpg",Klasor="bm-ob-09"},
                        new Images(){ImagePath="bm-ob-09-ölçüleri-sağ-tek-kollu-600x600.jpg",Klasor="bm-ob-09"},
                        new Images(){ImagePath="bm-ob-09-3-600x600.jpg",Klasor="bm-ob-09"},
                        new Images(){ImagePath="bm-ob-09-2-ölçüleri-3lü-sağ-tek-kollu-600x600.jpg",Klasor="bm-ob-09"},
                         new Images(){ImagePath="bm-ob-09-r-600x600.jpg",Klasor="bm-ob-09"}
                    }
                },
                 new BahceModel()
                {
                    BahceId=17,
                    UrunAdi="bm-ob-10",
                    En="766,5 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-10-600x600.jpg",Klasor="bm-ob-10"},
                        new Images(){ImagePath="bm-ob-10-3-600x600.jpg",Klasor="bm-ob-10"},
                        new Images(){ImagePath="bm-ob-10-2-600x600.jpg",Klasor="bm-ob-10"},
                        new Images(){ImagePath="bm-ob-10-ölçüleri-600x600.jpg",Klasor="bm-ob-10"},
                        new Images(){ImagePath="bm-ob-10-r-600x600.jpg",Klasor="bm-ob-10"},
                    }
                },

                  new BahceModel()
                {
                    BahceId=18,
                    UrunAdi="bm-ob-11",
                    En="460 mm",
                    Boy="1270 mm",
                    Yukseklik="630 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-11.jpg",Klasor="bm-ob-11"},
                        new Images(){ImagePath="bm-ob-11-2-600x600.jpg",Klasor="bm-ob-11"},
                        new Images(){ImagePath="bm-ob-11-3-600x600.jpg",Klasor="bm-ob-11"},
                        new Images(){ImagePath="bm-ob-11-ölçüleri-600x600.jpg",Klasor="bm-ob-11"},
                        new Images(){ImagePath="bm-ob-11-r-600x600.jpg",Klasor="bm-ob-11"},
                    }
                },
                  new BahceModel()
                {
                    BahceId=19,
                    UrunAdi="bm-ob-12",
                    En="400 mm",
                    Boy="1270 mm",
                    Yukseklik="420 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-12.jpg",Klasor="bm-ob-12"},
                        new Images(){ImagePath="bm-ob-12-2-600x600.jpg",Klasor="bm-ob-12"},
                        new Images(){ImagePath="bm-ob-12-3-600x600.jpg",Klasor="bm-ob-12"},
                        new Images(){ImagePath="bm-ob-12-ölçüleri-600x600.jpg",Klasor="bm-ob-12"},
                        new Images(){ImagePath="bm-ob-12-r-600x600.jpg",Klasor="bm-ob-12"},
                    }
                },
                  new BahceModel()
                {
                    BahceId=20,
                    UrunAdi="bm-ob-13",
                    En="550 mm",
                    Boy="450 mm",
                    Yukseklik="450 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-13.jpg",Klasor="bm-ob-13"},
                        new Images(){ImagePath="bm-ob-13-2-600x600.jpg",Klasor="bm-ob-13"},
                        new Images(){ImagePath="bm-ob-13-3-600x600.jpg",Klasor="bm-ob-13"},
                        new Images(){ImagePath="bm-ob-13-Model-600x600.jpg",Klasor="bm-ob-13"},
                        new Images(){ImagePath="bm-ob-13-1-600x600.jpg",Klasor="bm-ob-13"},
                    }
                },
                    new BahceModel()
                {
                    BahceId=21,
                    UrunAdi="bm-ob-14",
                    En="498,5 mm",
                    Boy="388 mm",
                    Yukseklik="348 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte ",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-14-1-satine.jpg",Klasor="bm-ob-14"},
                        new Images(){ImagePath="bm-ob-14-2-satine-600x600.jpg",Klasor="bm-ob-14"},
                        new Images(){ImagePath="bm-ob-14-3-satine-600x600.jpg",Klasor="bm-ob-14"},
                        new Images(){ImagePath="bm-ob-14-Model-600x600.jpg",Klasor="bm-ob-14"},
                        new Images(){ImagePath="bm-ob-14-600x600.jpg",Klasor="bm-ob-14"},
                    }
                },
                        new BahceModel()
                {
                    BahceId=22,
                    UrunAdi="bm-ob-15",
                    En="724 mm",
                    Boy="1903 mm",
                    Yukseklik="681,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    AhsapKaplama="Sapelli, Teak",

                     Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-ob-15.jpg",Klasor="bm-ob-15"},
                        new Images(){ImagePath="bm-ob-15-2-600x600.jpg",Klasor="bm-ob-15"},
                        new Images(){ImagePath="bm-ob-15-3-600x600.jpg",Klasor="bm-ob-15"},
                        new Images(){ImagePath="bm-ob-15-4-600x600.jpg",Klasor="bm-ob-15"},
                        new Images(){ImagePath="bm-ob-15-Model-600x600.jpg",Klasor="bm-ob-15"},
                         new Images(){ImagePath="bm-ob-15-600x600.jpg",Klasor="bm-ob-15"},
                    }
                },
                 new BahceModel()
                {
                    BahceId=23,
                    UrunAdi="bm-pergole-001",
                    En="7420,1 mm",
                    Boy="4208 mm",
                    Yukseklik="3114 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    AhsapKaplama="Teak",

                   Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-pergole-001-600x600.jpg",Klasor="bm-pergole-001"},
                        new Images(){ImagePath="bm-pergole-001-1-600x600.jpg",Klasor="bm-pergole-001"},
                        new Images(){ImagePath="bm-pergole-001-3-600x600.jpg",Klasor="bm-pergole-001"},
                        new Images(){ImagePath="bm-pergole-001-ölçüleri-600x600.jpg",Klasor="bm-pergole-001"},
                        new Images(){ImagePath="bm-pergole-001-r-600x600.jpg",Klasor="bm-pergole-001"},

                    }
                },
                   new BahceModel()
                {
                    BahceId=24,
                    UrunAdi="bm-salincak-002",
                    En="2190 mm",
                    Boy="1743,4 mm",
                    Yukseklik="1946,9 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="	 Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin,Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Doseme="Summer Plain 042, Summer Plain 220,Summer Plain 540",


                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="bm-salincak-002-1-600x600.jpg",Klasor="bm-salincak-002"},
                        new Images(){ImagePath="bm-salincak-002-600x600.jpg",Klasor="bm-salincak-002"},
                        new Images(){ImagePath="bm-salincak-002-2-600x600.jpg",Klasor="bm-salincak-002"},
                        new Images(){ImagePath="bm-salincak-002-ölçüleri-600x600.jpg",Klasor="bm-salincak-002"},
                        new Images(){ImagePath="bm-salincak-002-r-600x600.jpg",Klasor="bm-salincak-002"},

                    }
                }
            };
            icMekanMobilya = new List<icMekanMobilya>()
            {
                new icMekanMobilya()
                {
                    icMekanId=1,
                    UrunAdi="imm-k-001",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-001.jpg",Klasor="imm-k-001"},
                        new Images(){ImagePath="imm-k-001-1-600x600.jpg",Klasor="imm-k-001"},
                        new Images(){ImagePath="imm-k-001-2-600x600.jpg",Klasor="imm-k-001"},
                        new Images(){ImagePath="imm-k-001-ölçüleri-600x600.jpg",Klasor="imm-k-001"},
                        new Images(){ImagePath="imm-k-001-r-600x600.jpg",Klasor="imm-k-001"},

                    }
                },
                new icMekanMobilya()
                {
                    icMekanId=2,
                    UrunAdi="imm-masa-006",
                    En="1000 mm",
                    Boy="2000 mm",
                    Yukseklik="750 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-006.jpg",Klasor="imm-masa-006"},
                        new Images(){ImagePath="imm-masa-006-1-600x600.jpg",Klasor="imm-masa-006"},
                        new Images(){ImagePath="imm-masa-006-ölçüleri-600x600.jpg",Klasor="imm-masa-006"},

                        new Images(){ImagePath="imm-masa-006-600x600.jpg",Klasor="imm-masa-006"},

                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=3,
                    UrunAdi="imm-masa-001",
                    En="1000 mm",
                    Boy="2000 mm",
                    Yukseklik="750 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-001.jpg",Klasor="imm-masa-001"},
                        new Images(){ImagePath="imm-masa-001-1-600x600.jpg",Klasor="imm-masa-001"},
                        new Images(){ImagePath="imm-masa-001-1-1-600x600.jpg",Klasor="imm-masa-001"},

                        new Images(){ImagePath="imm-masa-001-ölçüleri-600x600.jpg",Klasor="imm-masa-001"},
                         new Images(){ImagePath="imm-masa-001-600x600.jpg",Klasor="imm-masa-001"}

                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=4,
                    UrunAdi="imm-ob-01",
                    En="830 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme=" 188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-01.jpg",Klasor="imm-ob-01"},
                        new Images(){ImagePath="imm-ob-01-1-600x600.jpg",Klasor="imm-ob-01"},
                        new Images(){ImagePath="imm-ob-01-3-600x600.jpg",Klasor="imm-ob-01"},

                        new Images(){ImagePath="imm-ob-01-ölçüleri-600x600.jpg",Klasor="imm-ob-01"},
                        new Images(){ImagePath="imm-ob-01-r-600x600.jpg",Klasor="imm-ob-01"}

                    }
                },
                    new icMekanMobilya()
                {
                    icMekanId=5,
                    UrunAdi="imm-ob-02",
                    En="766,5 mm",
                    Boy="1510 mm/1710 mm/1870 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme="188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-02.jpg",Klasor="imm-ob-02"},
                        new Images(){ImagePath="imm-ob-02-1-600x600.jpg",Klasor="imm-ob-02"},
                        new Images(){ImagePath="imm-ob-02-2-600x600.jpg",Klasor="imm-ob-02"},

                        new Images(){ImagePath="imm-ob-02-ölçüleri-600x600.jpg",Klasor="imm-ob-02"},
                        new Images(){ImagePath="imm-ob-02-600x600.jpg",Klasor="imm-ob-02"}

                    }
                },
                           new icMekanMobilya()
                {
                    icMekanId=6,
                    UrunAdi="imm-ob-03-04-05",
                    En="766,5 mm",
                    Boy="2276,5 mm/2476,5 mm/2636,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme=" 188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-03-4-5.jpg",Klasor="imm-ob-03-04-05"},
                        new Images(){ImagePath="imm-ob-03-4-5-1-600x600.jpg",Klasor="imm-ob-03-04-05"},
                        new Images(){ImagePath="imm-ob-03-4-5-ölçüleri-600x600.jpg",Klasor="imm-ob-03-04-05"},
                        new Images(){ImagePath="imm-ob-03-4-5-r-600x600.jpg",Klasor="imm-ob-03-04-05"}

                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=7,
                    UrunAdi="imm-k-001-2",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-001-2-600x600.jpg",Klasor="imm-k-001-2"},
                        new Images(){ImagePath="imm-k-001-2-2-600x600.jpg",Klasor="imm-k-001-2"},
                        new Images(){ImagePath="imm-k-001-2-3-600x600.jpg",Klasor="imm-k-001-2"},
                        new Images(){ImagePath="imm-k-001-2-ölçüleri-600x600.jpg",Klasor="imm-k-001-2"},
                        new Images(){ImagePath="imm-k-001-2-r-600x600.jpg",Klasor="imm-k-001-2"},

                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=8,
                    UrunAdi="imm-k-001-2-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-001-2-k-2-600x600.jpg",Klasor="imm-k-001-2-k"},
                        new Images(){ImagePath="imm-k-001-2-k-1-600x600.jpg",Klasor="imm-k-001-2-k"},
                        new Images(){ImagePath="imm-k-001-2-k-3-600x600.jpg",Klasor="imm-k-001-2-k"},
                        new Images(){ImagePath="imm-k-001-2-k-ölçüleri-600x600.jpg",Klasor="imm-k-001-2-k"},
                        new Images(){ImagePath="imm-k-001-2-k-r-600x600.jpg",Klasor="imm-k-001-2-k"},

                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=9,
                    UrunAdi="imm-k-002",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-002-600x600.jpg",Klasor="imm-k-002"},
                        new Images(){ImagePath="imm-k-002-2-4-600x600.jpg",Klasor="imm-k-002"},
                        new Images(){ImagePath="imm-k-002-3-600x600.jpg",Klasor="imm-k-002"},
                        new Images(){ImagePath="imm-k-002-ölçüleri-600x600.jpg",Klasor="imm-k-002"},
                        new Images(){ImagePath="imm-k-002-r-600x600.jpg",Klasor="imm-k-002"},
                    }
                },
                   new icMekanMobilya()
                {
                    icMekanId=10,
                    UrunAdi="imm-k-002-2",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-002-2-5-600x600.jpg",Klasor="imm-k-002-2"},
                        new Images(){ImagePath="imm-k-002-2-3-1-600x600.jpg",Klasor="imm-k-002-2"},
                        new Images(){ImagePath="imm-k-002-2-2-2-600x600.jpg",Klasor="imm-k-002-2"},
                        new Images(){ImagePath="imm-k-002-2-ölçüleri-600x600.jpg",Klasor="imm-k-002-2"},
                        new Images(){ImagePath="imm-k-002-2-r-600x600.jpg",Klasor="imm-k-002-2"},
                    }
                },
                      new icMekanMobilya()
                {
                    icMekanId=11,
                    UrunAdi="imm-k-002-2-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-002-2-k-4-600x600.jpg",Klasor="imm-k-002-2-k"},
                        new Images(){ImagePath="imm-k-002-2-k-3-2-600x600.jpg",Klasor="imm-k-002-2-k"},
                        new Images(){ImagePath="imm-k-002-2-k-2-2-600x600.jpg",Klasor="imm-k-002-2-k"},
                        new Images(){ImagePath="imm-k-002-2-k-ölçüleri-600x600.jpg",Klasor="imm-k-002-2-k"},
                        new Images(){ImagePath="imm-k-002-2-k-r-600x600.jpg",Klasor="imm-k-002-2-k"},
                    }
                },
                           new icMekanMobilya()
                {
                    icMekanId=12,
                    UrunAdi="imm-k-003-2-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-003-2-k-600x600.jpg",Klasor="imm-k-003-2-k"},
                        new Images(){ImagePath="imm-k-003-2-k-3-1-600x600.jpg",Klasor="imm-k-003-2-k"},
                        new Images(){ImagePath="imm-k-003-2-k-2-1-600x600.jpg",Klasor="imm-k-003-2-k"},
                        new Images(){ImagePath="imm-k-003-2-k-ölçüleri-600x600.jpg",Klasor="imm-k-003-2-k"},
                        new Images(){ImagePath="imm-k-003-2-k-r-600x600.jpg",Klasor="imm-k-003-2-k"},
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=13,
                    UrunAdi="imm-k-004-2",
                    En="360 mm",
                    Boy="1300 mm",
                    Yukseklik="2098 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-004-600x600.jpg",Klasor="imm-k-004-2"},
                        new Images(){ImagePath="imm-k-004-2-3-600x600.jpg",Klasor="imm-k-004-2"},
                        new Images(){ImagePath="imm-k-004-2-1-600x600.jpg",Klasor="imm-k-004-2"},
                        new Images(){ImagePath="imm-k-004-2-ölçüleri-600x600.jpg",Klasor="imm-k-004-2"},
                        new Images(){ImagePath="imm-k-004-2-r-600x600.jpg",Klasor="imm-k-004-2"},
                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=14,
                    UrunAdi="imm-k-005",
                    En="360 mm",
                    Boy="1300 mm",
                    Yukseklik="2098 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-005-2-1-600x600.jpg",Klasor="imm-k-005"},
                        new Images(){ImagePath="imm-k-005-3-600x600.jpg",Klasor="imm-k-005"},
                        new Images(){ImagePath="imm-k-005-600x600.jpg",Klasor="imm-k-005"},
                        new Images(){ImagePath="imm-k-005-ölçüleri-600x600.jpg",Klasor="imm-k-005"},
                        new Images(){ImagePath="imm-k-005-r-600x600.jpg",Klasor="imm-k-005"},
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=15,
                    UrunAdi="imm-masa-005",
                    En="1200 mm",
                    Boy="1200 mm",
                    Yukseklik="420 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-005.jpg",Klasor="imm-masa-005"},
                        new Images(){ImagePath="imm-masa-005-1-600x600.jpg",Klasor="imm-masa-005"},

                        new Images(){ImagePath="imm-masa-005-ölçüleri-600x600.jpg",Klasor="imm-masa-005"},
                        new Images(){ImagePath="imm-masa-005-600x600.jpg",Klasor="imm-masa-005"},
                    }
                },
                     new icMekanMobilya()
                {
                    icMekanId=16,
                    UrunAdi="imm-masa-002",
                    En="1200 mm",
                    Boy="1200 mm",
                    Yukseklik="457 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-002.jpg",Klasor="imm-masa-002"},
                        new Images(){ImagePath="imm-masa-002-1-600x600.jpg",Klasor="imm-masa-002"},

                        new Images(){ImagePath="imm-masa-002-ölçüleri-600x600.jpg",Klasor="imm-masa-002"},
                        new Images(){ImagePath="imm-masa-002-600x600.jpg",Klasor="imm-masa-002"},
                    }
                },
                          new icMekanMobilya()
                {
                    icMekanId=17,
                    UrunAdi="imm-k-001-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-001-k-1-600x600.jpg",Klasor="imm-k-001-k"},
                        new Images(){ImagePath="imm-k-001-k-2-1-600x600.jpg",Klasor="imm-k-001-k"},

                        new Images(){ImagePath="imm-k-001-k-3-1-600x600.jpg",Klasor="imm-k-001-k"},
                        new Images(){ImagePath="imm-k-001-k-ölçüleri-1-600x600.jpg",Klasor="imm-k-001-k"},
                         new Images(){ImagePath="imm-k-001-k-r-1-600x600.jpg",Klasor="imm-k-001-k"}
                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=18,
                    UrunAdi="imm-k-002-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-002-2-k-5-600x600.jpg",Klasor="imm-k-002-k"},
                        new Images(){ImagePath="imm-k-002-2-k-3-3-600x600.jpg",Klasor="imm-k-002-k"},

                        new Images(){ImagePath="imm-k-002-2-k-2-3-600x600.png",Klasor="imm-k-002-k"},


                        new Images(){ImagePath="imm-k-002-k-ölçüleri-1-600x600.jpg",Klasor="imm-k-002-k"},
                         new Images(){ImagePath="imm-k-002-2-k-r-1-600x600.jpg",Klasor="imm-k-002-k"}
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=19,
                    UrunAdi="imm-k-003",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-003-600x600.jpg",Klasor="imm-k-003"},
                        new Images(){ImagePath="imm-k-003-1-1-600x600.jpg",Klasor="imm-k-003"},

                        new Images(){ImagePath="imm-k-003-2-1-600x600.png",Klasor="imm-k-003"},
                        new Images(){ImagePath="imm-k-003-ölçüleri-600x600.jpg",Klasor="imm-k-003"},
                         new Images(){ImagePath="imm-k-003-r-600x600.jpg",Klasor="imm-k-003"}
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=20,
                    UrunAdi="imm-ob-06",
                    En="636 mm",
                    Boy="855,5 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-06-3-600x600.jpg",Klasor="imm-ob-06"},
                        new Images(){ImagePath="imm-ob-06-1-600x600.jpg",Klasor="imm-ob-06"},

                        new Images(){ImagePath="imm-ob-06-2-600x600.jpg",Klasor="imm-ob-06"},
                        new Images(){ImagePath="imm-ob-06-ölçüleri-1-600x600.jpg",Klasor="imm-ob-06"},
                         new Images(){ImagePath="imm-ob-06-r-600x600.jpg",Klasor="imm-ob-06"}
                    }
                },
                      new icMekanMobilya()
                {
                    icMekanId=21,
                    UrunAdi="imm-k-004",
                    En="360 mm",
                    Boy="1300 mm",
                    Yukseklik="2298 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-004-3-600x600.jpg",Klasor="imm-k-004"},
                        new Images(){ImagePath="imm-k-004-2-2-600x600.jpg",Klasor="imm-k-004"},

                        new Images(){ImagePath="imm-k-004-3-1-600x600.jpg",Klasor="imm-k-004"},
                        new Images(){ImagePath="imm-k-004-ölçüleri-600x600.jpg",Klasor="imm-k-004"},
                         new Images(){ImagePath="mm-k-004-r-600x600.jpg",Klasor="imm-k-004"}
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=22,
                    UrunAdi="imm-masa-003",
                    En="1200 mm",
                    Boy="1200 mm",
                    Yukseklik="420 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-003-satine.jpg",Klasor="imm-masa-003"},
                        new Images(){ImagePath="imm-masa-003-1-satine-600x600.jpg",Klasor="imm-masa-003"},

                        new Images(){ImagePath="imm-masa-003-ölçüleri-600x600.jpg",Klasor="imm-masa-003"},
                        new Images(){ImagePath="imm-masa-003-600x600.jpg",Klasor="imm-masa-003"},

                    }
                },
                    new icMekanMobilya()
                {
                    icMekanId=23,
                    UrunAdi="imm-masa-004",
                    En="1320 mm",
                    Boy="1320 mm",
                    Yukseklik="417 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    AhsapKaplama="Teak Moire, Palisanderholz Moire, Ebenholz Braun, Dicke Maserung Eichenholz, Eichenholz Extra, Platin ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-masa-004.jpg",Klasor="imm-masa-004"},
                        new Images(){ImagePath="imm-masa-004-1-600x600.jpg",Klasor="imm-masa-004"},

                        new Images(){ImagePath="imm-masa-004-ölçüleri-600x600.jpg",Klasor="imm-masa-004"},
                        new Images(){ImagePath="imm-masa-004-600x600.jpg",Klasor="imm-masa-004"},
                    }
                },
                       new icMekanMobilya()
                {
                    icMekanId=24,
                    UrunAdi="imm-ob-07",
                    En="568,5 mm",
                    Boy="689 mm",
                    Yukseklik="1151 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-07-güncel-600x600.jpg",Klasor="imm-ob-07"},
                        new Images(){ImagePath="imm-ob-07-1güncel-600x600.jpg",Klasor="imm-ob-07"},

                        new Images(){ImagePath="imm-ob-07-3-600x600.jpg",Klasor="imm-ob-07"},
                        new Images(){ImagePath="imm-ob-07-ölçüleri-600x600.jpg",Klasor="imm-ob-07"},
                        new Images(){ImagePath="imm-ob-07-600x600.jpg",Klasor="imm-ob-07"},
                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=25,
                    UrunAdi="imm-ob-08",
                    En="580 mm",
                    Boy="630 mm",
                    Yukseklik="986 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme="188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-08-1-600x600.jpg",Klasor="imm-ob-08"},
                        new Images(){ImagePath="imm-ob-08-2-600x600.jpg",Klasor="imm-ob-08"},

                        new Images(){ImagePath="imm-ob-08-1-1-600x600.jpg",Klasor="imm-ob-08"},
                        new Images(){ImagePath="imm-ob-08-ÖLÇÜLERİ-600x600.jpg",Klasor="imm-ob-08"},
                        new Images(){ImagePath="imm-ob-08-r-600x600.jpg",Klasor="imm-ob-08"},
                    }
                },
                  new icMekanMobilya()
                {
                    icMekanId=26,
                    UrunAdi="imm-ob-09",
                    En="580 mm",
                    Boy="632,5 mm",
                    Yukseklik="986 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme="188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-09-1-600x600.jpg",Klasor="imm-ob-09"},
                        new Images(){ImagePath="imm-ob-09-2-600x600.jpg",Klasor="imm-ob-09"},

                        new Images(){ImagePath="imm-ob-09-1-1-600x600.jpg",Klasor="imm-ob-09"},
                        new Images(){ImagePath="imm-ob-09-ölçüleri-600x600.jpg",Klasor="imm-ob-09"},
                        new Images(){ImagePath="imm-ob-09-r-600x600.jpg",Klasor="imm-ob-09"},
                    }
                },
                    new icMekanMobilya()
                {
                    icMekanId=27,
                    UrunAdi="imm-ob-03",
                    En="766,5 mm",
                    Boy="1510 mm/1710 mm/1870 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme=" 188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-03-1-600x600.jpg",Klasor="imm-ob-03"},
                        new Images(){ImagePath="imm-ob-03-2-600x600.jpg",Klasor="imm-ob-03"},

                        new Images(){ImagePath="imm-ob-03-3-600x600.jpg",Klasor="imm-ob-03"},
                        new Images(){ImagePath="imm-ob-03-ölçüleri-600x600.jpg",Klasor="imm-ob-03"},
                        new Images(){ImagePath="imm-ob-03-r-600x600.jpg",Klasor="imm-ob-03"},
                    }
                },
                   new icMekanMobilya()
                {
                    icMekanId=28,
                    UrunAdi="imm-ob-04",
                    En="766,5 mm",
                    Boy="1510 mm/1710 mm/1870 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme="188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-04-1-600x600.jpg",Klasor="imm-ob-04"},
                        new Images(){ImagePath="imm-ob-04-2-600x600.jpg",Klasor="imm-ob-04"},

                        new Images(){ImagePath="imm-ob-04-3-600x600.jpg",Klasor="imm-ob-04"},
                        new Images(){ImagePath="imm-ob-04-ölçüleri-600x600.jpg",Klasor="imm-ob-04"},
                        new Images(){ImagePath="imm-ob-04-r-600x600.jpg",Klasor="imm-ob-04"},
                    }
                },
                     new icMekanMobilya()
                {
                    icMekanId=29,
                    UrunAdi="imm-ob-05",
                    En="766,5 mm",
                    Boy="766,5 mm",
                    Yukseklik="905,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    KumasDoseme="188-189 ",

                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-ob-05-1-600x600.jpg",Klasor="imm-ob-05"},
                        new Images(){ImagePath="imm-ob-05-2-600x600.jpg",Klasor="imm-ob-05"},
                        new Images(){ImagePath="imm-ob-05-ölçüleri-600x600.jpg",Klasor="imm-ob-05"},
                        new Images(){ImagePath="imm-ob-05-r-600x600.jpg",Klasor="imm-ob-05"},
                    }
                },
                           new icMekanMobilya()
                {
                    icMekanId=30,
                    UrunAdi="imm-k-003-k",
                    En="340 mm",
                    Boy="730 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-003-k-1-600x600.jpg",Klasor="imm-k-003-k"},
                        new Images(){ImagePath="imm-k-003-k-2-1-600x600.jpg",Klasor="imm-k-003-k"},
                        new Images(){ImagePath="imm-k-003-k-3-1-600x600.jpg",Klasor="imm-k-003-k"},
                        new Images(){ImagePath="imm-k-003-k-ölçüleri-1-600x600.jpg",Klasor="imm-k-003-k"},
                        new Images(){ImagePath="imm-k-003-6raflı-1080-1-600x600.jpg",Klasor="imm-k-003-k"},

                    }
                },
                 new icMekanMobilya()
                {
                    icMekanId=31,
                    UrunAdi="imm-k-003-2",
                    En="340 mm",
                    Boy="1300 mm",
                    Yukseklik="2100 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    YuzeyTipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="imm-k-003-2-4-600x600.jpg",Klasor="imm-k-003-2"},
                        new Images(){ImagePath="imm-k-003-2-3-600x600.jpg",Klasor="imm-k-003-2"},
                        new Images(){ImagePath="imm-k-003-2-2-1-600x600.jpg",Klasor="imm-k-003-2"},
                        new Images(){ImagePath="imm-k-003-2-ölçüleri-600x600.jpg",Klasor="imm-k-003-2"},
                        new Images(){ImagePath="imm-k-003-2-r-600x600.jpg",Klasor="imm-k-003-2"},

                    }
                },
                };
            aksesuarModels = new List<AksesuarModel>()
            {
                new AksesuarModel
                {
                    aksesuarId=1,
                    UrunAdi="agm-001",
                    En="59 mm",
                    Boy="920 mm",
                    Yukseklik="920 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-001.jpg",Klasor="agm-001"},
                        new Images(){ImagePath="ayna-001-Model-600x600.jpg",Klasor="agm-001"},
                        new Images(){ImagePath="ayna-001-600x600.jpg",Klasor="agm-001"},
                    }
                },
                 new AksesuarModel
                {
                    aksesuarId=2,
                    UrunAdi="agm-002",
                    En="40 mm",
                    Boy="909 mm",
                    Yukseklik="909 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-002.jpg",Klasor="agm-002"},
                        new Images(){ImagePath="ayna-002-Model-600x600.jpg",Klasor="agm-002"},
                        new Images(){ImagePath="ayna-002-600x600.jpg",Klasor="agm-002"},
                    }
                },
                     new AksesuarModel
                {
                    aksesuarId=3,
                    UrunAdi="agm-003",
                    En="40 mm",
                    Boy="900 mm",
                    Yukseklik="900 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-003.jpg",Klasor="agm-003"},
                        new Images(){ImagePath="ayna-003-Model-600x600.jpg",Klasor="agm-003"},
                        new Images(){ImagePath="ayna-003-600x600.jpg",Klasor="agm-003"},
                    }
                },
                   new AksesuarModel
                {
                    aksesuarId=4,
                    UrunAdi="agm-004",
                    En="40 mm",
                    Boy="900 mm",
                    Yukseklik="900 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-004.jpg",Klasor="agm-004"},
                        new Images(){ImagePath="ayna-004-Model-600x600.jpg",Klasor="agm-004"},
                        new Images(){ImagePath="ayna-004-600x600.jpg",Klasor="agm-004"},
                    }
                },
                  new AksesuarModel
                {
                    aksesuarId=5,
                    UrunAdi="agm-005",
                    En="50 mm",
                    Boy="900 mm",
                    Yukseklik="900 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-005.jpg",Klasor="agm-005"},
                        new Images(){ImagePath="ayna-005-ölçüleri-600x600.jpg",Klasor="agm-005"},
                        new Images(){ImagePath="ayna-005-600x600.jpg",Klasor="agm-005"},
                    }
                },
                new AksesuarModel
                {
                    aksesuarId=6,
                    UrunAdi="agm-006",
                    En="50 mm",
                    Boy="900 mm",
                    Yukseklik="900 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="ayna-006.jpg",Klasor="agm-006"},
                        new Images(){ImagePath="ayna-006-ölçüleri-600x600.jpg",Klasor="agm-006"},
                        new Images(){ImagePath="ayna-006-600x600.jpg",Klasor="agm-006"},
                    }
                },
                new AksesuarModel
                {
                    aksesuarId=7,
                    UrunAdi="dt-004",
                    En="410 mm",
                    Boy="493 mm",
                    Yukseklik="120 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",

                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="dus-oturagi-004-600x600.jpg",Klasor="dt-004"},
                        new Images(){ImagePath="dus-oturagi-003-ölçüleri-600x600.jpg",Klasor="dt-004"},

                    }
                },
                 new AksesuarModel
                {
                    aksesuarId=8,
                    UrunAdi="etb-001",
                    En="120 mm",
                    Boy="748 mm",
                    Yukseklik="250 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="etb-engelli-tutunma-bari-001-600x600.jpg",Klasor="etb-001"},
                        new Images(){ImagePath="etb-engelli-tutunma-bari-001-ölçüleri-600x600.jpg",Klasor="etb-001"},

                    }
                },
                    new AksesuarModel
                {
                    aksesuarId=9,
                    UrunAdi="etb-002",
                    En="105 mm",
                    Boy="659,5 mm",
                    Yukseklik="60 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="etb-engelli-tutunma-bari-002-600x600.jpg",Klasor="etb-002"},
                        new Images(){ImagePath="etb-engelli-tutunma-bari-002-ölçüleri-600x600.jpg",Klasor="etb-002"},

                    }
                },
                      new AksesuarModel
                {
                    aksesuarId=10,
                    UrunAdi="etb-002-2",
                    En="105 mm",
                    Boy="657,5 mm",
                    Yukseklik="307 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="etb-engelli-tutunma-bari-002-2-r-600x600.jpg",Klasor="etb-002-2"},
                        new Images(){ImagePath="etb-engelli-tutunma-bari-002-2-ölçüleri-600x600.jpg",Klasor="etb-002-2"},

                    }
                },
                 new AksesuarModel
                {
                    aksesuarId=11,
                    UrunAdi="etb-003",
                    En="60 mm",
                    Boy="765 mm",
                    Yukseklik="780 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="etb-engelli-tutunma-bari-003-600x600.jpg",Klasor="etb-003"},
                        new Images(){ImagePath="etb-engelli-tutunma-bari-003-ölçüleri-600x600.jpg",Klasor="etb-003"},

                    }
                },
                  new AksesuarModel
                {
                    aksesuarId=12,
                    UrunAdi="twl-001",
                    En="69 mm",
                    Boy="600 mm",
                    Yukseklik="52 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="havluluk1-600x600.jpg",Klasor="twl-001"},
                        new Images(){ImagePath="havluluk-001-1-600x600.jpg",Klasor="twl-001"},
                        new Images(){ImagePath="havluluk-001-ölçüleri-600x600.jpg",Klasor="twl-001"},

                    }
                },
                 new AksesuarModel
                {
                    aksesuarId=13,
                    UrunAdi="twl-002",
                    En="60 mm",
                    Boy="600 mm",
                    Yukseklik="30 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="havlulu-002-1-600x600.jpg",Klasor="twl-002"},
                         new Images(){ImagePath="havluluk-002-r-600x600.jpg",Klasor="twl-002"},
                        new Images(){ImagePath="havluluk-002-ölçüleri-1-600x600.jpg",Klasor="twl-002"},
                    }
                },
                     new AksesuarModel
                {
                    aksesuarId=14,
                    UrunAdi="twl-002-2",
                    En="107 mm",
                    Boy="600 mm",
                    Yukseklik="52 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="havluluk-002-2-600x600.jpg",Klasor="twl-002-2"},
                        new Images(){ImagePath="havluluk-002-2-ölçüleri-600x600.jpg",Klasor="twl-002-2"},
                         new Images(){ImagePath="havluluk-002-2-r-600x600.jpg",Klasor="twl-002-2"},
                    }
                },
                      new AksesuarModel
                {
                    aksesuarId=15,
                    UrunAdi="twl-003",
                    En="33 mm",
                    Boy="433 mm",
                    Yukseklik="224 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="havluluk3-600x600.jpg",Klasor="twl-003"},
                        new Images(){ImagePath="havluluk-003-ölçüleri-600x600.jpg",Klasor="twl-003"},
                         new Images(){ImagePath="havluluk-003-600x600.jpg",Klasor="twl-003"},
                    }
                },
                          new AksesuarModel
                {
                    aksesuarId=16,
                    UrunAdi="twl-004",
                    En="250 mm",
                    Boy="630 mm",
                    Yukseklik="127 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="havluluk-004-600x600.jpg",Klasor="twl-004"},
                        new Images(){ImagePath="havluluk-004-ölçüleri-600x600.jpg",Klasor="twl-004"},
                         new Images(){ImagePath="havluluk-004-r-1-600x600.jpg",Klasor="twl-004"},
                    }
                },

            };
            aydinlatmaModels = new List<AydinlatmaModel>()
            {
                new AydinlatmaModel
                {
                    AydinlatmaId=1,
                    UrunAdi="au-001",
                    En="400 mm",
                    Boy="1349,8 mm",
                    Yukseklik="5000 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="  Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme=" Beleuchtung IP65  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-001satine.jpg",Klasor="au-001"},
                        new Images(){ImagePath="au-001-2satine-600x600.jpg",Klasor="au-001"},
                        new Images(){ImagePath="au-001-3satine-2-600x600.jpg",Klasor="au-001"},
                        new Images(){ImagePath="au-001-Model-600x600.jpg",Klasor="au-001"},
                        new Images(){ImagePath="au-001-600x600.jpg",Klasor="au-001"},
                    }

                },
                new AydinlatmaModel
                {
                    AydinlatmaId=2,
                    UrunAdi="au-002",
                    En="250 mm",
                    Boy="1550 mm",
                    Yukseklik="5000 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="  Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme="Beleuchtung IP65  ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-002satine.jpg",Klasor="au-002"},
                        new Images(){ImagePath="au-002-2satine-600x600.jpg",Klasor="au-002"},
                        new Images(){ImagePath="au-002-3satine-600x600.jpg",Klasor="au-002"},
                        new Images(){ImagePath="au-002-Model-600x600.jpg",Klasor="au-002"},
                        new Images(){ImagePath="au-002-600x600.jpg",Klasor="au-002"},
                    }
                },
                  new AydinlatmaModel
                {
                    AydinlatmaId=3,
                    UrunAdi="au-003",
                    En="220 mm",
                    Boy="1500 mm",
                    Yukseklik="3290 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme="Beleuchtung IP65  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-003-1satine.jpg",Klasor="au-003"},
                        new Images(){ImagePath="au-003-2satine.jpg",Klasor="au-003"},
                        new Images(){ImagePath="au-003-3satine.jpg",Klasor="au-003"},
                        new Images(){ImagePath="au-003-Model.jpg",Klasor="au-003"},
                        new Images(){ImagePath="au-003-600x600.jpg",Klasor="au-003"},
                    }
                },
                        new AydinlatmaModel
                {
                    AydinlatmaId=4,
                    UrunAdi="au-d-001",
                    En="250 mm",
                    Boy="300 mm",
                    Yukseklik="1005 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme="Beleuchtung IP65  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-d-001-satine.jpg",Klasor="au-d-001"},
                        new Images(){ImagePath="au-d-001-1-satine-600x600.jpg",Klasor="au-d-001"},
                        new Images(){ImagePath="au-d-001-3satine-600x600.jpg",Klasor="au-d-001"},
                        new Images(){ImagePath="au-d-001-Model-600x600.jpg",Klasor="au-d-001"},
                        new Images(){ImagePath="au-d-001-600x600.jpg",Klasor="au-d-001"},
                    }
                },
                                new AydinlatmaModel
                {
                    AydinlatmaId=5,
                    UrunAdi="au-d-002",
                    En="227 mm",
                    Boy="227 mm",
                    Yukseklik="1246 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme="Beleuchtung IP65 ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-d-002-satine.jpg",Klasor="au-d-002"},
                        new Images(){ImagePath="au-d-002-ölçüleri-600x600.jpg",Klasor="au-d-002"},

                        new Images(){ImagePath="au-d-002-600x600.jpg",Klasor="au-d-002"},
                    }
                },
                 new AydinlatmaModel
                {
                    AydinlatmaId=6,
                    UrunAdi="au-d-003",
                    En="150 mm",
                    Boy="150 mm",
                    Yukseklik="1005 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    EkMalzeme="Beleuchtung IP65  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="au-d-003satine.jpg",Klasor="au-d-003"},
                        new Images(){ImagePath="au-d-003-1satine-600x600.jpg",Klasor="au-d-003"},

                        new Images(){ImagePath="au-d-003-Model-600x600.jpg",Klasor="au-d-003"},
                        new Images(){ImagePath="au-d-003-600x600.jpg",Klasor="au-d-003"},

                    }
                },

            };
            kentModels = new List<KentModel>()
            {
                new KentModel
                {
                    KentId=1,
                    UrunAdi="km-ck-001",
                    En="300 mm",
                    Boy="300 mm",
                    Yukseklik="503 mm / 803 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="  Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ck-001-1-600x600.jpg",Klasor="km-ck-001"},
                        new Images(){ImagePath="km-ck-001-ölçüleri-600x600.jpg",Klasor="km-ck-001"},
                        new Images(){ImagePath="km-ck-001-r-600x600.jpg",Klasor="km-ck-001"},
                    }
                },
                 new KentModel
                {
                    KentId=2,
                    UrunAdi="km-ck-001-3",
                    En="500 mm",
                    Boy="500 mm",
                    Yukseklik="503 mm / 803 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ck-001-3-600x600.jpg",Klasor="km-ck-001-3"},
                        new Images(){ImagePath="km-ck-001-3-ölçüleri-600x600.jpg",Klasor="km-ck-001-3"},

                    }
                },
                  new KentModel
                {
                    KentId=3,
                    UrunAdi="km-ck-002",
                    En="500 mm",
                    Boy="500 mm",
                    Yukseklik="711 mm / 803 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ck-002-1-600x600.jpg",Klasor="km-ck-002"},
                        new Images(){ImagePath="km-ck-002-ölçüleri-600x600.jpg",Klasor="km-ck-002"},
                        new Images(){ImagePath="km-ck-002-r-600x600.jpg",Klasor="km-ck-002"},

                    }
                },
                      new KentModel
                {
                    KentId=4,
                    UrunAdi="km-ck-003",
                    En="511 mm",
                    Boy="369 mm",
                    Yukseklik="1075,5 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ck-003-1-600x600.jpg",Klasor="km-ck-003"},
                        new Images(){ImagePath="km-ck-003-ölçüleri-600x600.jpg",Klasor="km-ck-003"},
                        new Images(){ImagePath="km-ck-003-r-600x600.jpg",Klasor="km-ck-003"},

                    }
                },
                new KentModel
                {
                    KentId=5,
                    UrunAdi="km-d-001",
                    En="300 mm",
                    Boy="300 mm",
                    Yukseklik="550 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-001-600x600.jpg",Klasor="km-d-001"},
                        new Images(){ImagePath="km-d-001-2-600x600.jpg",Klasor="km-d-001"},
                        new Images(){ImagePath="km-d-001-Model3-600x600.jpg",Klasor="km-d-001"},
                        new Images(){ImagePath="km-d-001-5-600x600.jpg",Klasor="km-d-001"},
                    }
                },
                  new KentModel
                {
                    KentId=6,
                    UrunAdi="km-d-001-2",
                    En="300 mm",
                    Boy="300 mm",
                    Yukseklik="550 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-001-2-1-600x600.jpg",Klasor="km-d-001-2"},
                        new Images(){ImagePath="km-d-001-2-1-1-600x600.jpg",Klasor="km-d-001-2"},
                        new Images(){ImagePath="km-d-001-Model2-600x600.jpg",Klasor="km-d-001-2"},
                        new Images(){ImagePath="km-d-001-2-2-600x600.jpg",Klasor="km-d-001-2"},
                    }
                },
                        new KentModel
                {
                    KentId=7,
                    UrunAdi="km-d-001-3",
                    En="250 mm",
                    Boy="250 mm",
                    Yukseklik="510 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-001-3-1-600x600.jpg",Klasor="km-d-001-3"},

                        new Images(){ImagePath="km-d-001-Model-1-600x600.jpg",Klasor="km-d-001-3"},
                        new Images(){ImagePath="km-d-001-3-2-600x600.jpg",Klasor="km-d-001-3"},
                    }
                },
                 new KentModel
                {
                    KentId=8,
                    UrunAdi="km-d-002",
                    En="232,5 mm",
                    Boy="1100 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-001-1-600x600.jpg",Klasor="km-d-002"},
                        new Images(){ImagePath="km-d-002-Model-600x600.jpg",Klasor="km-d-002"},
                        new Images(){ImagePath="km-d-002-2-600x600.jpg",Klasor="km-d-002"},
                    }
                },
                   new KentModel
                {
                    KentId=9,
                    UrunAdi="km-d-002-02",
                    En="285 mm",
                    Boy="1100 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim=" HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-002-600x600.jpg",Klasor="km-d-002-02"},
                        new Images(){ImagePath="km-d-002-Model2-600x600.jpg",Klasor="km-d-002-02"},
                        new Images(){ImagePath="km-d-002-02-600x600.jpg",Klasor="km-d-002-02"},
                    }
                },
                   new KentModel
                {
                    KentId=10,
                    UrunAdi="km-d-002-03",
                    En="213 mm",
                    Boy="1113 mm",
                    Yukseklik="2300 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk=" Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-004-600x600.jpg",Klasor="km-d-002-03"},
                        new Images(){ImagePath="km-d-002-Model3-600x600.jpg",Klasor="km-d-002-03"},
                        new Images(){ImagePath="km-d-002-03-600x600.jpg",Klasor="km-d-002-03"},
                    }
                },
                          new KentModel
                {
                    KentId=11,
                    UrunAdi="km-d-003",
                    En="1498,5 mm",
                    Boy="4116,2 mm",
                    Yukseklik="2606,6 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Rotgold, Schwarz, Natur  ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte  ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-d-001-4-600x600.jpg",Klasor="km-d-003"},
                        new Images(){ImagePath="km-d-002-1-600x600.jpg",Klasor="km-d-003"},
                        new Images(){ImagePath="km-d-003-Model-600x600.jpg",Klasor="km-d-003"},
                        new Images(){ImagePath="km-d-003-600x600.jpg",Klasor="km-d-003"},
                    }
                },
                  new KentModel
                {
                    KentId=12,
                    UrunAdi="km-ob-001",
                    En="420 mm",
                    Boy="1600 mm",
                    Yukseklik="450 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="  Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert  ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ob-001-1-1-600x600.jpg",Klasor="km-ob-001"},
                        new Images(){ImagePath="km-ob-001-2-2-600x600.jpg",Klasor="km-ob-001"},
                        new Images(){ImagePath="km-ob-001-3-600x600.jpg",Klasor="km-ob-001"},
                        new Images(){ImagePath="km-ob-001-ölçüleri-1-600x600.jpg",Klasor="km-ob-001"},

                        new Images(){ImagePath="km-ob-001-r-600x600.jpg",Klasor="km-ob-001"},
                    }
                },
                       new KentModel
                {
                    KentId=13,
                    UrunAdi="km-ob-002",
                    En="717,9 mm",
                    Boy="1750 mm",
                    Yukseklik="1010,2 mm",
                    Malzeme="AISI 304 / AISI 316 (EN 1,4301, EN 1,4401)",
                    Renk="Gold, Rotgold, Schwarz, Natur ",
                    Yuzeytipi="Satin, Poliert ",
                    TemizlikveBakim="HRP-F Pflegeprodukte ",
                    Images= new List<Images>()
                    {
                        new Images(){ImagePath="km-ob-002-5-600x600.jpg",Klasor="km-ob-002"},
                        new Images(){ImagePath="km-ob-002-3-1-600x600.jpg",Klasor="km-ob-002"},
                        new Images(){ImagePath="km-ob-002-2-2-600x600.jpg",Klasor="km-ob-002"},
                        new Images(){ImagePath="km-ob-002-ölçüleri-600x600.jpg",Klasor="km-ob-002"},
                        new Images(){ImagePath="km-ob-002-r-600x600.jpg",Klasor="km-ob-002"},
                    }
                },
            };

        }
        public List<BahceModel> bahceModels { get; set; }
        public List<icMekanMobilya> icMekanMobilya { get; set; }
        public List<AksesuarModel> aksesuarModels { get; set; }
        public List<AydinlatmaModel> aydinlatmaModels { get; set; }
        public List<KentModel> kentModels { get; set; }
    }
}