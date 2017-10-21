using System;

namespace INPTP_AppForFixing.Properties {
    
    
    // Tato třída umožňuje zpracovávat specifické události v třídě nastavení:
    //  Událost SettingChanging se vyvolá před změnou hodnoty nastavení.
    //  Událost PropertyChanged se vyvolá po změně hodnoty nastavení.
    //  Událost SettingsLoaded se vyvolá po načtení hodnot nastavení.
    //  Událost SettingsSaving se vyvolá před uložením hodnot nastavení.
    internal sealed partial class Settings {
        public delegate void SettingChangingEventhandler(object sender, System.Configuration.SettingChangingEventArgs e);
        public event SettingChangingEventhandler SettingChanging;
        public delegate void SettingSavingEventhandler(object sender, System.Configuration.SettingChangingEventArgs e);
        public event SettingChangingEventhandler SettingsSaving;
        public Settings() {
            // // Pro přidávání obslužných rutin událostí určených pro ukládání a změnu nastavení odkomentujte prosím níže uvedené řádky:
             this.SettingChanging += this.SettingChangingEventHandler;
             this.SettingsSaving += this.SettingsSavingEventHandler;
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Kód pro zpracování události SettingChangingEvent přidejte sem.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Kód pro zpracování události SettingsSaving přidejte sem.
        }
    }
}
