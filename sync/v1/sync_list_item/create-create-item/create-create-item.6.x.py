# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

sync_list_item = client.sync.services("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
    .sync_lists("ESaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa") \
    .sync_list_items \
    .create(
         data={"number": "001", "name": "Bulbasaur", "attack": 49},
         ttl=864000
     )

print(sync_list_item.index)