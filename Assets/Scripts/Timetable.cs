using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Constants;

public class Timetable : MonoBehaviour
{
    public GameObject saturdayTimeTable;
    public GameObject sundayTimeTable;
    public Button saturdayBtn;
    public Button sundayBtn;
    public Sprite orangeBottomBorder;
    public Sprite transparentBottomBorder;
    public List<LineUp> LineUps { get; set; }

    private void Start()
    {
        LineUps = GenerateArtists();
        saturdayTimeTable.GetComponent<DayPanel>().InstantiatePanel(LineUps[0]);
        sundayTimeTable.GetComponent<DayPanel>().InstantiatePanel(LineUps[1]);
        DateTime now = DateTime.Now;
        if (now.Date == Convert.ToDateTime("05/17/2020").Date)
        {
            DisplayLineUpSun();
        }
        else
        {
            DisplayLineUpSat();
        }
    }

    private List<LineUp> GenerateArtists()
    {
        LineUp satLineUp = new LineUp("Saturday");

        /*satLineUp.AddArtist(new Artist("The Vectors", new TimeSlot(14, 00), 40,
            "The Vectors est un groupe de rock formé en 2015 dans la lignée de groupes anglais tels qu’Arctic Monkeys ou Muse avec des inspirations de groupes américains musclés comme Rage Against the Machine ou encore Queens of the Stone Age.",
            Stage.STAGE_01, "https://un-mute.be/artistes/12-the-vectors"));
        satLineUp.AddArtist(new Artist("AB", new TimeSlot(15, 00), 40,
            "Artiste liégeois de style électro-pop.\n" +
            "Musicien autodidacte.\n" +
            "Au four et au moulin, il écrit, interprète et compose des chansons en langue anglais, mais également en espagnol, et, plus occasionnellement en français.",
            Stage.STAGE_01, "https://un-mute.be/artistes/106-ab"));
        satLineUp.AddArtist(new Artist("Yakhchal", new TimeSlot(16, 00), 50,
            "Un trio post rock composé par basse, guitare et batterie. Yakhchal crée des chansons instrumentales faites d'atmosphères et de mélodies mélancoliques, de boucles psychédéliques répétitives et des effets qui évoluent en riffs explosifs.",
            Stage.STAGE_01, "https://un-mute.be/artistes/103-yakchal"));
        satLineUp.AddArtist(new Artist("Dark Horse", new TimeSlot(17, 00), 50,
            "Au début- hop- au milieu- zou- et puis vlan à la fin",
            Stage.STAGE_01, "https://un-mute.be/artistes/107-dark-horse"));
        satLineUp.AddArtist(new Artist("Funk This Ship", new TimeSlot(18, 00), 75,
            "Quatuor de storytelling gravy-funk-rock alternatif.",
            Stage.STAGE_01, "https://un-mute.be/artistes/95-funk-this-ship"));
        satLineUp.AddArtist(new Artist("Sweet Billie", new TimeSlot(19, 30), 50,
            "Soul Rock Alternative for Music Lovers <b><color=#E79A41>#Soulicious</color></b>",
            Stage.STAGE_01, "https://un-mute.be/artistes/108-sweet-billie"));*/
        //--------------------------------------------------------------------
        satLineUp.AddArtist(new Artist("Jimmy Marguerite", new TimeSlot(14, 30), 50,
            "Jimmy Marguerite, jeune artiste prometteur, allie la poésie avec le rap pour un style très planant et très lyrique.\n" +
            "Témoin d'une génération en plein changement dont il est acteur, le jeune de 18 ans parle de la vie et des sentiments qui se dévoilent au f...",
            Stage.STAGE_01, "https://un-mute.be/artistes/90-jimmy-marguerite"));
        satLineUp.AddArtist(new Artist("JIZZ'N JAZZ", new TimeSlot(15, 30), 50,
            "JIZZ'N JAZZ est un groupe de rap épic rigolo. Un subtile mélange de Brel, Vald et Maitre Gims. Avec ses textes percutants, Jizz'n jazz est une des étoiles montantes de la scène rap Belge avec Caballero & JeanJass, L'or du Commun et autres Roméo Elvis.",
            Stage.STAGE_01, "https://un-mute.be/artistes/86-jizzn-jazz"));
        satLineUp.AddArtist(new Artist("Labal Collectif", new TimeSlot(16, 30), 50,
            "Un bon ragga-rap présentant des compositions originales avec des musicos passant du reggae au rock.\n" +
            "Ils n'ont qu'une envie, vous faire découvrir leur univers maniaco - expressif tout en vous faisant bouger sur leurs rythmes effrénés.",
            Stage.STAGE_01, "https://un-mute.be/artistes/94-labal-collectif"));
        satLineUp.AddArtist(new Artist("Mac Lister", new TimeSlot(17, 30), 50,
            "Inspiré par la culture hip hop afro américaine, Mac lister s'est construit un registre musical éclectique touchant à plusieurs styles musicaux ( rnb, afro pop, jazz, soul, rock, dance hall et raggaeton)",
            Stage.STAGE_01, "https://un-mute.be/artistes/105-mac-lister"));
        satLineUp.AddArtist(new Artist("ArtSchool", new TimeSlot(18, 30), 50,
            "4 Jeunes rappeurs pleins d'ambitions prêt à en découdre.",
            Stage.STAGE_01, "https://un-mute.be/artistes/104-artschool"));
        //--------------------------------------------------------------------
        satLineUp.AddArtist(new Artist("Abey Blue", new TimeSlot(21, 00), 50,
            "Abey Blue, duo pop bruxellois.",
            Stage.STAGE_02, "https://un-mute.be/artistes/87-abey-blue"));
        satLineUp.AddArtist(new Artist("Cabéru", new TimeSlot(20, 00), 50,
            "Véritable vent de fraîcheur sur la pop francophone, Cabéru dévoile une musique puissante aux textes habiles et engagés qui préfigurent un avenir à cet artiste ACI.\n" +
            "Un texte, un thème, une musique et une voix… Un recette simple mais unique à chaque fois.",
            Stage.STAGE_02, "https://un-mute.be/artistes/101-caberu"));
        satLineUp.AddArtist(new Artist("TUK TUK Thailand", new TimeSlot(19, 00), 50,
            "Electro psychédélique jouée en live et conduite par une voix ensorcelante",
            Stage.STAGE_02, "https://un-mute.be/artistes/97-tuk-tuk-thailand"));
        satLineUp.AddArtist(new Artist("B-Astre", new TimeSlot(18, 00), 50,
            "Une auteur-compositrice de pop ensorcelée, elle incarne de son corps et de sa voix son vécu.\n" +
            "Elle vous emmène en voyage vers du rêve, les pieds bien ancrés sur la terre.\n" +
            "Artiste bruxelloise inclassable teintée de surréalisme.",
            Stage.STAGE_02, "https://un-mute.be/artistes/74-b-astre"));
        satLineUp.AddArtist(new Artist("Marylène Corro", new TimeSlot(17, 00), 50,
            "Marylène Corro, auteur compositeur interprète belgo-chilienne, basée à Bruxelles propose ses compositions; des textes en anglais, français et espagnol, tantôt engagés, tantôt légers et une musique influencée par les rythmes du monde, le jazz et la soul.",
            Stage.STAGE_02, "https://un-mute.be/artistes/89-marylene-corro"));
        satLineUp.AddArtist(new Artist("Liquid Zenith", new TimeSlot(16, 00), 50,
            "Zouk Canin",
            Stage.STAGE_02, "https://un-mute.be/artistes/92-liquid-zenith"));
        //--------------------------------------------------------------------
        LineUp sunLineUp = new LineUp("Sunday");
        //--------------------------------------------------------------------
        /*sunLineUp.AddArtist(new Artist("breakingmind", new TimeSlot(15, 00), 50,
            "Alternative Metal from Brussels",
            Stage.STAGE_01, "https://un-mute.be/artistes/100-breakingmind"));
        sunLineUp.AddArtist(new Artist("Elysiane", new TimeSlot(16, 00), 50,
            "Elysiane, c'est la part de bonheur survivant aux enfers. C'est le contraste qui prend racine pour jaillir de terre et chercher la lumière, au-delà de toute dualité.\n\n" +
            "Elysiane, c'est nous, c'est vous.C'est surtout tous ceux qui essayent la direction opp...",
            Stage.STAGE_01, "https://un-mute.be/artistes/63-elysiane"));
        sunLineUp.AddArtist(new Artist("Warlus", new TimeSlot(17, 00), 50,
            "Warlus, est un groupe pop rock évoluant dans la langue française, se caractérisant par des textes engagés, des arrangements fouillés, accompagné par un son massif, épais, énorme et de solos épiques.",
            Stage.STAGE_01, "https://un-mute.be/artistes/96-warlus"));
        sunLineUp.AddArtist(new Artist("Minor/Minor", new TimeSlot(18, 00), 50,
            "Minor/Minor c'est 4 esprits en un seul et une volonté commune d'écrire des chansons mélodieuses et énergiques. La dualité des styles caractérise énormément leur musique!",
            Stage.STAGE_01, "https://un-mute.be/artistes/44-minor-minor"));
        sunLineUp.AddArtist(new Artist("Meander", new TimeSlot(19, 00), 50,
            "Post-metal band from Brussels",
            Stage.STAGE_01, "https://un-mute.be/artistes/61-meander"));*/
        //--------------------------------------------------------------------
        sunLineUp.AddArtist(new Artist("Los Pepes", new TimeSlot(21, 00), 50,
            "Groupe de chanson française aux sonorités variées sans pour autant faire de variété! Un cocktail sans gêne mais plein de tonique! Artistes engageant et engagés!",
            Stage.STAGE_01, "https://un-mute.be/artistes/98-los-pepes"));
        sunLineUp.AddArtist(new Artist("Marilyn Bras", new TimeSlot(20, 00), 50,
            "Une chanson française onirique, une voix douce et grave, un univers dans des bulles volantes pour nous poser à voir, réfléchir, ressentir et laisser guider nos émotions. Un voyage inaltérable qui nous projette hors du temps. Une musique comme guide.",
            Stage.STAGE_01, "https://un-mute.be/artistes/88-marilyn-bras"));
        sunLineUp.AddArtist(new Artist("Olivier Terwagne", new TimeSlot(19, 00), 50,
            "French pop mélancolique du terroir chimacien, entre piano, loop et cuivres déjantés, Olivier Terwagne aime la poésie, les atmosphères de vieux troquets et la musique cinématographique",
            Stage.STAGE_01, "https://un-mute.be/artistes/99-olivier-terwagne"));
        sunLineUp.AddArtist(new Artist("Angelo Daves", new TimeSlot(18, 00), 50,
            "Angelo Daves: Auteur et interprète.\n" +
            "Depuis ses débuts, il y a plus de 10 ans, il a toujours aimé avant tout prendre du plaisir à créer et à partager ses œuvres.",
            Stage.STAGE_01, "https://un-mute.be/artistes/85-angelo-daves"));
        sunLineUp.AddArtist(new Artist("Vali Mosa", new TimeSlot(17, 00), 50,
            "Auteure, compositrice et interprète, Vali Mosa présente une chanson française originale, entêtante et chaleureuse, un répertoire percutant teinté d’humanité, d’ironie et de tendresse.",
            Stage.STAGE_01, "https://un-mute.be/artistes/91-vali-mosa"));
        sunLineUp.AddArtist(new Artist("Biche de Ville", new TimeSlot(16, 00), 50,
            "Poétesse pop, dit tout haut ce qu’on pense tout bas, se met à nu pour ceux qui n’osent pas, expose sans filtre sa vision du monde, balance ses révoltes avec le smile.\n" +
            "Authentiquement excentrique, elle emmène ses poèmes sur scène à la sauce electro.",
            Stage.STAGE_01, "https://un-mute.be/artistes/93-biche-de-ville"));
        //--------------------------------------------------------------------
        List<LineUp> festivalLineUp = new List<LineUp>
        {
            satLineUp,
            sunLineUp
        };
        return festivalLineUp;
    }

    public void DisplayLineUpSat()
    {
        saturdayTimeTable.SetActive(true);
        saturdayBtn.GetComponent<Image>().sprite = orangeBottomBorder;
        saturdayBtn.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        sundayTimeTable.SetActive(false);
        sundayBtn.GetComponent<Image>().sprite = transparentBottomBorder;
        sundayBtn.GetComponentInChildren<Text>().fontStyle = FontStyle.Normal;
    }

    public void DisplayLineUpSun()
    {
        saturdayTimeTable.SetActive(false);
        saturdayBtn.GetComponent<Image>().sprite = transparentBottomBorder;
        saturdayBtn.GetComponentInChildren<Text>().fontStyle = FontStyle.Normal;
        sundayTimeTable.SetActive(true);
        sundayBtn.GetComponent<Image>().sprite = orangeBottomBorder;
        sundayBtn.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
    }

}
