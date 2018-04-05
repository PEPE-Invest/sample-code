// Install the Java helper library from twilio.com/docs/java/install

import com.twilio.Twilio;
import com.twilio.rest.api.v2010.account.SigningKey;

public class Example {
    // Find your Account Sid and Token at twilio.com/console
    public static final String ACCOUNT_SID = "ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
    public static final String AUTH_TOKEN = "your_auth_token";

    public static void main(String[] args) {
        Twilio.init(ACCOUNT_SID, AUTH_TOKEN);
        SigningKey signingKey = 
            SigningKey.updater("SKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")
            .setFriendlyName("friendlyName")
            .update();

        System.out.println(signingKey.getSid());
    }
}