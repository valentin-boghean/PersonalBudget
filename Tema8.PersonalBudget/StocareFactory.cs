using Tema8.PersonalBudget;
using System.Configuration;

namespace NivelAccesDate
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    
                    case "txt":
                        return new AdministrareConturi(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
