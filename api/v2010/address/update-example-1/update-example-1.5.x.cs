// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var address = AddressResource.Update(
            customerName: "Customer 456",
            pathSid: "AD2a0747eba6abf96b7e3c3ff0b4530f6e",
            street: "2 Hasselhoff Lane"
        );

        Console.WriteLine(address.AccountSid);
    }
}