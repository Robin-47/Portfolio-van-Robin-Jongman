-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2025 at 09:26 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `keukenprins`
--

-- --------------------------------------------------------

--
-- Table structure for table `blogs`
--

CREATE TABLE `blogs` (
  `blog_id` int(11) NOT NULL,
  `blog_title` varchar(255) NOT NULL,
  `blog_image` varchar(255) DEFAULT NULL,
  `blog_content` text NOT NULL,
  `blog_author` varchar(255) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `blogs`
--

INSERT INTO `blogs` (`blog_id`, `blog_title`, `blog_image`, `blog_content`, `blog_author`) VALUES
(9, 'Max Verstappen Teleurgesteld na GP van Monaco 2025', 'Verstappen.webp', '<p><br></p><hr><h2>Max Verstappen Teleurgesteld na GP van Monaco 2025: “Dit is niet echt racen”</h2><p>De Grand Prix van Monaco 2025 verliep voor Max Verstappen allesbehalve vlekkeloos. Na een moeilijke kwalificatie en een strategisch ongelukkige race moest de Nederlander genoegen nemen met een vierde plaats. De overwinning ging naar Lando Norris, die vanaf poleposition een foutloze race reed. Verstappen liet na afloop van zich horen met stevige kritiek op zowel het circuit als de gang van zaken binnen zijn team.</p><h3>Lastige start van het weekend</h3><p>Vanaf de eerste vrije trainingen had Verstappen moeite met de afstelling van zijn Red Bull RB21. Het circuit van Monaco, bekend om zijn smalle straten en hoge kerbstones, lag de auto duidelijk niet goed. Tijdens de kwalificatie bleek dat nog eens pijnlijk: Verstappen kon zich niet verder kwalificeren dan de zesde plaats, terwijl teamgenoot Sergio Pérez zelfs al in Q1 strandde. “We hebben alles geprobeerd dit weekend, maar niets werkte. Dan zit je gewoon vast,” verklaarde Verstappen gefrustreerd.</p><h3>Race zonder actie</h3><p>De race zelf bood weinig spektakel voor Verstappen. Door de aard van het stratencircuit waren inhaalacties vrijwel onmogelijk, en het team koos voor een strategie met twee pitstops om banden te sparen en eventueel voordeel te halen uit een safety car. Die kwam er echter niet, en daardoor verloor Verstappen waardevolle tijd en een mogelijke podiumplek.</p><p>Na de race was hij zichtbaar gefrustreerd: “We reden op sommige plekken letterlijk half gas en in een hogere versnelling om de banden te sparen. Dat is toch geen racen meer?”</p><h3>Kritiek op het circuit</h3><p>Verstappen spaarde het iconische circuit van Monaco niet in zijn commentaar. Hij noemde het format van de race \"ouderwets\" en gaf aan dat er dringend iets moet veranderen om echt racen mogelijk te maken. “Het is bijna Mario Kart. Je rijdt gewoon in een treintje achter elkaar en hoopt dat iemand een fout maakt.”</p><h3>Stand in het kampioenschap</h3><p>Door zijn vierde plaats moest Verstappen belangrijke punten laten liggen in de strijd om het wereldkampioenschap. Oscar Piastri leidt nu het klassement met 161 punten, gevolgd door Lando Norris met 158 punten. Verstappen volgt als derde met 136 punten. McLaren lijkt steeds sterker te worden en de voorsprong van Red Bull verdwijnt snel.</p><h3>Vooruitblik: Spanje</h3><p>De volgende race vindt plaats op het Circuit de Barcelona-Catalunya, waar Verstappen traditioneel sterk is. Hij hoopt daar het tij te keren en de aansluiting met de top van het klassement weer te vinden. Met bredere banen en meer inhaalmogelijkheden biedt het circuit in Spanje in ieder geval betere vooruitzichten dan het krappe Monaco.</p><hr><p><br></p>', 'Jack Plooij'),
(11, 'Nieuw F1 E-Sport Seizoen is van Start Gegaan!', 'F1 E-Sport.jpg', '<p><br></p><hr><p><b>Nieuw Esport F1 Seizoen is van Start Gegaan!</b></p><p>Het nieuwe Esport F1-seizoen is officieel van start gegaan, en fans van virtueel racen kunnen zich opnieuw opmaken voor een reeks spectaculaire races, intense competitie en razendsnelle rondetijden. De F1 Esports Series Pro Championship, de digitale tegenhanger van de Formule 1, trekt opnieuw een mix van professionele simracers en coureurs die verbonden zijn aan officiële Formule 1-teams.</p><h3>Wat is F1 Esports?</h3><p>De F1 Esports Series is een door Formula 1 georganiseerde competitie waarin e-racers het tegen elkaar opnemen in de officiële F1-videogame. Sinds de oprichting in 2017 is het kampioenschap uitgegroeid tot een volwaardige tak binnen de Formule 1-wereld, met professionele teams, grote prijzengelden en wereldwijde aandacht.</p><p>De races worden gereden op het nieuwste F1-spel van EA Sports en Codemasters, dat realistische simulaties biedt van de circuits, auto’s en weersomstandigheden. Coureurs gebruiken speciale sim-racing rigs om de ervaring zo dicht mogelijk bij echte F1-races te brengen.</p><h3>Start van het Seizoen</h3><p>Het nieuwe seizoen begon deze week met de eerste kwalificatie-evenementen en de openingsrondes van het kampioenschap. Er doen opnieuw 10 officiële F1-teams mee, waaronder Mercedes-AMG Petronas Esports, Oracle Red Bull Racing Esports en Ferrari Esports. Elk team heeft een line-up van getalenteerde simracers geselecteerd, die door middel van tijdritten en draft-events hun plek hebben verdiend.</p><p>De kalender van dit seizoen bestaat uit meerdere virtuele Grands Prix, waaronder iconische circuits zoals Silverstone, Spa-Francorchamps, Monza en het Yas Marina Circuit. De coureurs strijden niet alleen voor de eer, maar ook voor belangrijke punten en een aanzienlijk prijzengeldpot.</p><h3>Wat Kunnen Fans Verwachten?</h3><p>Met elk jaar een stijgend niveau van concurrentie en technologische verfijning in de gamesoftware, belooft het seizoen 2025 opnieuw spannend te worden. De races worden uitgezonden met professionele commentatoren, live statistieken en in-game strategieën die niet onderdoen voor echte F1-uitzendingen.</p><p>Naast de races zelf is er veel aandacht voor de voorbereiding van de coureurs, teamstrategie en technologische ontwikkelingen binnen de simrace-industrie. Fans kunnen rekenen op interactieve content, analyses en exclusieve interviews met de e-coureurs.</p><h3>Conclusie</h3><p>De aftrap van het nieuwe Esport F1-seizoen onderstreept hoe serieus de virtuele tak van motorsport inmiddels genomen wordt. Voor veel jonge coureurs is het bovendien een springplank naar een carrière in echte autosport. De komende maanden beloven dan ook boeiend te worden voor iedereen die van snelheid, strategie en digitale precisie houdt.</p><hr><p><br></p>', 'Will Buxton'),
(12, 'De Strijd om F1-commentaar in Nederland', 'Commentatoren.webp', '<p><br></p><hr><h2><b>\"Wie Brengt de Race tot Leven? De Strijd om F1-commentaar in Nederland\"</b></h2><p>Met de start van een nieuw Formule 1-seizoen is ook de discussie rondom het Nederlandse F1-commentaar weer volop actueel. Sinds de uitzendrechten in handen zijn van Viaplay, hebben veel fans moeite met het loslaten van de iconische stemmen van Olav Mol en Jack Plooij – een duo dat jarenlang onlosmakelijk verbonden was met de Nederlandse F1-beleving.</p><h3>Het Gouden Duo: Olav Mol en Jack Plooij</h3><p>Voor een hele generatie Nederlandse Formule 1-fans zijn Olav Mol en Jack Plooij dé stemmen van de sport. Olav, die al sinds 1991 F1-races van commentaar voorziet, werd geroemd om zijn enthousiasme en timing tijdens cruciale race-momenten. Jack Plooij bracht als pitreporter sfeer en directe inzichten vanaf de grid, vaak met een luchtige toon en direct contact met coureurs.</p><p>Het duo wist races niet alleen te verslaan, maar ook te beleven mét het publiek. Dat maakte hen geliefd — hun commentaar voelde vertrouwd, gepassioneerd en authentiek. Toen Ziggo Sport in 2021 de uitzendrechten verloor, viel voor velen een stukje F1-traditie weg.</p><h3>Viaplay en de Nieuwe Richting</h3><p>Sinds 2022 heeft streamingdienst Viaplay de exclusieve rechten op de Formule 1 in Nederland. Daarmee kwam ook een nieuw commentaarteam in beeld, met onder anderen Nelson Valkenburg en Melroy Heemskerk. Hoewel zij professioneel en deskundig opereren, konden ze in de ogen van veel fans de sfeer en persoonlijkheid van hun voorgangers niet direct evenaren.</p><p>Viaplay kiest voor een moderne en meer neutrale benadering, waarbij verslaggeving strakker geregisseerd is en meer op feiten dan op gevoel leunt. Voor sommige kijkers een welkome vernieuwing, maar voor anderen een gemis aan emotie en karakter.</p><h3>Het Verlangen naar het Vertrouwde</h3><p>De roep om een terugkeer van Mol en Plooij blijft luid onder een grote groep fans. Dat bleek onder meer uit het massaal beluisteren van alternatieve commentaarstreams, zoals via Grand Prix Radio, waar Olav Mol zijn stem nog altijd laat horen. Tijdens raceweekenden blijkt de vraag naar hun vertrouwde geluid zo groot, dat servers soms overbelast raken.</p><p>Dit wijst op een dieper liggende behoefte: Formule 1 is voor veel kijkers méér dan een sport. Het is een beleving, waarbij vertrouwde stemmen net zo belangrijk zijn als snelle rondetijden. En in die beleving spelen Mol en Plooij voor velen nog steeds een hoofdrol.</p><h3>Een Verdeeld Publiek</h3><p>Wat opvalt is dat het Nederlandse publiek verdeeld is. Sommigen waarderen de frisse, meer zakelijke stijl van Viaplay en vinden dat het tijd is voor vernieuwing. Anderen blijven trouw aan hun ‘oude’ commentatoren en zoeken bewust naar alternatieve manieren om met hen mee te kijken en luisteren.</p><h3>Conclusie</h3><p>De vraag wie de beste Formule 1-commentator is, blijft subjectief. Wat vaststaat, is dat Olav Mol en Jack Plooij een onuitwisbare indruk hebben achtergelaten op de Nederlandse F1-geschiedenis. Of Viaplay erin slaagt hetzelfde te bereiken met het huidige team, zal de tijd leren. Eén ding is zeker: voor Nederlandse Formule 1-fans draait het niet alleen om de race op het asfalt, maar ook om de stemmen die die race tot leven brengen.</p><hr><p><br></p>', 'Tim Coronel'),
(13, 'EA en Haar Toekomst binnen de Formule 1', 'F1 Franchise.webp', '<p><br></p><hr><h2><b>\"Onzekere Toekomst voor F1 Games: Wat Betekent Dit voor Gamers?\"</b></h2><p>De Formule 1-games, ontwikkeld door Codemasters en sinds enkele jaren uitgegeven door EA Sports, zijn uitgegroeid tot een vaste waarde binnen de wereld van simracers en motorsportfans. Elk jaar kijken gamers uit naar de nieuwe editie, met verbeterde graphics, vernieuwde carrièremodi en actuele team- en circuitdata. Toch hangt er momenteel onzekerheid boven de toekomst van deze geliefde gamefranchise.</p><h3>Nieuwe Game, Oude Vragen</h3><p>De release van <i>F1 25</i> dit jaar bracht een reeks interessante vernieuwingen met zich mee: een nieuw hoofdstuk in de verhaalmodus, de mogelijkheid om in een eigen team het F1-veld te betreden, en zelfs alternatieve circuits met omgekeerde layouts. Op technisch vlak werd de game geoptimaliseerd voor de nieuwste generatie consoles, wat zorgde voor verbeterde prestaties en realistischere racefysica.</p><p>Toch is er niet alleen enthousiasme. Achter de schermen spelen er ontwikkelingen die zorgen baren bij fans van de franchise.</p><h3>Licentie en Toekomst</h3><p>De licentie voor het maken van officiële F1-games ligt bij EA Sports, in samenwerking met Codemasters. Maar de situatie rondom Codemasters is onrustig. De studio heeft recent interne veranderingen doorgemaakt, waaronder verschuivingen in personeel en het stopzetten van andere raceprojecten. Dit leidt tot de vraag: is de jaarlijkse F1-game nog wel gegarandeerd?</p><p>De onzekerheid komt voort uit twijfels over hoe EA Sports de licentie verder wil benutten en of Codemasters in zijn huidige vorm de capaciteit behoudt om jaarlijks een nieuwe titel af te leveren met dezelfde kwaliteit en diepgang.</p><h3>Wat Betekent Dit voor de Fans?</h3><p>Voor de fanatieke F1-gamer is de onduidelijkheid frustrerend. Velen kijken jaarlijks uit naar nieuwe updates, verbeteringen en actuele content. Als de reeks zou stoppen of pauzeren, zou dat een groot gemis zijn binnen de racegame-wereld.</p><p>Daarnaast roept het vragen op over digitale sportcompetities, zoals de F1 Esports Series, die volledig draaien op de officiële F1-game. Een onderbreking of verandering in de ontwikkeling van de game kan ook daar gevolgen hebben.</p><h3>Conclusie</h3><p>Hoewel <i>F1 25</i> nog volop gespeeld wordt en het seizoen pas net is begonnen, is de toekomst van de F1-gamefranchise allesbehalve zeker. Voorlopig kunnen fans genieten van wat er is, maar de vraag of er volgend jaar opnieuw een volwaardige titel verschijnt, blijft voorlopig onbeantwoord. Eén ding is duidelijk: de Formule 1-gamer hoopt op stabiliteit en innovatie – liefst allebei.</p><hr><p><br></p>', 'Webby87');

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `car_id` int(11) NOT NULL,
  `car_brand` varchar(50) NOT NULL,
  `car_type` varchar(50) NOT NULL,
  `car_color` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`car_id`, `car_brand`, `car_type`, `car_color`) VALUES
