// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Video.V1.Room.Participant;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var subscribedTracks = SubscribedTrackResource.Read(
            pathRoomSid: "RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            pathSubscriberSid: "PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        );

        foreach(var record in subscribedTracks) {
           Console.WriteLine(record.Sid);
        }
    }
}