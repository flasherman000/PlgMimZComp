using Scada.Web.Plugins.PlgMimic.Components;
using Scada.Web.Plugins.PlgMimZComp.Code;
using Scada.Web.Services;

namespace Scada.Web.Plugins.PlgMimZComp
{
    /// <summary>
    /// Plugin entry point. Discovered by Webstation via the PlgXxxLogic naming convention.
    /// Implements IComponentPlugin so the Mimic editor picks up the component library.
    /// </summary>
    public class PlgMimZCompLogic : PluginLogic, IComponentPlugin
    {
        public PlgMimZCompLogic(IWebContext webContext)
            : base(webContext)
        {
            Info = new PluginInfo();
        }

        /// <summary>
        /// Returns the component spec for this library.
        /// editMode = true  → called by the Mimic editor (includes descriptor scripts for the property grid).
        /// editMode = false → called by the Mimic viewer (descriptor scripts omitted).
        /// </summary>
        public IComponentSpec GetComponentSpec(bool editMode) => new ZCompSpec(editMode);
    }
}
