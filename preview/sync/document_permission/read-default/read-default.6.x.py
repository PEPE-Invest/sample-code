# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

document_permissions = client.preview.sync \
                             .services("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                             .documents("ETaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
                             .document_permissions \
                             .list()

for record in document_permissions:
    print(record.account_sid)