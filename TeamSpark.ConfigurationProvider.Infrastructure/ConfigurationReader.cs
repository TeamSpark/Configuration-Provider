using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamSpark.ConfigurationProvider.Infrastructure
{
	public sealed class ConfigurationReader : IConfigurationReader
	{
		private List<IConfigurationReader> _configurationReaders = new List<IConfigurationReader>();

		#region Singleton

		private static Lazy<ConfigurationReader> _instance = new Lazy<ConfigurationReader>(() => { return new ConfigurationReader(); });

		public static ConfigurationReader Instance
		{
			get
			{
				return _instance.Value;
			}
		}

		private ConfigurationReader()
		{
		}

		#endregion

		
		#region IConfigurationReader

		public string GetConfigurationValue(string key, string defaultValue = null)
		{
			foreach (var reader in _configurationReaders)
			{
				var configurationValue = reader.GetConfigurationValue(key, defaultValue);
				if (configurationValue != defaultValue)
				{
					return configurationValue;
				}
			}

			return defaultValue;
		}

		#endregion
	}
}
