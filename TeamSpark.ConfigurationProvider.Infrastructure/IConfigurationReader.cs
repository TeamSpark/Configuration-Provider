namespace TeamSpark.ConfigurationProvider.Infrastructure
{
	public interface IConfigurationReader
	{
		string GetConfigurationValue(string key, string defaultValue = null);
	}
}
