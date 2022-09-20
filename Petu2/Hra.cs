using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Petu2
{
    [DataContract]
    public static class Hra
    {
        // ActivePet - Dostaneš PET aktivního aktualním loadu
        // Slozkanenalezena - Pokud .exe zjisti že chybí soubor ulozeni.xml tak to přepne na true  Default: true
        // IndexPet - Jde o vybraný index peta, při výběru v load menu  Default: 0
        // Pets - List ve kterém jsou všechny Pets

        //       Enums
        //
        // Rarity - Jake existují rarity
        // Category - Jaké kategorie
        // ChestTier - Jake typy chestek existují
        //      Obrazky
        //  WoodenChestOpen,
        //  WoodenChestClosed,
        //  IronChestOpen,
        //  IronChestClosed,
        //  GoldChestOpen,
        //  GoldChestClosed,
        // PhotoOfPets - Fotky z PetsPic, jsou tam jen obrazky petu
        // Photo - Vsechny obrazky v ItemPic
        // FoodEnum - Všechny obrazky kategorie: food


        //          Gettery
        //
        //  GetCountOfFoodPhoto INT - dostaneš počet jidel ve hře
        //  GetObrazekPhoto(Enum) Image - dostaneš image po zadání enumu
        //  GetRandomItemFoodPicturebox PictureBox - dostaneš picture box, kde je náhodný obrazk z FoodEnum
        //  GetRandomFoodItem(Hra.ChestTier) hra.food - po zadání tieru dostaneš předmět, který je náhodně vygenerovaný
        //  GetColorOfRarity(Hra.Rarity) Color - Po zadání rarity vrazí barvu předmětu


        //          Clasy
        //    Pet
        //          ImageOfPet IMAGE - dostaneš obrazek Peta
        //          ImageToString Hra.PhotoOfPets - Dostaneš enum obrazku Peta
        //          Name String - Dostaneš nazev peta
        //          Hunger INT - dostaneš Jidlo 0 - 1000
        //          Level INT - 
        //          XP INT -
        //          xpRange INT[] - 
        //          Hats
        //          Tickets
        //          Foods
        //          Chests
        //          graphicCards

        //  Voids
        //  ReloadallPets - Obnoví všem petum v seznamu "pets" jejich proměnou "ImageOfPet"


        public static Pet ActivePet { get { return pets[IndexPet]; } set { pets[IndexPet] = value; } }
        public static bool SlozkaNalezena = true;
        public static int IndexPet = 0;
        public static List<Pet> pets = new List<Pet>();
        public enum Rarity { Common, Rare, Epic, Legendary };
        public enum Category { Hat, Ticket, Food, GraphicCard, Achivment, Chest }

        public enum ChestTier { Wooden, Iron, Gold }
        public enum PhotoOfPets { cat, Cutecat, Red_panda, squrtle };
        public enum Photo {
            Apple,
            HearthBottle,
            Muffin,
            WaterBottle,
            WoodenChestOpen,
            WoodenChestClosed,
            IronChestOpen,
            IronChestClosed,
            GoldChestOpen,
            GoldChestClosed,
        };
        public enum FoodEnum
        {
            Apple,
            HearthBottle,
            Muffin,
            WaterBottle

        };
        public static int GetCountOfFoodPhoto
        {
            get { return Enum.GetNames(typeof(FoodEnum)).Length; }
        }
        
            
        


        [DataContract]
        public class Pet
        {
            public Image ImageOfPet;
            [DataMember] public PhotoOfPets ImageToString;
            [DataMember] public string Name;
            [DataMember] public int Hunger;
            [DataMember] public int Level;
            [DataMember] public int xp;
            [DataMember] public int[] xpRange;
            [DataMember] public List<Hat> hats = new List<Hat>();
            [DataMember] public List<Ticket> tickets = new List<Ticket>();
            [DataMember] public List<Food> foods = new List<Food>();
            [DataMember] public List<GraphicCard> graphicCards = new List<GraphicCard>();
            [DataMember] public List<Chest> chests = new List<Chest>();

            public Pet(string Jmeno, PhotoOfPets _PicutreToString)
            {
                Name = Jmeno;
                Food lol = new Food("Apple", Rarity.Epic, Photo.Apple, 50);
                Ticket pop = new Ticket("Begginer Trial", Rarity.Legendary, Photo.WaterBottle);
                Chest dop = new Chest("Open me!", Rarity.Rare, Photo.WoodenChestClosed,ChestTier.Wooden);
                

                foods.Add(lol);
                tickets.Add(pop);
                chests.Add(dop);
              

                Hunger = 500;
                ImageToString = _PicutreToString;
                ImageOfPet = (Image)Obrazky.PetsPic.ResourceManager.GetObject(Enum.GetName(typeof(PhotoOfPets), _PicutreToString));
            }
            public void Reload()
            {
                ImageOfPet = (Image)Obrazky.PetsPic.ResourceManager.GetObject(Enum.GetName(typeof(PhotoOfPets), ImageToString));
                foreach (Food food in foods)
                {
                    food.ReloadImage();
                }
                foreach (Hat hat in hats)
                {
                    hat.ReloadImage();
                }
                foreach (GraphicCard graphicCard in graphicCards)
                {
                    graphicCard.ReloadImage();
                }
                foreach (Ticket tickets in tickets)
                {
                    tickets.ReloadImage();
                }
            }
        }
        
        [DataContract]
        public class Item
        {
            [DataMember] Category Typ;
            [DataMember] public Rarity rarity;
            [DataMember] public string Name;
            [DataMember] public string ID;
            public Image PicutureToView;
            [DataMember] public Photo Picture;
            public Item(string Nazev, Rarity _rarity, Category _typ, Photo _picture)
            {
                Name = Nazev;
                Typ = _typ;
                rarity = _rarity;
                Picture = _picture;
                Random rnd = new Random();
                ID = Nazev + "_" + _typ.ToString() + "_" + _rarity.ToString() + "__" + rnd.Next();
                PicutureToView = (Image)Obrazky.ItemPic.ResourceManager.GetObject(Enum.GetName(typeof(Photo), _picture));
            }
            public void ReloadImage()
            {
                PicutureToView = (Image)Obrazky.ItemPic.ResourceManager.GetObject(Enum.GetName(typeof(Photo), Picture));
            }
        }
        
        [DataContract]
        public class Hat : Item
        {
            public Hat(string Nazev,Rarity _rarity, Photo _picture) : base (Nazev,_rarity,Category.Hat, _picture)
            {
            
            }
        }

        [DataContract]
        public class Ticket : Item
        {
            public Ticket(string Nazev, Rarity _rarity, Photo _picture) : base(Nazev, _rarity, Category.Ticket, _picture)
            {

            }
        }

        [DataContract]
        public class Food : Item
        {
            [DataMember]public int HowMuchToAdd;
            public Food(string Nazev, Rarity _rarity, Photo _picture, int Attribute) : base(Nazev, _rarity, Category.Food, _picture)
            {
                HowMuchToAdd = Attribute;
            }
        }

        [DataContract]
        public class GraphicCard : Item
        {
            public GraphicCard(string Nazev, Rarity _rarity, Photo _picture) : base(Nazev, _rarity, Category.GraphicCard, _picture)
            {

            }
        }

        [DataContract]
        public class Achivment : Item
        {
            public Achivment(string Nazev, Rarity _rarity, Photo _picture) : base(Nazev, _rarity, Category.Achivment, _picture)
            {

            }
        }
        [DataContract]
        public class Chest : Item
        {
            [DataMember] public Hra.ChestTier ChestTier;
            public Chest(string Nazev, Rarity _rarity, Photo _picture, ChestTier chestTier) : base(Nazev, _rarity, Category.Chest, _picture)
            {
                ChestTier = chestTier;
            }
        }

        public static void ReloadAllPets()
        {
            if (Hra.pets != null)
            {
                foreach (Hra.Pet o in Hra.pets)
                {
                    o.Reload();
                }
            }
        }
        // Save Load
        public static void SaveViaDataContractSerialization<T>(T serializableObject, string filepath)
        {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filepath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }
        public static T LoadViaDataContractSerialization<T>(string filepath)
        {
            var fileStream = new FileStream(filepath, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T)serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }
        // Save load

        public static Image GetObrazekPhoto(Hra.Photo Typ)
        {
            return (Image)Obrazky.ItemPic.ResourceManager.GetObject(Enum.GetName(typeof(Hra.Photo), Typ));
        }
        public static Image GetObrazekPhoto(Hra.PhotoOfPets Typ)
        {
            return (Image)Obrazky.PetsPic.ResourceManager.GetObject(Enum.GetName(typeof(Hra.PhotoOfPets), Typ));
        }
        public static Image GetObrazekPhoto(Hra.FoodEnum Typ)
        {
            return (Image)Obrazky.ItemPic.ResourceManager.GetObject(Enum.GetName(typeof(Hra.FoodEnum), Typ));
        }
        public static PictureBox GetRandomItemFoodPicturebox()
        {
            
            PictureBox pictureBox = new PictureBox();
            int x = Enum.GetNames(typeof(Hra.FoodEnum)).Length;
            Random rnd = new Random();
            Hra.FoodEnum aa = (FoodEnum)rnd.Next(0, x);
            pictureBox.Name = Enum.GetName(typeof(Hra.FoodEnum), aa).ToString();
            pictureBox.Image = GetObrazekPhoto(aa);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            return pictureBox;
        }

        public static Food GetRandomFoodItem(Hra.ChestTier TierOfLoot)
        {
            Random rnd = new Random();

            // Rarita + pridani Hungeru
            Hra.Rarity RaritaPredmetu = new Hra.Rarity();
            int PridaniHungeruPredemtu = 0;

            int nahoda = rnd.Next(0, 95);

            //Základní hodnoty
            int NahodaCommon = 100;
            int NahodaRare = 100;
            int NahodaEpic = 100;
            int NahodaLegendary = 100;

            switch (TierOfLoot)
            {
                case Hra.ChestTier.Wooden:
                    NahodaCommon -= GetSancePriRarity.WoodenCommon;
                    NahodaRare -= GetSancePriRarity.WoodenRare;
                    NahodaEpic -= GetSancePriRarity.WoodenEpic;
                    NahodaLegendary -= GetSancePriRarity.WoodenLegendary;
                    break;
                case Hra.ChestTier.Iron:
                    NahodaCommon -= GetSancePriRarity.IronCommon;
                    NahodaRare -= GetSancePriRarity.IronRare;
                    NahodaEpic -= GetSancePriRarity.IronEpic;
                    NahodaLegendary -= GetSancePriRarity.IronLegendary;
                    break;
                case Hra.ChestTier.Gold:
                    NahodaCommon -= GetSancePriRarity.GoldCommon;
                    NahodaRare -= GetSancePriRarity.GoldRare;
                    NahodaEpic -= GetSancePriRarity.GoldEpic;
                    NahodaLegendary -= GetSancePriRarity.GoldLegendary;
                    break;
            }




            if (nahoda <= NahodaCommon)
            {
                RaritaPredmetu = Hra.Rarity.Common;
                PridaniHungeruPredemtu = 150;
            }
            else if (nahoda <= NahodaRare)
            {
                RaritaPredmetu = Hra.Rarity.Rare;
                PridaniHungeruPredemtu = 300;
            }
            else if (nahoda <= NahodaEpic)
            {
                RaritaPredmetu = Hra.Rarity.Epic;
                PridaniHungeruPredemtu = 600;
            }
            else if (nahoda <= NahodaLegendary)
            {
                RaritaPredmetu = Hra.Rarity.Legendary;
                PridaniHungeruPredemtu = 900;
            }

           
            //

            //Obrazek
            Hra.Photo PhotoPredmetu = new Hra.Photo();

            int nahodaNaObrazek = rnd.Next(0, Hra.GetCountOfFoodPhoto);

            PhotoPredmetu = (Hra.Photo)nahodaNaObrazek;

            // Nazev
            string NazevPredmetu = PhotoPredmetu.ToString();


            return new Food(NazevPredmetu, RaritaPredmetu, PhotoPredmetu, PridaniHungeruPredemtu);



        }
        public static Color GetColorOfRarity(Hra.Rarity JakaRarita)
        {
            switch (JakaRarita)
            {
                case Hra.Rarity.Common:
                    return Color.Green;
          
                case Hra.Rarity.Rare:
                    return Color.LightBlue;
         
                case Hra.Rarity.Epic:
                    return Color.Purple;
                
                case Hra.Rarity.Legendary:
                    return Color.Orange;
                   
                default:
                    return Color.Black;
                 
            }
        }
        
        public static class GetSancePriRarity
        {
            public const int WoodenCommon = 60;
            public const int WoodenRare = 25;
            public const int WoodenEpic = 10;
            public const int WoodenLegendary = 5;

            public const int IronCommon = 40;
            public const int IronRare = 35;
            public const int IronEpic = 20;
            public const int IronLegendary = 5;

            public const int GoldCommon = 10;
            public const int GoldRare = 35;
            public const int GoldEpic = 20;
            public const int GoldLegendary = 10;
        }
    }
   
}
