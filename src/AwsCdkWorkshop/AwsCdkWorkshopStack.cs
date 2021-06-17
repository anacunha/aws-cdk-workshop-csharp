using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.APIGateway;

namespace AwsCdkWorkshop
{
    public class AwsCdkWorkshopStack : Stack
    {
        internal AwsCdkWorkshopStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var hello = new Function(this, "HelloHandler", new FunctionProps
            {
                Runtime = Runtime.NODEJS_14_X,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            new LambdaRestApi(this, "Endpoint", new LambdaRestApiProps
            {
                Handler = hello
            });
        }
    }
}
