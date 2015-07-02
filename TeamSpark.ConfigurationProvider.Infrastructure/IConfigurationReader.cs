using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamSpark.ConfigurationProvider.Infrastructure
{
	public interface IConfigurationReader
	{
		string GetConfigurationValue(string key, string defaultValue = null);
	}
}
