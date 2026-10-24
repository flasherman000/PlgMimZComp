using Scada.Lang;

namespace Scada.Web.Plugins.PlgMimZComp
{
    /// <summary>
    /// Plugin metadata shared between the web and admin (View) assemblies.
    /// </summary>
    internal class PluginInfo : LibraryInfo
    {
        public override string Code => "PlgMimZComp";

        public override string Name => "Z Mimic Components";

        public override string Descr => "A set of custom components for display in mimic diagrams.";
    }
}
