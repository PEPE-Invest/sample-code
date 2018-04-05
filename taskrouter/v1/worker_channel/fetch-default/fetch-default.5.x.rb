# Download the helper library from https://www.twilio.com/docs/ruby/install
require 'rubygems'
require 'twilio-ruby'

# Your Account Sid and Auth Token from twilio.com/console
account_sid = 'ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
auth_token = 'your_auth_token'
@client = Twilio::REST::Client.new(account_sid, auth_token)

worker_channel = @client.taskrouter
                        .workspaces('WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')
                        .workers('WKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')
                        .worker_channels('WCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa')
                        .fetch

puts worker_channel.sid