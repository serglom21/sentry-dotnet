using Sentry; 
 public static class SentryUtil
    {
        public static void ConfigureBaseScope()
        {
            SentrySdk.ConfigureScope(scope =>
            {
                scope.SetTags(new Dictionary<string, string>()
                {
                    {
                        "jenkins_build_number",
                        "123456"
                    },
                    {
                        "server_name",
                        "test"
                    }
                });

                scope.SetExtra("env", "test_env");
            });
        }
    }