(1, 'Volkswagen', 'Golf', 'Blauw'),
(2, 'Toyota', 'Corolla', 'Zilver'),
(3, 'Ford', 'Focus', 'Rood'),
(4, 'BMW', '3 Serie', 'Zwart'),
(5, 'Mercedes-Benz', 'C-Klasse', 'Wit'),
(6, 'Audi', 'A3', 'Grijs'),
(7, 'Hyundai', 'i30', 'Geel'),
(8, 'Renault', 'Megane', 'Groen'),
(9, 'Nissan', 'Qashqai', 'Oranje'),
(10, 'Chevrolet', 'Cruze', 'Paars'),
(11, 'Volvo', 'V40', 'Bruin'),
(12, 'Mazda', '3', 'Roze'),
(13, 'Kia', 'Ceed', 'Turquoise'),
(14, 'Peugeot', '308', 'Zalm'),
(15, 'Citroen', 'C4', 'Lime'),
(16, 'Opel', 'Astra', 'Goud'),
(17, 'Subaru', 'Impreza', 'Zwart'),
(18, 'Fiat', 'Tipo', 'Blauw'),
(19, 'Skoda', 'Octavia', 'Rood'),
(20, 'Dodge', 'Dart', 'Zilver'),
(21, 'Tesla', 'Model 3', 'Groen'),
(22, 'Jaguar', 'XE', 'Oranje'),
(23, 'Lexus', 'IS', 'Paars'),
(24, 'Infiniti', 'Q50', 'Bruin'),
(25, 'Mitsubishi', 'Lancer', 'Roze'),
(26, 'Suzuki', 'SX4', 'Turquoise'),
(27, 'Alfa Romeo', 'Giulietta', 'Zalm'),
(28, 'Chrysler', '200', 'Lime'),
(29, 'Acura', 'ILX', 'Goud'),
(30, 'Buick', 'Verano', 'Blauw'),
(31, 'Cadillac', 'ATS', 'Rood'),
(32, 'Daihatsu', 'Charade', 'Zwart'),
(33, 'Ferrari', '488', 'Grijs'),
(34, 'Honda', 'Civic', 'Geel'),
(35, 'Isuzu', 'Gemini', 'Oranje'),
(36, 'Jeep', 'Cherokee', 'Paars'),
(37, 'Land Rover', 'Discovery', 'Bruin'),
(38, 'Maserati', 'Ghibli', 'Roze'),
(39, 'Mini', 'Cooper', 'Turquoise'),
(40, 'Porsche', '911', 'Zalm'),
(41, 'Seat', 'Leon', 'Lime'),
(42, 'Smart', 'Fortwo', 'Goud'),
(43, 'Tata', 'Nano', 'Blauw'),
(44, 'Vauxhall', 'Corsa', 'Rood'),
(45, 'Wuling', 'Sunshine', 'Zwart'),
(46, 'Yugo', 'Skala', 'Grijs'),
(47, 'Zastava', 'Yugo', 'Geel'),
(48, 'Lada', 'Priora', 'Oranje'),
(49, 'Geely', 'Emgrand', 'Groen'),
(50, 'Proton', 'Persona', 'Oranje');

