using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTools.FeaturesMetadata
{
	/// <summary>
	/// Main interface which shall be received from features, plugins DLL file, 
	/// which enumerates all availe in specific DLL file features
	/// </summary>
	public interface IFeaturesFactory
	{
		IEnumerable<IFeature> Plugins { get; }
	}
}
