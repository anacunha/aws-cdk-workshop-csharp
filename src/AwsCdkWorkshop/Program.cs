using Amazon.CDK;

namespace AwsCdkWorkshop
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new AwsCdkWorkshopStack(app, "AwsCdkWorkshopStack");

            app.Synth();
        }
    }
}
