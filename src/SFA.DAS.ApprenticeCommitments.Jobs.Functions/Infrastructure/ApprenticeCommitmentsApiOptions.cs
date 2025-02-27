﻿using SFA.DAS.Http.Configuration;

namespace SFA.DAS.ApprenticeCommitments.Jobs.Functions.Infrastructure
{
    public class ApprenticeCommitmentsApiOptions : IApimClientConfiguration
    {
        public const string ApprenticeCommitmentsApi = "ApprenticeCommitmentsApi";
        public string ApiBaseUrl { get; set; }
        public string SubscriptionKey { get; set; }
        public string ApiVersion { get; set; }
    }
}
