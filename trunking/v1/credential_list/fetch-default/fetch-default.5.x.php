<?php

// Update the path below to your autoload.php,
// see https://getcomposer.org/doc/01-basic-usage.md
require_once '/path/to/vendor/autoload.php';

use Twilio\Rest\Client;

// Your Account Sid and Auth Token from twilio.com/console
$sid    = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
$token  = "your_auth_token";
$twilio = new Client($sid, $token);

$credential_list = $twilio->trunking->v1->trunks("TRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
                                        ->credentialsLists("CLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
                                        ->fetch();

print($credential_list->friendlyName);