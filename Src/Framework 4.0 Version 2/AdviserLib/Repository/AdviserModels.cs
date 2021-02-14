using System;
using System.Linq;

namespace EdlinSoftware.Adviser.Repository
{
    partial class AdviserStorage
    {
        public static AdviserStorage Current { get; set; }
    }

    partial class Language
    {
        private static Language m_Unknown;

        public static Language Unknown
        {
            get
            {
                return m_Unknown ?? (m_Unknown = GetUnknownLanguage());
            }
        }

        private static Language GetUnknownLanguage()
        {
            return AdviserStorage.Current.Languages.First(l => l.Name == "Unknown");
        }

        public static event EventHandler LanguagesListChanged;

        public static void RaiseLanguagesListChanged()
        {
            var handler = LanguagesListChanged;

            if (handler != null)
            {
                handler(null, EventArgs.Empty);
            }
        }
    }
}
