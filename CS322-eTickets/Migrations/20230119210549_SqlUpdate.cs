using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS322eTickets.Migrations
{
    /// <inheritdoc />
    public partial class SqlUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Update MOVIES
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/KDK3srH/volim-te-najvise-na-svetu-poster.jpg' WHERE id = 1");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/85WwTFw/ustanicka-ulica-poster.jpg' WHERE id = 2");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/pQ3FYzk/tri-palme-za-dve-bitange-i-ribicu-poster.jpg' WHERE id = 3");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/hXQPrTH/sivi-kamion-crvene-boje-poster.jpg' WHERE id = 4");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/7NfLC5r/sesir-profesora-koste-vujica-serija-poster.jpg' WHERE id = 5");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/jzcJ83f/samac-u-braku-poster.jpg' WHERE id = 6");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/tmyy7qF/necista-krv-poster.jpg' WHERE id = 7");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/Gxnd8yZ/munje-poster.jpg' WHERE id = 8");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/bs3NjkD/mrtav-ladan-poster.jpg' WHERE id = 9");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/H2j7S3R/mala-nocna-muzika-poster.jpg' WHERE id = 10");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/Jv8BTkJ/lajanje-na-zvezde-flyer.jpg' WHERE id = 11");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/ftQxn6H/kad-porastem-bicu-kengur-poster.jpg' WHERE id = 12");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/94CY35X/flyer.jpg' WHERE id = 13");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/dpfytGX/flyer-1.jpg' WHERE id = 14");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/0Qg009G/falsifikator-poster.jpg' WHERE id = 15");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/gm9FNN6/branio-sam-mladu-bosnu-poster.jpg' WHERE id = 16");
            migrationBuilder.Sql("UPDATE Movies SET ImageURL = 'https://i.ibb.co/jMbZC1H/boomerang-flyer.jpg' WHERE id = 17");

            //Upadate ACTORS
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/SK54MVc/zoran-cvijanovic.jpg' WHERE id = 1");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/KX7JV1W/vuk-kostic.jpg' WHERE id = 2");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/W2GL4QH/tihomir-stanic.jpg' WHERE id = 3");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/Kxznf26/tanja-boskovic.jpg' WHERE id = 4");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/GVz3RdV/srdjan-todorovic.jpg' WHERE id = 5");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/R2zysQD/sergej-trifunovic.jpg' WHERE id = 6");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/s23VJj4/nikola-rakocevic.jpg' WHERE id = 7");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/sPtjKDN/nikola-djuricko.jpg' WHERE id = 8");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/3NZJsYZ/nenad-jezdic.jpg' WHERE id = 9");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/58zg4jw/nebojsa-glogovac.jpg' WHERE id = 10");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/48FNC9g/mima-karadzic.jpg' WHERE id = 11");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/4fz1Md1/natasa-tapuskovic.jpg' WHERE id = 12");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/dGWzXBF/milos-bikovic.jpg' WHERE id = 13");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/8MyhhB5/milena-radulovic.jpg' WHERE id = 14");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/g9Zjzbt/lazar-ristovski.jpg' WHERE id = 15");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/xYbf8D2/katarina-radivojevic.jpg' WHERE id = 16");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/5s0xmXr/gordan-kicic.jpg' WHERE id = 17");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/GvCnWV8/dubravka-mijatovic.jpg' WHERE id = 18");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/hLkvrv7/goran-radakovic.jpg' WHERE id = 19");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/zZ24Bqt/dragan-petrovic.jpg' WHERE id = 20");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/yR2qwb8/drahan-micanovic.jpg' WHERE id = 21");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/WxZTGTd/dragan-jovanovic.jpg' WHERE id = 22");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/yP9BQMT/dragan-bjelogrlic.jpg' WHERE id = 23");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/L1DDMt7/brankica-sebastijanovic.jpg' WHERE id = 24");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/cxK4bJx/branka-katic.jpg' WHERE id = 25");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/zPYGM92/boris-milivojevic.jpg' WHERE id = 26");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/dW9JyYr/andrija-milosevic.jpg' WHERE id = 27");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/2vZzvx8/andjela-jovanovic.jpg' WHERE id = 28");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/J5f216y/aleksandra-balmazovic.jpg' WHERE id = 29");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/F6M5YV8/aleksandar-radojcic.jpg' WHERE id = 30");
            migrationBuilder.Sql("UPDATE Actors SET ProfilePictureURL = 'https://i.ibb.co/J5f216y/aleksandra-balmazovic.jpg' WHERE id = 31");

            //Update PRODUCERS
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/zHVPDxy/predrag-velinovic.jpg' WHERE id = 1");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/YyKFfhK/miroslav-terzic.jpg' WHERE id = 2");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/5TGh8Kn/radivoje-andric.jpg' WHERE id = 3");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/p2Z80Ht/srdjan-koljevic.jpg' WHERE id = 4");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/gtkFrm3/zdravko-sotra.jpg' WHERE id = 5");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/7pv8g17/milorad-milinkovic.jpg' WHERE id = 6");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/Y7KBSBz/dejan-zecevic.jpg' WHERE id = 7");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/bmPcYJm/andrey-volgin.jpg' WHERE id = 8");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/xLX7ff5/miroslav-stamatov.jpg' WHERE id = 9");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/DDQZpv3/goran-markovic.jpg' WHERE id = 10");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/5WWSwkc/dragan-marinkovic.jpg' WHERE id = 11");
            migrationBuilder.Sql("UPDATE Producers SET ProfilePictureURL = 'https://i.ibb.co/DgS0R3N/imav-krstovic.jpg' WHERE id = 12");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
