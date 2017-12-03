using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class SampleDataGenerator
    {
        static Random random = new Random();
        private static string[] firstNames = new[] {
            "Jiří", "Jan", "Petr", "Josef", "Pavel", "Martin", "Jaroslav", "Tomáš", "Miroslav", "Zdeněk", "František", "Václav", "Michal", "Milan", "Karel", "Jakub", "Lukáš", "David", "Vladimír", "Ladislav", "Ondřej", "Roman", "Stanislav", "Marek", "Radek", "Daniel", "Antonín", "Vojtěch", "Filip", "Adam", "Miloslav", "Matěj", "Aleš", "Jaromír", "Libor", "Dominik", "Patrik", "Vlastimil", "Jindřich", "Miloš", "Oldřich", "Lubomír", "Rudolf", "Ivan", "Luboš", "Robert", "Štěpán", "Radim", "Richard", "Bohumil", "Matyáš", "Vít", "Ivo", "Rostislav", "Luděk", "Dušan", "Kamil", "Šimon", "Vladislav", "Zbyněk", "Bohuslav", "Michal", "Alois", "Viktor", "Štefan", "Vítězslav", "René", "Jozef", "Ján", "Kryštof", "Eduard", "Marcel", "Emil", "Dalibor", "Ludvík", "Radomír", "Tadeáš", "Otakar", "Vilém", "Samuel", "Bedřich", "Alexandr", "Denis", "Vratislav", "Leoš", "Radovan", "Břetislav", "Marian", "Přemysl", "Robin", "Erik", "Petr", "Volodymyr", "Arnošt", "Bohumír", "Otto", "Alexander", "Hynek", "Svatopluk", "Bronislav", "Mykola", "Igor", "Yuriy", "Adolf", "Lumír", "Evžen", "Juraj", "Vlastislav", "Matouš", "Oleksandr", "Marián", "Pavol", "Mikuláš", "Radoslav", "Květoslav", "Mojmír", "Zdenek", "Andrej", "Vasyl", "Mykhaylo"
        };
        private static string[] lastNames = new[] {
            "Novák", "Svoboda", "Novotný", "Dvořák", "Černý", "Procházka", "Kučera", "Veselý", "Horák", "Němec", "Pokorný", "Marek", "Pospíšil", "Hájek", "Jelínek", "Král", "Růžička", "Beneš", "Fiala", "Sedláček", "Doležal", "Zeman", "Nguyen", "Kolář", "Krejčí", "Navrátil", "Čermák", "Urban", "Vaněk", "Blažek", "Kříž", "Kratochvíl", "Kovář", "Kopecký", "Bartoš", "Vlček", "Musil", "Šimek", "Polák", "Konečný", "Malý", "Čech", "Kadlec", "Štěpánek", "Staněk", "Holub", "Dostál", "Soukup", "Šťastný", "Mareš", "Sýkora", "Moravec", "Tichý", "Valenta", "Vávra", "Matoušek", "Bláha", "Říha", "Ševčík", "Bureš", "Hruška", "Mašek", "Pavlík", "Dušek", "Hrubý", "Havlíček", "Janda", "Mach", "Müller", "Liška"
        };
        private static string[] jobs = new[]
        {
            "Account manager", "Administrativní pracovník, referent", "Administrator internetového obchodu", "Advokát", "Advokátní koncipient", "Android programátor", "Animátor volného času", "Anketář", "Aranžér, dekoratér", "Architekt", "Archivář, správce rejstříku", "Asistent", "Asistent (zdravotnictví)", "Asistent auditora", "Asistent daňového poradce", "Asistent učitele", "Au-pair", "Auditor", "Autoelektrikář", "Autoklempíř", "Automechanik", "Balič", "Barman", "Brand manager", "Brusič", "Business Intelligence Specialist", "Bytový architekt", "Celní deklarant", "Compliance specialista", "Contract Manager", "Controller", "Copywriter", "Country manager/director", "CRM specialista", "Cukrář", "Chemický inženýr", "Chemický laborant", "Chemik", "Chovatel, ošetřovatel zvířat", "Číšník", "Číšník - pokojová služba", "Daňový poradce", "Databázový administrátor", "Databázový analytik", "Dealer/Trader", "Dělník", "Designér", "Designér telekomunikačních sítí", "Dispečer", "Disponent", "Doplňovač zboží/merchandiser", "Dopravní inženýr", "Dřevařský technik", "Ekolog", "Ekonom", "Ekonomický/finanční ředitel", "Elektrikář", "Elektromechanik", "Elektromontér", "Elektronik", "Elektrotechnický inženýr", "Elektrotechnik", "Energetik", "Environmentalista", "Event manager", "Expedient", "F&B manažér", "Facility manager", "Fakturant", "Farmaceut", "Farmaceutický laborant", "Finanční agent", "Finanční analytik", "Finanční manažer", "Finanční poradce", "Fotograf", "Frézař", "Grafický designér", "Grafik", "Helpdesk operátor", "Hlavní sestra", "Hlavní účetní", "Hospodyně", "Hosteska", "Hotelový nosič zavazadel", "Houseman", "HR asistent", "HR Business Partner", "HR generalist", "HR Koordinátor", "Hygienik", "Hypoteční specialista", "ICT specialista", "Inspektor", "Instalatér", "Inženýr kvality", "iOS programátor", "IT analytik", "IT architekt", "IT konzultant", "IT manager", "IT projektový manažer", "IT tester", "Jeřábník", "Kadeřník", "Key account manager", "Klempíř, pokrývač", "Klientský pracovník", "Konstruktér", "Kontrolor kvality", "Konzultant", "Koordinátor", "Korektor", "Kosmetička", "Kouč", "Krejčí", "Kuchař", "Kurýr", "Květinář", "Laborant", "Lakýrník", "Lékař", "Lékařský poradce (Medical advisor)", "Lektor", "Lektor, školitel", "Letecký mechanik", "Likvidátor škod", "Logistik", "Makléř", "Malíř, natěrač", "Manažer bezpečnostní služby", "Manažer call centra", "Manažér hotelu", "Manažer kvality", "Manažer logistiky", "Manažer reklamačního oddělení", "Manažer vozového parku", "Marketingový manažer", "Marketingový pracovník", "Marketingový ředitel", "Marketingový specialista", "Medicínský/farmaceutický reprezentant", "Mechanik chladírenských zařízení", "Metrolog", "Mistr ve výrobě", "Montážník/montér", "Multimedia Specialist", "Mzdový účetní", "Nábytkář", "Nákupčí", "Nástrojař", "Normovač práce", "Nutriční terapeut", "Obchodní analytik", "Obchodní manažer", "Obchodní ředitel", "Obchodní referent", "Obchodní zástupce", "Obsluha čerpací stanice", "Obsluha energetických zařízení", "Odborný prodejce", "Odborný referent", "Oděvní návrhář, konstruktér střihů", "Odhadce nemovitostí", "Office manager", "Operátor stavebních strojů", "Operátor strojů a zařízení", "Opravář", "Osobní bankéř", "Palič", "Palubní průvodčí/steward/letuška", "Paralegal - student práv", "Pečovatel, osobní asistent", "Pekař", "Personalista", "Personální konzultant", "Personální manažer", "Personální ředitel", "Pilot", "Pizzař", "Plánovač kvality", "Plánovač výroby", "Podlahář, dlaždič", "Pojistný matematik", "Pojišťovací poradce", "Pokladník", "Pokojská", "Pomocná síla do kuchyně", "Pomocný kuchař", "Pomocný pracovník", "Porodní asistentka", "Potravinářský technolog", "Potrubář", "Požární technik", "PPC specialista", "PR manažer", "Pracovník bezpečnostní služby", "Pracovník myčky vozidel", "Pracovník platebního styku", "Pracovník pneuservisu", "Pracovník reklamačního oddělení", "Pracovník rychlého občerstvení", "Pracovník systému platebních karet", "Právník", "Předák", "Překladatel", "Přepážkový pracovník", "Přijímací technik", "Přípravář staveb", "Privátní bankéř", "Procesní inženýr", "Procesní manažer", "Prodavač", "Prodejce letenek/zájezdů", "Produktový manažer", "Produktový manažer - specialista", "Produktový manažer v IT", "Programátor", "Programátor .NET", "Programátor ABAP", "Programátor C", "Programátor C#", "Programátor C++", "Programátor CNC", "Programátor Java", "Programátor Javascript", "Programátor Objective-C", "Programátor Oracle", "Programátor Perl", "Programátor PHP", "Programátor PLC", "Programátor Python", "Projektant", "Projektový manažer", "Promotér", "Provozář", "Provozní manažer", "Psycholog", "Rada", "Radiologický asistent", "Realitní makléř", "Recepční", "Recruiter, specialista pro nábor", "Referent", "Referent - specialista, vyšší referent", "Referent odbytu", "Referent správy pohledávek", "Referent správy pojištění", "Referent správy smluv", "Referent výběru pojistného", "Referent zúčtování", "Regionální / Oblastní manažer", "Regulatory affairs manager", "Regulatory affairs specialist", "Revizní technik", "Risk manager", "Rozpočtář/kalkulant", "Rozpočtář/kalkulant staveb", "Ředitel IT", "Ředitel kvality a ISO", "Ředitel logistiky", "Ředitel pobočky", "Řezník", "Řidič", "Řidič autobusu", "Řidič kamionu", "Řidič vysokozdvižného vozíku", "Sádrokartonář", "Sanitář", "Sekretářka", "SEO analytik", "Seřizovač CNC strojů", "Seřizovač strojů", "Servisní inženýr", "Servisní technik", "Simulační inženýr", "Skladník", "Sklář", "Slévač", "Social media specialist", "Sociální pracovník", "Softwarový inženýr", "Sommeliér", "Soustružník", "Specialista analýz a rozvoje přenosových sítí", "Specialista back office", "Specialista fakturace a plateb", "Specialista finančních trhů", "Specialista interní komunikace", "Specialista ISO", "Specialista IT bezpečnosti", "Specialista kontroly plátců pojistného", "Specialista marketingových analýz", "Specialista modelování sítí", "Specialista odměňování a benefitů", "Specialista optimalizace rádiové sítě", "Specialista plánování rádiové sítě", "Specialista podpory zákazníků", "Specialista pohledávek", "Specialista prevence podvodů", "Specialista pro veřejné zakázky", "Specialista pro vzdělávání", "Specialista provozu sítí a služeb", "Specialista reportingu", "Specialista rizik", "Specialista rozvoje spojovací sítě", "Specialista strategie sítě", "Specialista technické podpory/IT", "Specialista testování koncových zařízení", "Specialista vývoje produktů", "Specialista vývoje telekomunikačních produktů", "Specialista vývoje telekomunikačních služeb", "Speciální pedagog", "Speditér", "Správce budov", "Správce informačního systému", "Správce počítačové sítě", "Správce ubytovacího zařízení", "Statistik", "Stavbyvedoucí", "Stavební dozor", "Stavební inženýr", "Stavební mistr", "Stavební technik", "Stavební zámečník", "Strojní inženýr", "Strojní zámečník", "Strojník", "Supervizor call centra", "Svářeč", "Systémový administrátor", "Systémový inženýr", "Šéfkuchař", "Šička", "Team leader", "Technical writer", "Technický manažer", "Technický pracovník", "Technický ředitel", "Technik", "Technik BOZP", "Technik údržby", "Technolog", "Telefonní operátor", "Telemarketingový pracovník", "Tesař", "Tiskař", "Tlumočník", "Truhlář", "Účetní", "Údržbář", "Úvěrový specialista", "Učitel mateřské školy", "Uklízečka", "Underwriter/upisovatel", "User Experience Expert", "Vedoucí dopravy", "Vedoucí nákupu", "Vedoucí obchodní skupiny", "Vedoucí odbytu", "Vedoucí oddělení", "Vedoucí právního oddělení", "Vedoucí prodejny/provozu", "Vedoucí provozu", "Vedoucí servisu", "Vedoucí skladu", "Vedoucí technického oddělení", "Vedoucí údržby", "Vedoucí úseku prodejny", "Vedoucí výroby", "Veterinární lékař", "Visual merchandiser / Vizualista", "Vodohospodářský inženýr", "Vodohospodářský technik", "Vrátný, informátor", "Vrchní referent", "Vrchní sestra", "Všeobecná sestra", "Vychovatel", "Výkonný ředitel", "Výrobní ředitel", "Vyšší referent - specialista", "Výzkumný a vědecký pracovník", "Web designér", "Webmaster", "Zahradní architekt", "Zahradník", "Zástupce vedoucího prodejny/provozu", "Závozník", "Zdravotnický asistent", "Zdravotnický laborant", "Zdravotnický záchranář", "Zedník", "Zemědělský inženýr, agronom", "Zeměměřič/geodet", "Zubní asistent", "Zubní lékař"
        };
        private static string[] departmentNames = new[]
        {
            "Účetní", "Marketingové", "Finanční", "Dílna", "Recepce"
        };

        /// <summary>
        /// Random employee property
        /// 
        /// Contains realistic (not necessary unique) name, job possition, birth date and salary.
        /// </summary>
        public static Employee RandomEmployee
        {
            get
            {
                return new Employee(
                    Employee.NextID,
                    SampleDataGenerator.FirstName,
                    SampleDataGenerator.LastName,
                    SampleDataGenerator.Job,
                    SampleDataGenerator.BirthDate,
                    SampleDataGenerator.Salary
                );
            }
        }

        /// <summary>
        /// Random boss property
        /// 
        /// Contains realistic (not necessary unique) name, job possition, birth date, salary and department.
        /// </summary>
        public static Boss RandomBoss
        {
            get
            {
                return new Boss(
                    Boss.NextID,
                    SampleDataGenerator.FirstName,
                    SampleDataGenerator.LastName,
                    SampleDataGenerator.Job,
                    SampleDataGenerator.BirthDate,
                    SampleDataGenerator.Salary,
                    SampleDataGenerator.RandomDepartment
                );
            }
        }

        /// <summary>
        /// Random department property
        /// 
        /// Contains realistic (not necessary unique) name.
        /// </summary>
        public static Department RandomDepartment
        {
            get
            {
                return new Department(SampleDataGenerator.DepartmentName);
            }
        }

        /// <summary>
        /// Random first name property
        /// </summary>
        public static string FirstName
        {
            get
            {
                return SampleDataGenerator.firstNames[SampleDataGenerator.random.Next(SampleDataGenerator.firstNames.Length)];
            }
        }

        /// <summary>
        /// Random last name property
        /// </summary>
        public static string LastName
        {
            get
            {
                return SampleDataGenerator.lastNames[SampleDataGenerator.random.Next(SampleDataGenerator.lastNames.Length)];
            }
        }

        /// <summary>
        /// Random job property
        /// </summary>
        public static string Job
        {
            get
            {
                return SampleDataGenerator.jobs[SampleDataGenerator.random.Next(SampleDataGenerator.jobs.Length)];
            }
        }

        /// <summary>
        /// Random birth date property
        /// </summary>
        public static DateTime BirthDate
        {
            get
            {
                return DateTime.Now // Nobody can be born in the future
                    .Subtract(new TimeSpan(18 * 366, 0, 0, 0)) // An employee has to be at least 18 (child labor is illegal)
                    .Subtract(new TimeSpan((int)(SampleDataGenerator.random.NextDouble() * 40 * 365.2425 * 24), 0, 0)) // Age between 18 and 58
                ;
            }
        }

        /// <summary>
        /// Random salary property
        /// </summary>
        public static double Salary
        {
            get
            {
                // 11 000 to 66 000
                return (int)(SampleDataGenerator.random.NextDouble() * 550 + 110) * 100;
            }
        }

        /// <summary>
        /// Random department name property
        /// </summary>
        public static string DepartmentName
        {
            get
            {
                return SampleDataGenerator.departmentNames[SampleDataGenerator.random.Next(SampleDataGenerator.departmentNames.Length)];
            }
        }
    }
}
