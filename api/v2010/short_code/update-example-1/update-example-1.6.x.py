# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

short_code = client.short_codes("SCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                   .update(sms_url="http://demo.twilio.com/docs/sms.xml")

print(short_code.sid)