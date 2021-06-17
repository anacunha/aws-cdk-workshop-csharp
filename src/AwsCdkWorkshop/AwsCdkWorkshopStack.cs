using Amazon.CDK;
using Amazon.CDK.AWS.SNS;
using Amazon.CDK.AWS.SNS.Subscriptions;
using Amazon.CDK.AWS.SQS;

namespace AwsCdkWorkshop
{
    public class AwsCdkWorkshopStack : Stack
    {
        internal AwsCdkWorkshopStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
             // The CDK includes built-in constructs for most resource types, such as Queues and Topics.
            var queue = new Queue(this, "AwsCdkWorkshopQueue", new QueueProps
            {
                VisibilityTimeout = Duration.Seconds(300)
            });

            var topic = new Topic(this, "AwsCdkWorkshopTopic");

            topic.AddSubscription(new SqsSubscription(queue));
        }
    }
}
