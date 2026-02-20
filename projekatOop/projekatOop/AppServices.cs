using System;

namespace projekatOop
{
    /// <summary>
    /// Centralno mesto za deljenje singleton repozitorijuma unutar aplikacije.
    /// Koristi se da bi forme delile iste instance (RasporedForm, ZaposleniForm, itd.).
    /// </summary>
    public static class AppServices
    {
        public static readonly ProfesorRepository ProfesorRepo = new ProfesorRepository();
        public static readonly RasporedRepository RasporedRepo = new RasporedRepository();
    }
}