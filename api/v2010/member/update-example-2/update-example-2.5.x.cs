// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Converters;
using Twilio.Rest.Api.V2010.Account.Queue;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var member = MemberResource.Update(
            pathCallSid: "CA5ef8732a3c49700934481addd5ce1659",
            method: Twilio.Http.HttpMethod.Post,
            pathQueueSid: "QU5ef8732a3c49700934481addd5ce1659",
            url: new Uri("http://demo.twilio.com/docs/voice.xml")
        );

        Console.WriteLine(member.CallSid);
    }
}