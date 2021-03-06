// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Wireless.V1;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var command = CommandResource.Create(
            commandMode: CommandResource.CommandModeEnum.Binary,
            sim: "AliceSmithSmartMeter",
            command: "SGVsbG8sIE1hY2hpbmUh=="
        );

        Console.WriteLine(command.Sid);
    }
}
