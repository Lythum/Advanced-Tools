using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTools.PluginMetadata
{
	/// <summary>
	/// Main interface which shall be received from plygin DLL file, 
	/// which enumerates all availe in specific DLL file plugins
	/// </summary>
	public interface IPluginsFactory
	{
		IEnumerable<IPlugin> Plugins { get; }
	}
}