-- --------------------------------------------------------

--
-- Table structure for table `cities`
--

CREATE TABLE `cities` (
  `city_id` int(11) NOT NULL,
  `city_name` varchar(50) NOT NULL,
  `city_population` int(11) DEFAULT NULL,
  `city_province` varchar(50) NOT NULL,
  `city_mayor` varchar(50) DEFAULT NULL,
  `city_foundation_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cities`
--

INSERT INTO `cities` (`city_id`, `city_name`, `city_population`, `city_province`, `city_mayor`, `city_foundation_date`) VALUES
(1, 'Amsterdam', 821752, 'Noord-Holland', 'Femke Halsema', '1300-01-01'),
(2, 'Rotterdam', 650942, 'Zuid-Holland', 'Aboutaleb Ahmed', '1340-01-01'),
(3, 'Utrecht', 357179, 'Utrecht', 'Sharon Dijksma', '1122-01-01'),
(4, 'Eindhoven', 234235, 'Noord-Brabant', 'John Jorritsma', '1232-01-01'),
(5, 'Arnhem', 162525, 'Gelderland', 'Ahmed Marcouch', '1233-01-01'),
(6, 'Maastricht', 122378, 'Limburg', 'Annemarie Penn-te Strake', '1202-01-01'),
(7, 'Goes', 37765, 'Zeeland', 'Margo Mulder', '1234-01-01'),
(8, 'Almere', 214405, 'Flevoland', 'Franc Weerwind', '1976-01-01'),
(9, 'Zwolle', 127497, 'Overijssel', 'Peter Snijders', '1201-01-01'),
(10, 'Groningen', 232277, 'Groningen', 'Koen Schuiling', '0100-01-01'),
(11, 'The Hague', 548854, 'Zuid-Holland', 'Jan van Zanen', '1345-01-01'),
(12, 'Nijmegen', 177670, 'Gelderland', 'Hubert Bruls', '1347-01-01'),
(13, 'Breda', 183873, 'Noord-Brabant', 'Paul Depla', '1212-01-01'),
(14, 'Haarlem', 161265, 'Noord-Holland', 'Jos Wienen', '1245-01-01'),
(15, 'Leiden', 124014, 'Zuid-Holland', 'Henri Lenferink', '1250-01-01'),
(16, 'Enschede', 160552, 'Overijssel', 'Onno van Veldhuizen', '1305-01-01'),
(17, 'Middelburg', 40106, 'Zeeland', 'Harald Bergmann', '1100-01-01'),
(18, 'Leeuwarden', 124210, 'Friesland', 'Sybrand Buma', '1402-01-01'),
(19, 'Amersfoort', 156286, 'Utrecht', 'Lucas Bolsius', '1200-01-01'),
(20, 'Bergen op Zoom', 67285, 'Noord-Brabant', 'Frank Petter', '1292-01-01'),
(21, 'Tilburg', 217259, 'Noord-Brabant', 'Theo Weterings', '1211-01-01'),
(22, 'Zaanstad', 155382, 'Noord-Holland', 'Jan Hamming', '1280-01-01'),
(23, 'Deventer', 100113, 'Overijssel', 'Ron König', '1195-01-01'),
(24, 'Alkmaar', 108363, 'Noord-Holland', 'Emile Roemer', '1023-01-01'),
(25, 'Helmond', 91584, 'Noord-Brabant', 'Elly Blanksma', '1247-01-01'),
(26, 'Delft', 103163, 'Zuid-Holland', 'Marja van Bijsterveldt', '1140-01-01'),
(27, 'Vlissingen', 44823, 'Zeeland', 'Bas van den Tillaar', '1189-01-01'),
(28, 'Heerlen', 87473, 'Limburg', 'Roel Wever', '1252-01-01'),
(29, 'Hoorn', 73262, 'Noord-Holland', 'Jan Nieuwenburg', '1316-01-01'),
(30, 'Gouda', 70932, 'Zuid-Holland', 'Pieter Verhoeve', '1143-01-01'),
(31, 'Dordrecht', 118599, 'Zuid-Holland', 'Wouter Kolff', '1215-01-01'),
(32, 'Amstelveen', 91876, 'Noord-Holland', 'Tjapko Poppens', '1195-01-01'),
(33, 'Zoetermeer', 125095, 'Zuid-Holland', 'Michel Bezuijen', '1274-01-01'),
(34, 'Roosendaal', 77669, 'Noord-Brabant', 'Han van Midden', '1299-01-01'),
(35, 'Purmerend', 81536, 'Noord-Holland', 'Don Bijl', '1326-01-01'),
(36, 'Oss', 93299, 'Noord-Brabant', 'Wobine Buijs-Glaudemans', '1075-01-01'),
(37, 'Delfshaven', 78522, 'Zuid-Holland', 'Aboutaleb Ahmed', '1340-01-01'),
(38, 'Sittard', 93404, 'Limburg', 'Bas van den Tillaar', '1243-01-01'),
(39, 'Harderwijk', 50142, 'Gelderland', 'Cor Lamers', '1230-01-01'),
(40, 'Zwijndrecht', 44921, 'Zuid-Holland', 'Dominic Schrijer', '1202-01-01'),
(41, 'Assen', 67810, 'Drenthe', 'Marco Out', '1258-01-01'),
(42, 'Heerhugowaard', 57461, 'Noord-Holland', 'Bert Blase', '1423-01-01'),
(43, 'Nieuwegein', 63043, 'Utrecht', 'Frans Backhuijs', '1939-01-01'),
(44, 'Woerden', 52578, 'Utrecht', 'Victor Molkenboer', '1300-01-01'),
(45, 'Roermond', 58536, 'Limburg', 'Rianne Donders-de Leest', '1232-01-01'),
(46, 'Doetinchem', 57507, 'Gelderland', 'Mark Boumans', '1193-01-01'),
(47, 'Barneveld', 59056, 'Gelderland', 'Jan Luteijn', '1234-01-01'),
(48, 'Culemborg', 28033, 'Gelderland', 'Gerdo van Grootheest', '1290-01-01'),
(49, 'Tiel', 42038, 'Gelderland', 'Hans Beenakker', '1200-01-01'),
(50, 'Drachten', 45516, 'Friesland', 'Jan Rijpstra', '1205-01-01'),
(51, 'Harderwijk', 50142, 'Gelderland', 'Cor Lamers', '1230-01-01'),
(52, 'Zwijndrecht', 44921, 'Zuid-Holland', 'Dominic Schrijer', '1202-01-01'),
(53, 'Venlo', 100143, 'Limburg', 'Antoin Scholten', '1343-01-01'),
(54, 'Rijswijk', 53176, 'Zuid-Holland', 'Michel Bezuijen', '1247-01-01'),
(55, 'Katwijk', 65331, 'Zuid-Holland', 'Cornelis Visser', '1202-01-01'),
(56, 'Gorinchem', 37480, 'Zuid-Holland', 'Reinie Melissant-Briene', '1209-01-01'),
(57, 'Emmeloord', 26238, 'Flevoland', 'Jan Westmaas', '1943-01-01'),
(58, 'Barendrecht', 48016, 'Zuid-Holland', 'Jan van Belzen', '1135-01-01'),
(59, 'Pijnacker', 23079, 'Zuid-Holland', 'Francisca Ravestein', '1338-01-01'),
(60, 'Lelystad', 76012, 'Flevoland', 'Ina Adema', '1967-01-01'),
(61, 'Veendam', 27609, 'Groningen', 'Sipke Swierstra', '1200-01-01'),
(62, 'Maarssen', 39019, 'Utrecht', 'Apoloniah van Veen-De Rijke', '1449-01-01'),
(63, 'Geldrop', 29853, 'Noord-Brabant', 'Berry Link', '1421-01-01'),
(64, 'Waalwijk', 47737, 'Noord-Brabant', 'Nol Kleijngeld', '1255-01-01'),
(65, 'Heemstede', 27142, 'Noord-Holland', 'Astrid Nienhuis', '1286-01-01'),
(66, 'Sliedrecht', 25542, 'Zuid-Holland', 'Bram van Hemmen', '1421-01-01'),
(67, 'Weesp', 19825, 'Noord-Holland', 'Bas Jan van Bochove', '1355-01-01'),
(68, 'Oisterwijk', 25914, 'Noord-Brabant', 'Hans Janssen', '1211-01-01'),
(69, 'Losser', 22658, 'Overijssel', 'Cia Kroon', '1016-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `provinces`
--

CREATE TABLE `provinces` (
  `province_id` int(11) NOT NULL,
  `province_name` varchar(50) NOT NULL,
  `province_capital` varchar(50) NOT NULL,
  `province_population` int(11) DEFAULT NULL,
  `province_area_km2` decimal(10,2) DEFAULT NULL,
  `province_foundation_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `provinces`
--

INSERT INTO `provinces` (`province_id`, `province_name`, `province_capital`, `province_population`, `province_area_km2`, `province_foundation_date`) VALUES
(1, 'Noord-Holland', 'Haarlem', 2853359, 4222.20, '1840-01-01'),
(2, 'Zuid-Holland', 'Den Haag', 3673893, 3614.28, '1840-01-01'),
(3, 'Utrecht', 'Utrecht', 1382150, 1371.84, '1840-01-01'),
(4, 'Noord-Brabant', 'Den Bosch', 2544159, 4964.69, '1840-01-01'),
(5, 'Gelderland', 'Arnhem', 2078057, 5136.94, '1840-01-01'),
(6, 'Limburg', 'Maastricht', 1116735, 2155.61, '1839-04-01'),
(7, 'Zeeland', 'Middelburg', 383488, 2935.36, '1839-04-01'),
(8, 'Flevoland', 'Lelystad', 422506, 1426.87, '1986-01-01'),
(9, 'Overijssel', 'Zwolle', 1156431, 3314.85, '1840-01-01'),
(10, 'Groningen', 'Groningen', 587161, 2959.18, '1840-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `sessions`
--

CREATE TABLE `sessions` (
  `session_id` int(11) NOT NULL,
  `session_user_id` int(11) NOT NULL,
  `session_key` varchar(50) NOT NULL,
  `session_start` date NOT NULL,
  `session_end` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sessions`
--

INSERT INTO `sessions` (`session_id`, `session_user_id`, `session_key`, `session_start`, `session_end`) VALUES
(8, 1, 'e74cd6b197debb9467e52aededce013b', '2025-05-27', '2025-06-27'),
(9, 1, 'a9bec9322a1929301c1320e720274515', '2025-05-27', '2025-06-27'),
(10, 1, 'cc0f0c5f650ee7cf9b5f1c86b8f63733', '2025-05-27', '2025-06-27'),
(11, 1, '2e96e392b5b7948a2115c340dbbd7adf', '2025-05-27', '2025-06-27'),
(12, 7, 'c6a6fc24c82ce6a1c118d07baf81a703', '2025-05-27', '2025-06-27'),
(13, 7, 'ec28374f9cb1adec8439bdb85383abdd', '2025-05-27', '2025-06-27'),
(14, 7, 'ac4327111d6fe46e3353358c60853b03', '2025-05-27', '2025-06-27'),
(15, 10, 'ab5a347eae0b31086027cc93bf4daa83', '2025-05-27', '2025-06-27'),
(16, 10, '59415e5ae155ef4aa94f4caa60eea3cc', '2025-05-27', '2025-06-27'),
(17, 1, '4efa390434434101a4cd438dc876c268', '2025-05-27', '2025-06-27'),
(18, 4, '36a85b554db3906cc3a00452b17c2d67', '2025-05-27', '2025-06-27'),
(19, 4, '3cca04b558c1defefc38171bbe73abcc', '2025-05-27', '2025-06-27'),
(20, 4, 'fcc206e1dbfec6f7ac5f1f0545706ba3', '2025-05-27', '2025-06-27'),
(21, 4, '29f1e75b52a6922bb6539ade04d10cad', '2025-05-27', '2025-06-27'),
(22, 4, '64f81f0d52b2373653b29b386cfbd44b', '2025-05-27', '2025-06-27'),
(23, 11, '7180b0d607e6b46a46c9adf0fa8b0976', '2025-05-28', '2025-06-28'),
(24, 11, '2cd92de4853772165d4083120b74390a', '2025-05-28', '2025-06-28'),
(25, 11, 'aa82274d9dd20d5d36584198dc7cf5d2', '2025-05-28', '2025-06-28'),
(26, 11, '7600d641a01bddc63ab498cd7c2a6aec', '2025-05-28', '2025-06-28'),
(27, 11, '41ccae61c3adf3f7672e07afe4f2c3d2', '2025-05-28', '2025-06-28'),
(28, 11, 'f8de73ef8c17bd2bcd55ae3e9f7dce71', '2025-05-28', '2025-06-28'),
(29, 11, '2f8b9f6af524ad40cee4fb9510f2d2df', '2025-05-28', '2025-06-28'),
(30, 11, '9f28ba889325d2aa4c303a42b303ab49', '2025-05-28', '2025-06-28'),
(31, 11, '38fa2166880101212013242979f25da1', '2025-05-28', '2025-06-28'),
(32, 11, 'f7a777db4e235c82e008ea0c7f9d849e', '2025-05-28', '2025-06-28'),
(33, 11, 'aa00780ef7fb832d20d4a657a8718fc9', '2025-05-28', '2025-06-28'),
(34, 11, 'f6e0872b38ecb12761c0eb875efa0d91', '2025-05-28', '2025-06-28'),
(35, 11, '21703d2afd82d0db9c0bb807dcab27e4', '2025-05-28', '2025-06-28'),
(36, 11, 'ccc5349bb21d47b79a85c366a559eed4', '2025-05-28', '2025-06-28'),
(37, 11, 'c1068dda29380a298d5b1859678b3852', '2025-05-28', '2025-06-28'),
(38, 11, '2f98935281d912bfebfd4c91e818ba67', '2025-05-28', '2025-06-28'),
(39, 11, '521bcaccc5ef3367df2b91c50ba290ae', '2025-05-28', '2025-06-28'),
(40, 11, '3b252fc6cd4a14652d1deef4942e15a6', '2025-05-28', '2025-06-28'),
(41, 11, '459d0f610f83b0e7c064a92e33211192', '2025-05-28', '2025-06-28'),
(42, 11, '483d4fe3bcb04cf624c28495b8cf6dfc', '2025-05-28', '2025-06-28'),
(43, 11, 'f7cd60627fd8fa5da9a7660d2be384e8', '2025-05-28', '2025-06-28'),
(44, 11, '6f9442d6dd4f1ea26f7a07befd27d585', '2025-05-28', '2025-06-28'),
(45, 11, '2d75476c4b96ac73ea15a3457b38996a', '2025-05-28', '2025-06-28'),
(46, 11, 'dc61e08f4e17943648830bd6338a443c', '2025-05-28', '2025-06-28'),
(47, 11, 'f2e3114b2c7d1a7d6a254bcd90f71901', '2025-05-28', '2025-06-28'),
(48, 11, '47e688c307fa079f21002e2b1aca88cb', '2025-05-28', '2025-06-28'),
(49, 11, '559242665bc531d5b44985b6e6a83374', '2025-05-28', '2025-06-28'),
(50, 11, '3d7416ce5ac21fc2ab4c2d203a06cf9c', '2025-05-31', '2025-07-01'),
(51, 11, 'f96ea8635273bc941207a911c6c3a298', '2025-05-31', '2025-07-01'),
(52, 11, '01f64ce1ff166435d820d306b846b33d', '2025-05-31', '2025-07-01'),
(53, 11, '2adbcb084d3c3569421bebc48a50371f', '2025-05-31', '2025-07-01'),
(54, 11, '0b53eb97888869135bd656f6a4f61f57', '2025-05-31', '2025-07-01');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_firstname` varchar(20) NOT NULL,
  `user_lastname` varchar(30) NOT NULL,
  `user_email` varchar(25) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `user_admin` int(11) NOT NULL,
  `user_role` varchar(20) DEFAULT 'standaard'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_firstname`, `user_lastname`, `user_email`, `user_username`, `user_password`, `user_admin`, `user_role`) VALUES
(1, 'Eva', 'Johnson', 'eva.johnson@email.com', 'eva_j', 'Eva@123', 0, 'standaard'),
(2, 'Liam', 'Miller', 'liam.miller@email.com', 'liam_m', 'Liam#456', 0, 'standaard'),
(3, 'Sophia', 'Smith', 'sophia.smith@email.com', 'sophia_s', 'Sophia@789', 0, 'standaard'),
(4, 'Noah', 'Brown', 'noah.brown@email.com', 'noah_b', 'Noah_123', 0, 'standaard'),
(5, 'Ava', 'Davis', 'ava.davis@email.com', 'ava_d', 'Ava#456', 0, 'standaard'),
(6, 'Jackson', 'Martinez', 'jackson.martinez@email.co', 'jackson_m', 'Jackson@789', 0, 'standaard'),
(7, 'Olivia', 'Garcia', 'olivia.g@email.com', 'olivia_g', 'Olivia_123', 0, 'standaard'),
(8, 'Lucas', 'Williams', 'lucas.w@email.com', 'lucas_w', 'Lucas#456', 0, 'standaard'),
(9, 'Isabella', 'Jones', 'isabella.j@email.com', 'isabella_j', 'Isabella@789', 0, 'standaard'),
(10, 'Mia', 'Rodriguez', 'mia.rodriguez@email.com', 'mia_r', 'Mia_123', 0, 'standaard'),
(11, 'Admin', 'Sargeant', 'sar.sargeant@email.com', 'Admin', 'Admin', 1, 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `blogs`
--
ALTER TABLE `blogs`
  ADD PRIMARY KEY (`blog_id`);

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`car_id`) USING BTREE;

--
-- Indexes for table `cities`
--
ALTER TABLE `cities`
  ADD PRIMARY KEY (`city_id`);

--
-- Indexes for table `provinces`
--
ALTER TABLE `provinces`
  ADD PRIMARY KEY (`province_id`);

--
-- Indexes for table `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`session_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `blogs`
--
ALTER TABLE `blogs`
  MODIFY `blog_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `car_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `cities`
--
ALTER TABLE `cities`
  MODIFY `city_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

--
-- AUTO_INCREMENT for table `provinces`
--
ALTER TABLE `provinces`
  MODIFY `province_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `sessions`
--
ALTER TABLE `sessions`
  MODIFY `session_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
