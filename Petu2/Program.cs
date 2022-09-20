using Petu2.MainGame.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Hra.pets = Hra.LoadViaDataContractSerialization<List<Hra.Pet>>("ulozeni.xml");
            }
            catch
            {
                Hra.SlozkaNalezena = false;
            }
            Hra.ReloadAllPets();
            if (Hra.pets == null)
            {
                Hra.pets = new List<Hra.Pet>();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PlayDungeon());
            
        }
    }
}
