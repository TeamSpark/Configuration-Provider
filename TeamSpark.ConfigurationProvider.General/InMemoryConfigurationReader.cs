using System.Collections.Generic;
using TeamSpark.ConfigurationProvider.Infrastructure;

namespace TeamSpark.ConfigurationProvider.General
{
	public sealed class InMemoryConfigurationReader : IConfigurationReader
	{
		private Dictionary<string, string> _configurationVault = new Dictionary<string,string>();

		public void AddOrUpdateConfiguration(string key, string value)
		{
			if (_configurationVault.ContainsKey(key))
			{
				_configurationVault[key] = value;
			}
			else
			{
				_configurationVault.Add(key, value);
			}
		}

		public string GetConfigurationValue(string key, string defaultValue = null)
		{
			return _configurationVault.ContainsKey(key) ?
				_configurationVault[key] :
				defaultValue;
		}
	}
}
