# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

member = client.chat.v1.services("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                       .channels("CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                       .members("MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                       .update(role_sid="RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")

print(member.sid)