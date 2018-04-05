// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Proxy.V1.Service.Session.Participant;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var messageInteractions = MessageInteractionResource.Read(
            pathServiceSid: "KSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            pathSessionSid: "KCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            pathParticipantSid: "KPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        );

        foreach(var record in messageInteractions) {
           Console.WriteLine(record.Sid);
        }
    }
}