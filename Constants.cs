namespace SauceLabs.SeleniumExamples
 
{
    /// <summary>contains constants used by the tests such as the user name and password for the sauce labs</summary>
    internal static class Constants
    {
        /// <summary>name of the sauce labs account that will be used</summary>
        internal const string SAUCE_LABS_ACCOUNT_NAME = "Your Account Name";
        /// <summary>account key for the sauce labs account that will be used</summary>
        internal const string SAUCE_LABS_ACCOUNT_KEY = "Your Access Key";
 
        // NOTE:
        // To change the maximum number of parallel tests edit DegreeOfParallelism in AssemblyInfo.cs
 
    }
}