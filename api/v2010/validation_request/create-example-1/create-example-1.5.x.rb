# Download the helper library from https://www.twilio.com/docs/ruby/install
require 'rubygems'
require 'twilio-ruby'

# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
@client = Twilio::REST::Client.new(account_sid, auth_token)

validation_request = @client.validation_requests
                            .create(
                               phone_number: '+14158675310',
                               friendly_name: 'My Home Phone Number'
                             )

puts validation_request.account_sid