// See https://aka.ms/new-console-template for more information
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

Console.WriteLine("Hello, World!");

//replace with your actual Twilio credentials
const string accountSid = "AVV_SID";
const string authToken = "auth_Token";

TwilioClient.Init(accountSid, authToken);

// replace with your Twilio phone number must start with +
var from = new PhoneNumber("+91*****35878");

// replace with your verified recipient phone number (yours, for testing)
var to = new PhoneNumber("+91*****35878");

// TwiML Bin url you created earlier
var twimlUrl = new Uri("https://handler.twilio.com/twiml/twiMLId");

var call = CallResource.Create(
    to: to,
    from: from,
    url: twimlUrl
);

Console.WriteLine($"Call initiated! Call SID: {call.Sid}");